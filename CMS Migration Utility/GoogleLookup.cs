using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;
using System.Configuration;

namespace CMS_Migration_Utility
{
    class GoogleLookup
    {
        public List<string> PerformGoogleLookup(string lookupText)
        {
            List<string> listNodes = null;

            string base64str = "TgBhAHQAaABhAG4AcwAkADEA";
            SpreadsheetsService service = AuthenticateGoogleUser(base64str);

            SpreadsheetEntry spEntry = GetSpreadSheetEntry(service);
            CellFeed cellFeed = GetCellFeed(service, spEntry);

            listNodes = GetNodeMatches(cellFeed, lookupText);

            return listNodes;
        }
        private List<string> GetNodeMatches(CellFeed cellFeed, string lookupText)
        {
            List<string> listNodes = new List<string>();
            for (int i = 0; i < cellFeed.Entries.Count; i = i + 2)
            {
                CellEntry curCell = (CellEntry)cellFeed.Entries[i];
                string urlText = curCell.Value;
                if (!string.IsNullOrWhiteSpace(urlText) && urlText.Contains(lookupText))
                {
                    CellEntry nextCell = (CellEntry)cellFeed.Entries[i + 1];
                    listNodes.Add(nextCell.Value);
                    break;
                }
            }
            return listNodes;
        }
        private SpreadsheetsService AuthenticateGoogleUser(string val)
        {
            SpreadsheetsService service = new SpreadsheetsService("NodeLookupProgram");
            service.setUserCredentials(ConfigurationManager.AppSettings["username"].ToString(), ConfigurationManager.AppSettings["passcode"].ToString());

            return service;
        }
        private CellFeed GetCellFeed(SpreadsheetsService service, SpreadsheetEntry spEntry)
        {
            WorksheetFeed wsFeed = spEntry.Worksheets;
            WorksheetEntry wsEntry = (WorksheetEntry)wsFeed.Entries[0];

            AtomLink wLink = wsEntry.Links.FindService(GDataSpreadsheetsNameTable.CellRel, null);

            CellQuery cellQuery = new CellQuery(wLink.HRef.ToString());
            CellFeed cellFeed = service.Query(cellQuery);

            return cellFeed;
        }
        private SpreadsheetEntry GetSpreadSheetEntry(SpreadsheetsService service)
        {
            SpreadsheetQuery spquery = new SpreadsheetQuery();
            SpreadsheetFeed spfeed = service.Query(spquery);

            SpreadsheetEntry spEntry = null;
            foreach (SpreadsheetEntry entry in spfeed.Entries)
            {
                string fileName = ConfigurationManager.AppSettings["fileNameGoogle"].ToString();
                if (entry.Title.Text.Contains(fileName))
                {
                    spEntry = entry;
                    break;
                }
            }
            return spEntry;
        }
    }
}
