namespace SummaryMaker
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
            this.components = new System.ComponentModel.Container();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.previewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sixItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreItems = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEnd = new System.Windows.Forms.Label();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.PicturesPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.previewMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.PicturesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewBox
            // 
            this.previewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBox.ContextMenuStrip = this.previewMenuStrip;
            this.previewBox.Location = new System.Drawing.Point(403, 25);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(500, 500);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // previewMenuStrip
            // 
            this.previewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.cardsToolStripMenuItem});
            this.previewMenuStrip.Name = "previewMenuStrip";
            this.previewMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneItem,
            this.twoItem,
            this.threeItem,
            this.fourItem,
            this.fiveItem,
            this.sixItem,
            this.moreItems});
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cardsToolStripMenuItem.Text = "Cards";
            // 
            // oneItem
            // 
            this.oneItem.Name = "oneItem";
            this.oneItem.Size = new System.Drawing.Size(152, 22);
            this.oneItem.Text = "1";
            this.oneItem.Click += new System.EventHandler(this.CardSelect);
            // 
            // twoItem
            // 
            this.twoItem.Name = "twoItem";
            this.twoItem.Size = new System.Drawing.Size(152, 22);
            this.twoItem.Text = "2";
            this.twoItem.Click += new System.EventHandler(this.CardSelect);
            // 
            // threeItem
            // 
            this.threeItem.Name = "threeItem";
            this.threeItem.Size = new System.Drawing.Size(152, 22);
            this.threeItem.Text = "3";
            this.threeItem.Click += new System.EventHandler(this.CardSelect);
            // 
            // fourItem
            // 
            this.fourItem.Name = "fourItem";
            this.fourItem.Size = new System.Drawing.Size(152, 22);
            this.fourItem.Text = "4";
            this.fourItem.Click += new System.EventHandler(this.CardSelect);
            // 
            // fiveItem
            // 
            this.fiveItem.Name = "fiveItem";
            this.fiveItem.Size = new System.Drawing.Size(152, 22);
            this.fiveItem.Text = "5";
            this.fiveItem.Click += new System.EventHandler(this.CardSelect);
            // 
            // sixItem
            // 
            this.sixItem.Name = "sixItem";
            this.sixItem.Size = new System.Drawing.Size(152, 22);
            this.sixItem.Text = "6";
            this.sixItem.Click += new System.EventHandler(this.CardSelect);
            // 
            // moreItems
            // 
            this.moreItems.Name = "moreItems";
            this.moreItems.Size = new System.Drawing.Size(152, 22);
            this.moreItems.Text = "Other (not yet)";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(13, 13);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(95, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(177, 11);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Location = new System.Drawing.Point(424, 9);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(45, 13);
            this.previewLabel.TabIndex = 4;
            this.previewLabel.Text = "Preview";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.PicturesPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 489);
            this.tabControl1.TabIndex = 5;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.datePickerEnd);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Controls.Add(this.labelEnd);
            this.mainPage.Controls.Add(this.datePickerStart);
            this.mainPage.Controls.Add(this.startLabel);
            this.mainPage.Controls.Add(this.titleBox);
            this.mainPage.Controls.Add(this.titleLabel);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(368, 463);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(43, 58);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(182, 20);
            this.datePickerEnd.TabIndex = 0;
            // 
            // labelEnd
            // 
            this.labelEnd.Location = new System.Drawing.Point(9, 64);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(35, 13);
            this.labelEnd.TabIndex = 0;
            this.labelEnd.Text = "Ends";
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(43, 32);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(182, 20);
            this.datePickerStart.TabIndex = 0;
            // 
            // startLabel
            // 
            this.startLabel.Location = new System.Drawing.Point(9, 38);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(35, 13);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(43, 6);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(185, 20);
            this.titleBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(9, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // PicturesPage
            // 
            this.PicturesPage.Controls.Add(this.tabControl2);
            this.PicturesPage.Location = new System.Drawing.Point(4, 22);
            this.PicturesPage.Name = "PicturesPage";
            this.PicturesPage.Size = new System.Drawing.Size(368, 463);
            this.PicturesPage.TabIndex = 1;
            this.PicturesPage.Text = "Cards";
            this.PicturesPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(361, 456);
            this.tabControl2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ends";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.previewBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.previewMenuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.PicturesPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.ContextMenuStrip previewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TabPage PicturesPage;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneItem;
        private System.Windows.Forms.ToolStripMenuItem twoItem;
        private System.Windows.Forms.ToolStripMenuItem threeItem;
        private System.Windows.Forms.ToolStripMenuItem fourItem;
        private System.Windows.Forms.ToolStripMenuItem fiveItem;
        private System.Windows.Forms.ToolStripMenuItem sixItem;
        private System.Windows.Forms.ToolStripMenuItem moreItems;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label label1;
    }
}

