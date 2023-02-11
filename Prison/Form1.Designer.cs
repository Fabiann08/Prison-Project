namespace Prison
{
    partial class prisonForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrisonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPrisonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForAPrisonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPrisonerLiatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(682, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPrisonerToolStripMenuItem,
            this.modifyPrisonerToolStripMenuItem,
            this.searchForAPrisonerToolStripMenuItem,
            this.displayPrisonerLiatToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPrisonerToolStripMenuItem
            // 
            this.addPrisonerToolStripMenuItem.Name = "addPrisonerToolStripMenuItem";
            this.addPrisonerToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addPrisonerToolStripMenuItem.Text = "Add prisoner";
            this.addPrisonerToolStripMenuItem.Click += new System.EventHandler(this.addPrisonerToolStripMenuItem_Click);
            // 
            // modifyPrisonerToolStripMenuItem
            // 
            this.modifyPrisonerToolStripMenuItem.Name = "modifyPrisonerToolStripMenuItem";
            this.modifyPrisonerToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.modifyPrisonerToolStripMenuItem.Text = "Modify prisoner";
            this.modifyPrisonerToolStripMenuItem.Click += new System.EventHandler(this.modifyPrisonerToolStripMenuItem_Click);
            // 
            // searchForAPrisonerToolStripMenuItem
            // 
            this.searchForAPrisonerToolStripMenuItem.Name = "searchForAPrisonerToolStripMenuItem";
            this.searchForAPrisonerToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.searchForAPrisonerToolStripMenuItem.Text = "Search for a prisoner";
            this.searchForAPrisonerToolStripMenuItem.Click += new System.EventHandler(this.searchForAPrisonerToolStripMenuItem_Click);
            // 
            // displayPrisonerLiatToolStripMenuItem
            // 
            this.displayPrisonerLiatToolStripMenuItem.Name = "displayPrisonerLiatToolStripMenuItem";
            this.displayPrisonerLiatToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.displayPrisonerLiatToolStripMenuItem.Text = "Display prisoner list";
            this.displayPrisonerLiatToolStripMenuItem.Click += new System.EventHandler(this.displayPrisonerLiatToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.helpContentsToolStripMenuItem.Text = "Help contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.helpContentsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select \"File\" to access the menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select \"Help\" for more information";
            // 
            // prisonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "prisonForm";
            this.Text = "Prison";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addPrisonerToolStripMenuItem;
        private ToolStripMenuItem modifyPrisonerToolStripMenuItem;
        private ToolStripMenuItem searchForAPrisonerToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem displayPrisonerLiatToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpContentsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}