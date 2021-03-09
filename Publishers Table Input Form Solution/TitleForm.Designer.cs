
namespace Authors_Table_Input_Form_Project
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.hlpPublishers = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grpFindTitle = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.grpFindTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(142, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(327, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(142, 50);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(57, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year Published";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.White;
            this.txtISBN.Location = new System.Drawing.Point(243, 50);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(226, 20);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.Text = " ";
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(217, 310);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(303, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(131, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(131, 367);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(89, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(380, 367);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(89, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Do&ne";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(142, 195);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(327, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(142, 221);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(327, 20);
            this.txtNotes.TabIndex = 4;
            this.txtNotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.White;
            this.txtSubject.Location = new System.Drawing.Point(142, 247);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(327, 20);
            this.txtSubject.TabIndex = 5;
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(142, 273);
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(327, 20);
            this.txtComments.TabIndex = 6;
            this.txtComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(380, 396);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(89, 23);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(389, 309);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(80, 24);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last >|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(131, 309);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(80, 23);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "|< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // grpFindTitle
            // 
            this.grpFindTitle.Controls.Add(this.btnFind);
            this.grpFindTitle.Controls.Add(this.txtFind);
            this.grpFindTitle.Controls.Add(this.label8);
            this.grpFindTitle.Location = new System.Drawing.Point(1, 310);
            this.grpFindTitle.Name = "grpFindTitle";
            this.grpFindTitle.Size = new System.Drawing.Size(124, 124);
            this.grpFindTitle.TabIndex = 24;
            this.grpFindTitle.TabStop = false;
            this.grpFindTitle.Text = "Find Title";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type first few letters of Title";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(11, 54);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(22, 86);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Publisher";
            // 
            // cboPublisher
            // 
            this.cboPublisher.BackColor = System.Drawing.Color.White;
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(142, 168);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(327, 21);
            this.cboPublisher.TabIndex = 26;
            // 
            // btnPublishers
            // 
            this.btnPublishers.Location = new System.Drawing.Point(251, 396);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(89, 23);
            this.btnPublishers.TabIndex = 27;
            this.btnPublishers.Text = "&Publishers";
            this.btnPublishers.UseVisualStyleBackColor = true;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 446);
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpFindTitle);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpPublishers.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "frmTitles";
            this.hlpPublishers.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTitles_FormClosing);
            this.Load += new System.EventHandler(this.frmTitles_Load);
            this.grpFindTitle.ResumeLayout(false);
            this.grpFindTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.HelpProvider hlpPublishers;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox grpFindTitle;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.Button btnPublishers;
    }
}

