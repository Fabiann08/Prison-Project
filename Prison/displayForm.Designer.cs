namespace Prison
{
    partial class displayForm
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
            this.prisonDataGridView = new System.Windows.Forms.DataGridView();
            this.closeTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prisonDataGridView
            // 
            this.prisonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prisonDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.prisonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prisonDataGridView.Location = new System.Drawing.Point(12, 60);
            this.prisonDataGridView.Name = "prisonDataGridView";
            this.prisonDataGridView.ReadOnly = true;
            this.prisonDataGridView.RowHeadersWidth = 51;
            this.prisonDataGridView.RowTemplate.Height = 29;
            this.prisonDataGridView.Size = new System.Drawing.Size(1747, 547);
            this.prisonDataGridView.TabIndex = 0;
            this.prisonDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prisonDataGridView_CellContentClick);
            // 
            // closeTableButton
            // 
            this.closeTableButton.Location = new System.Drawing.Point(12, 16);
            this.closeTableButton.Name = "closeTableButton";
            this.closeTableButton.Size = new System.Drawing.Size(94, 29);
            this.closeTableButton.TabIndex = 1;
            this.closeTableButton.Text = "Close table";
            this.closeTableButton.UseVisualStyleBackColor = true;
            this.closeTableButton.Click += new System.EventHandler(this.closeTableButton_Click);
            // 
            // displayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 717);
            this.Controls.Add(this.closeTableButton);
            this.Controls.Add(this.prisonDataGridView);
            this.Name = "displayForm";
            this.Text = "displayForm";
            this.Load += new System.EventHandler(this.displayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prisonDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView prisonDataGridView;
        private Button closeTableButton;
    }
}