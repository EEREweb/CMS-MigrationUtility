namespace CMS_Migration_Utility
{
    partial class formMigration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.btnScrub = new System.Windows.Forms.Button();
            this.btnOpenCMS = new System.Windows.Forms.Button();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.cbEdit = new System.Windows.Forms.CheckBox();
            this.lblCurrentURL = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbCenter = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtReplaced = new System.Windows.Forms.TextBox();
            this.txtAttention = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnreplaced = new System.Windows.Forms.Label();
            this.btnLoadURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(586, 85);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.MaxLength = 2147483647;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(500, 568);
            this.txtOutput.TabIndex = 8;
            this.txtOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOutput_MouseDown);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(75, 25);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1011, 20);
            this.txtInput.TabIndex = 7;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(76, 58);
            this.lblOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(65, 13);
            this.lblOriginal.TabIndex = 6;
            this.lblOriginal.Text = "Center Text:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(11, 25);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(59, 13);
            this.lblURL.TabIndex = 5;
            this.lblURL.Text = "Input URL:";
            // 
            // btnScrub
            // 
            this.btnScrub.Location = new System.Drawing.Point(79, 678);
            this.btnScrub.Margin = new System.Windows.Forms.Padding(2);
            this.btnScrub.Name = "btnScrub";
            this.btnScrub.Size = new System.Drawing.Size(115, 40);
            this.btnScrub.TabIndex = 9;
            this.btnScrub.Text = "Strip And Replace";
            this.btnScrub.UseVisualStyleBackColor = true;
            this.btnScrub.Click += new System.EventHandler(this.btnScrub_Click);
            // 
            // btnOpenCMS
            // 
            this.btnOpenCMS.Location = new System.Drawing.Point(1001, 677);
            this.btnOpenCMS.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCMS.Name = "btnOpenCMS";
            this.btnOpenCMS.Size = new System.Drawing.Size(76, 40);
            this.btnOpenCMS.TabIndex = 10;
            this.btnOpenCMS.Text = "Edit in CMS";
            this.btnOpenCMS.UseVisualStyleBackColor = true;
            this.btnOpenCMS.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(75, 85);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOriginal.MaxLength = 2147483647;
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginal.Size = new System.Drawing.Size(500, 568);
            this.txtOriginal.TabIndex = 12;
            this.txtOriginal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOriginal_MouseDown);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(583, 58);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Text = "Output:";
            // 
            // cbEdit
            // 
            this.cbEdit.AutoSize = true;
            this.cbEdit.Location = new System.Drawing.Point(1007, 58);
            this.cbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(79, 17);
            this.cbEdit.TabIndex = 14;
            this.cbEdit.Text = "Edit Output";
            this.cbEdit.UseVisualStyleBackColor = true;
            this.cbEdit.CheckedChanged += new System.EventHandler(this.cbEdit_Checked);
            // 
            // lblCurrentURL
            // 
            this.lblCurrentURL.AutoSize = true;
            this.lblCurrentURL.Location = new System.Drawing.Point(263, 678);
            this.lblCurrentURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentURL.Name = "lblCurrentURL";
            this.lblCurrentURL.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentURL.TabIndex = 15;
            this.lblCurrentURL.Text = "                           ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(263, 704);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 13);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "               ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(223, 678);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // cbCenter
            // 
            this.cbCenter.AutoSize = true;
            this.cbCenter.Location = new System.Drawing.Point(473, 59);
            this.cbCenter.Margin = new System.Windows.Forms.Padding(2);
            this.cbCenter.Name = "cbCenter";
            this.cbCenter.Size = new System.Drawing.Size(102, 17);
            this.cbCenter.TabIndex = 18;
            this.cbCenter.Text = "Edit Center Text";
            this.cbCenter.UseVisualStyleBackColor = true;
            this.cbCenter.Click += new System.EventHandler(this.cbCenter_Checked);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(903, 677);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 41);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtReplaced
            // 
            this.txtReplaced.Location = new System.Drawing.Point(1113, 85);
            this.txtReplaced.Multiline = true;
            this.txtReplaced.Name = "txtReplaced";
            this.txtReplaced.ReadOnly = true;
            this.txtReplaced.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaced.Size = new System.Drawing.Size(344, 260);
            this.txtReplaced.TabIndex = 20;
            // 
            // txtAttention
            // 
            this.txtAttention.Location = new System.Drawing.Point(1113, 393);
            this.txtAttention.Multiline = true;
            this.txtAttention.Name = "txtAttention";
            this.txtAttention.ReadOnly = true;
            this.txtAttention.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttention.Size = new System.Drawing.Size(344, 260);
            this.txtAttention.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1110, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Replaced URL List";
            // 
            // lblUnreplaced
            // 
            this.lblUnreplaced.AutoSize = true;
            this.lblUnreplaced.Location = new System.Drawing.Point(1110, 364);
            this.lblUnreplaced.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnreplaced.Name = "lblUnreplaced";
            this.lblUnreplaced.Size = new System.Drawing.Size(122, 13);
            this.lblUnreplaced.TabIndex = 23;
            this.lblUnreplaced.Text = "URLs Needing Attention";
            // 
            // btnLoadURL
            // 
            this.btnLoadURL.Location = new System.Drawing.Point(1113, 11);
            this.btnLoadURL.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadURL.Name = "btnLoadURL";
            this.btnLoadURL.Size = new System.Drawing.Size(94, 34);
            this.btnLoadURL.TabIndex = 24;
            this.btnLoadURL.Text = "Go To Page";
            this.btnLoadURL.UseVisualStyleBackColor = true;
            this.btnLoadURL.Click += new System.EventHandler(this.btnLoadURL_Click);
            // 
            // formMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 741);
            this.Controls.Add(this.btnLoadURL);
            this.Controls.Add(this.lblUnreplaced);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttention);
            this.Controls.Add(this.txtReplaced);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbCenter);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCurrentURL);
            this.Controls.Add(this.cbEdit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnOpenCMS);
            this.Controls.Add(this.btnScrub);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblURL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMigration";
            this.Text = "CMS Migration Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnScrub;
        private System.Windows.Forms.Button btnOpenCMS;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox cbEdit;
        private System.Windows.Forms.Label lblCurrentURL;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbCenter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtReplaced;
        private System.Windows.Forms.TextBox txtAttention;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnreplaced;
        private System.Windows.Forms.Button btnLoadURL;
    }
}

