
namespace OpenFileDialogControl_Project
{
    partial class frmTitles
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
            this.grdTitles = new System.Windows.Forms.DataGridView();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdTitles)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTitles
            // 
            this.grdTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTitles.Location = new System.Drawing.Point(-1, 0);
            this.grdTitles.Name = "grdTitles";
            this.grdTitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdTitles.Size = new System.Drawing.Size(800, 451);
            this.grdTitles.TabIndex = 0;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "[blank]";
            this.dlgOpen.Filter = "SQL Server Databases (*.mdf)|*.mdf";
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdTitles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titles Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTitles_FormClosing);
            this.Load += new System.EventHandler(this.frmTitles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTitles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTitles;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

