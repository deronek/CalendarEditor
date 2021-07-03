namespace CalendarEditor
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveIcs = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveXml = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveJson = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripButtonNew, this.toolStripButtonOpen, this.toolStripButtonSaveAll, this.toolStripButtonSaveIcs, this.toolStripButtonSaveXml, this.toolStripButtonSaveJson});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(373, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::CalendarEditor.Properties.Resources.Icons.EditDocument_16x;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "Clear all fields";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::CalendarEditor.Properties.Resources.Icons.FolderOpened_grey_16x;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Open file";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSaveAll
            // 
            this.toolStripButtonSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAll.Image = global::CalendarEditor.Properties.Resources.Icons.SaveAll_16x;
            this.toolStripButtonSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAll.Name = "toolStripButtonSaveAll";
            this.toolStripButtonSaveAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveAll.Text = "Save all formats";
            this.toolStripButtonSaveAll.Click += new System.EventHandler(this.toolStripButtonSaveAll_Click);
            // 
            // toolStripButtonSaveIcs
            // 
            this.toolStripButtonSaveIcs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveIcs.Image = global::CalendarEditor.Properties.Resources.Icons.IconFile_16x;
            this.toolStripButtonSaveIcs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveIcs.Name = "toolStripButtonSaveIcs";
            this.toolStripButtonSaveIcs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveIcs.Text = "Save ICS file";
            this.toolStripButtonSaveIcs.Click += new System.EventHandler(this.toolStripButtonSaveIcs_Click);
            // 
            // toolStripButtonSaveXml
            // 
            this.toolStripButtonSaveXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveXml.Image = global::CalendarEditor.Properties.Resources.Icons.XMLFile_16x;
            this.toolStripButtonSaveXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveXml.Name = "toolStripButtonSaveXml";
            this.toolStripButtonSaveXml.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveXml.Text = "Save XML file";
            this.toolStripButtonSaveXml.Click += new System.EventHandler(this.toolStripButtonSaveXml_Click);
            // 
            // toolStripButtonSaveJson
            // 
            this.toolStripButtonSaveJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveJson.Image = global::CalendarEditor.Properties.Resources.Icons.JSONScript_16x;
            this.toolStripButtonSaveJson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveJson.Name = "toolStripButtonSaveJson";
            this.toolStripButtonSaveJson.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveJson.Text = "Save JSON file";
            this.toolStripButtonSaveJson.Click += new System.EventHandler(this.toolStripButtonSaveJson_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.94481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.05519F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEnd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMessage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMessage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEnd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerStart, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 211);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEnd.CustomFormat = "dddd, d MMMM yyyy, HH:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(98, 168);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(270, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMessage.Location = new System.Drawing.Point(98, 53);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(270, 20);
            this.textBoxMessage.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.Location = new System.Drawing.Point(6, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(81, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tytuł";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMessage.Location = new System.Drawing.Point(6, 52);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(81, 23);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Opis";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStart
            // 
            this.labelStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStart.Location = new System.Drawing.Point(6, 104);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(81, 23);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Data startu";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnd.Location = new System.Drawing.Point(6, 167);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(81, 23);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "Data stopu";
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStart.CustomFormat = "dddd, d MMMM yyyy, HH:mm:ss";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(98, 105);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(270, 20);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitle.Location = new System.Drawing.Point(98, 11);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(270, 20);
            this.textBoxTitle.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CalendarEditor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxMessage;

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;

        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.ToolStripButton toolStripButtonSaveIcs;

        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAll;

        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;

        private System.Windows.Forms.ToolStripButton toolStripButtonNew;

        private System.Windows.Forms.ToolStripButton toolStripButtonSaveJson;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveXml;

        private System.Windows.Forms.ToolStrip toolStrip1;

        #endregion
    }
}