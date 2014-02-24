using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace CMS_Migration_Utility
{
    public partial class formMigration : Form
    {
        public formMigration()
        {
            InitializeComponent();
            lblCurrentURL.Text = "Ready for next URL";
            cbCenter.Checked = true;
            txtOriginal.ReadOnly = !cbCenter.Checked;
        }

        private string nodeID { get; set; }
        private string centerContent { get; set; }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

                String webURL = txtInput.Text.Trim();

                if (!IsValidLink(webURL))
                {
                    lblCurrentURL.Text = "Invalid URL!";
                    return;
                }

                string allContent = GetURLContents(webURL);

                centerContent = ExtractCenterContent(allContent);

                if (string.IsNullOrWhiteSpace(centerContent))
                {
                    lblCurrentURL.Text = "Could not find center content for this URL";
                }
                else
                {
                    lblCurrentURL.Text = "Loaded URL's center content";
                }

                txtOutput.Text = lblTime.Text = "";
                txtOriginal.Text = centerContent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        private string ExtractCenterContent(string htmlContent)
        {
            string centerContent = string.Empty;

            string beginStr = "<!--BEGIN CENTER CONTENT-->";
            string endStr = "<!--END CENTER CONTENT-->";

            int startLocation = htmlContent.IndexOf(beginStr);
            int endLocation = htmlContent.IndexOf(endStr);

            if (startLocation == -1 || endLocation == -1) return string.Empty;

            centerContent = htmlContent.Substring(startLocation + beginStr.Length, endLocation - (startLocation + beginStr.Length));

            return centerContent;
        }
        private string GetNodeID(string webURL)
        {
            string id = string.Empty;
            DBLookup lookup = new DBLookup();

            if (webURL.IndexOf("http://") != -1) webURL = webURL.Substring(webURL.IndexOf('/', "http://".Length + 1));

            //if (webURL.IndexOf("/index.html") != -1) webURL = webURL.Replace("/index.html", "");

            List<string> nodeURLs = lookup.PerformDBLookup(webURL);

            if (nodeURLs.Count > 0)
            {
                id = nodeURLs[0].Replace("node/", "");
            }

            return id;
        }
        private string GetURLContents(string webURL)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            return client.DownloadString(webURL);
        }
        #region Events
        private void btnScrub_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            centerContent = txtOriginal.Text;

            SwapTags();
            StripTags();
            //TODO: StripAttributes();
            int numReplaced = ReplaceURLs();

            txtOutput.Text = centerContent;
            Clipboard.SetText(centerContent, TextDataFormat.Text);

            watch.Stop();

            lblCurrentURL.Text = "Strip and Replace operation completed!";
            lblTime.Text = "Replaced " + numReplaced + " unique links in " + (watch.ElapsedMilliseconds / 1000).ToString() + " second(s)";

            //System.Windows.Forms.MessageBox.Show("Done");
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(centerContent, TextDataFormat.Text);

            String webURL = txtInput.Text.Trim();
            nodeID = GetNodeID(webURL);

            lblCurrentURL.Text = "Ready for next URL";
            lblTime.Text = string.Empty;
            OpenCMSPage();
        }
        private void cbEdit_Checked(object sender, EventArgs e)
        {
            txtOutput.ReadOnly = !cbEdit.Checked;
        }
        private void cbCenter_Checked(object sender, EventArgs e)
        {
            //txtInput.Text = "";
            txtOriginal.ReadOnly = !cbCenter.Checked;
        }
        private void txtOutput_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtOutput.ReadOnly)
            {
                txtOutput.SelectAll();
                txtOutput.Copy();
            }
        }
        private void txtOriginal_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtOriginal.ReadOnly)
            {
                txtOriginal.SelectAll();
                txtOriginal.Copy();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtOriginal.Text = txtOutput.Text = txtAttention.Text = txtReplaced.Text = "";
        }
        #endregion

        private void OpenCMSPage()
        {
            Process.Start("\"https://cms.doe.gov\\node\\" + nodeID + "\\workflow\"");
        }
        private void btnLoadURL_Click(object sender, EventArgs e)
        {
            Process.Start(txtInput.Text.Trim());
        }
        private void SwapTags()
        {
            string[] tagsToFind = { "<h2", "</h2", "<h3", "</h3", @" title=""null""" };
            string[] tagReplacments = { "<h4", "</h4", "<h5", "</h5", "" };

            for (int i = 0; i < tagsToFind.Length; i++)
            {
                centerContent = centerContent.Replace(tagsToFind[i], tagReplacments[i]);
            }

        }
        private void StripTags()
        {
            string[] tagsToReplace = { "<img", "<script", "<style" };
            string[] endTags = { ">", "</script>", "</style>" };

            for (int i = 0; i < tagsToReplace.Length; i++)
            {
                for (int loc = centerContent.IndexOf(tagsToReplace[i]); loc != -1; loc = centerContent.IndexOf(tagsToReplace[i], loc))
                {
                    string textToRemove = centerContent.Substring(loc, centerContent.IndexOf(endTags[i], loc + tagsToReplace[i].Length + 2) - loc + endTags[i].Length);
                    centerContent = centerContent.Replace(textToRemove, "");
                }
            }
        }
        private void StripAttributes()
        {
            string[] attributes = { @" style=""", @" class=""", " style='", " class='" };
            string[] closingCharacter = { @"""", @"""", "'", "'" };

            for (int i = 0; i < attributes.Length; i++)
            {
                for (int loc = centerContent.IndexOf(attributes[i]); loc != -1; loc = centerContent.IndexOf(attributes[i], loc))
                {
                    string textToRemove = centerContent.Substring(loc, centerContent.IndexOf(closingCharacter[i], loc + attributes[i].Length + 1) - loc + 1);
                    centerContent = centerContent.Replace(textToRemove, "");
                }
            }
        }

        private int ReplaceURLs()
        {
            string matchText = @"href=""";

            DBLookup dbLookup = new DBLookup();

            int numReplaced = 0;
            for (int loc = centerContent.IndexOf(matchText); loc != -1; loc = centerContent.IndexOf(matchText, loc + matchText.Length))
            {
                string lookupText = string.Empty;
                int startLoc = loc + matchText.Length;
                lookupText = centerContent.Substring(startLoc, centerContent.IndexOf('"', startLoc) - startLoc);
                string fullText = lookupText;
                lookupText = lookupText.Trim();
                lblCurrentURL.Text = lookupText;
                Application.DoEvents();

                //if (!IsValidLink(lookupText)) continue;
                List<string> foundNodes = new List<string>();
                //Make sure to search for lookup text only when non-blank URL is found
                if (!string.IsNullOrWhiteSpace(lookupText))
                {
                    string startURLText = "http", endURLText = "energy.gov/";
                    int startURLpos = lookupText.IndexOf(startURLText), endURLpos = lookupText.IndexOf(endURLText);

                    if (startURLpos != -1 && endURLpos != -1) // if it is a fully qualified URL remove server/domain name from search string
                    {
                        string eereURLText = lookupText.Substring(startURLpos, endURLpos + endURLText.Length - startURLpos);
                        lookupText = lookupText.Replace(eereURLText, "");
                    }
                    
                    foundNodes = dbLookup.PerformDBLookup(lookupText);
                }
                
                if (foundNodes.Count > 0)
                {
                    centerContent = centerContent.Replace(fullText, foundNodes[0]);
                    numReplaced++;
                    txtReplaced.Text += fullText + Environment.NewLine;
                }
                else
                {
                    if (fullText.IndexOf("node/") == -1)
                    {
                        txtAttention.Text += fullText + Environment.NewLine;
                    }
                }
            }
            return numReplaced;
        }

        private bool IsValidLink(string lookupText)
        {
            bool result = false;
            string[] validFileTypes = { ".html", ".htm", ".doc", ".docx", ".xls", ".xlsx", ".txt", ".pdf" };

            foreach (string type in validFileTypes)
            {
                if (lookupText.EndsWith(type))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public IEnumerable<int> AllIndexesOf(string sourceString, string subString)
        {
            return Regex.Matches(sourceString, Regex.Escape(subString)).Cast<Match>().Select(m => m.Index);
        }
    }
}
