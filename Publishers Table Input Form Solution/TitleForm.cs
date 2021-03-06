/*Name: David Lockwood
 *Date: 1/19/2021
 *Purpose: Build a complete database management system for the books database.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Authors_Table_Input_Form_Project
{
    public partial class frmTitles : Form
    {
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        DataTable titlesTable;
        CurrencyManager titlesManager;
        string myState;
        int myBookmark;
        SqlCommand publishersCommand;
        SqlDataAdapter publishersAdapter;
        DataTable publishersTable;
        ComboBox[] authorsCombo = new ComboBox[4];
        SqlCommand authorsCommand;
        SqlDataAdapter authorsAdapter;
        DataTable[] authorsTable = new DataTable[4];
        SqlCommand ISBNAuthorsCommand;
        SqlDataAdapter ISBNAuthorsAdapter;
        DataTable ISBNAuthorsTable;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            try
            {
                hlpPublishers.HelpNamespace = Application.StartupPath + "\\publishers.chm";
                booksConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;"
                                                  + "AttachDbFilename=" + Path.GetFullPath("SQLBooksDB.mdf")
                                                  + ";Integrated Security=True;"
                                                  + "Connect Timeout=30;");
                booksConnection.Open();
                titlesCommand = new SqlCommand("Select * FROM Titles ORDER BY Title;", booksConnection);
                titlesAdapter = new SqlDataAdapter();
                titlesAdapter.SelectCommand = titlesCommand;
                titlesTable = new DataTable();
                titlesAdapter.Fill(titlesTable);
                txtTitle.DataBindings.Add("Text", titlesTable, "Title");
                txtYear.DataBindings.Add("Text", titlesTable, "Year_Published");
                txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
                txtDescription.DataBindings.Add("Text", titlesTable, "Description");
                txtNotes.DataBindings.Add("Text", titlesTable, "Notes");
                txtSubject.DataBindings.Add("Text", titlesTable, "Subject");
                txtComments.DataBindings.Add("Text", titlesTable, "Comments");
                titlesManager = (CurrencyManager)this.BindingContext[titlesTable];
                publishersCommand = new SqlCommand("Select * from Publishers ORDER BY Name", booksConnection);
                publishersAdapter = new SqlDataAdapter();
                publishersAdapter.SelectCommand = publishersCommand;
                publishersTable = new DataTable();
                publishersAdapter.Fill(publishersTable);
                cboPublisher.DataSource = publishersTable;
                cboPublisher.DisplayMember = "Name";
                cboPublisher.ValueMember = "PubID";
                cboPublisher.DataBindings.Add("SelectedValue", titlesTable, "PubID");
                authorsCombo[0] = cboAuthor1;
                authorsCombo[1] = cboAuthor2;
                authorsCombo[2] = cboAuthor3;
                authorsCombo[3] = cboAuthor4;
                authorsCommand = new SqlCommand("Select * from Authors ORDER BY Author", booksConnection);
                authorsAdapter = new SqlDataAdapter();
                authorsAdapter.SelectCommand = authorsCommand;
                for (int i = 0; i < 4; i++)
                {
                    authorsTable[i] = new DataTable();
                    authorsAdapter.Fill(authorsTable[i]);
                    authorsCombo[i].DataSource = authorsTable[i];
                    authorsCombo[i].DisplayMember = "Author";
                    authorsCombo[i].ValueMember = "Au_ID";
                    authorsCombo[i].SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Publishers table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");
            SetText();
            GetAuthors();
        }
        private void frmTitles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myState.Equals("Edit") || myState.Equals("Add"))
            {
                MessageBox.Show("You must finish the current edit before stopping the application.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    SqlCommandBuilder titlesAdapterCommands = new SqlCommandBuilder(titlesAdapter);
                    titlesAdapter.Update(titlesTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving database to file: \r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                booksConnection.Close();
                booksConnection.Dispose();
                titlesCommand.Dispose();
                titlesAdapter.Dispose();
                titlesTable.Dispose();
                publishersCommand.Dispose();
                publishersAdapter.Dispose();
                publishersTable.Dispose();
            }
            authorsCommand.Dispose();
            authorsAdapter.Dispose();
            authorsTable[0].Dispose();
            authorsTable[1].Dispose();
            authorsTable[2].Dispose();
            authorsTable[3].Dispose();
            ISBNAuthorsCommand.Dispose();
            ISBNAuthorsAdapter.Dispose();
            ISBNAuthorsTable.Dispose();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == 0)
            {
                Console.Beep();
            }
            titlesManager.Position--;
            SetText();
            GetAuthors();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == titlesManager.Count - 1)
            {
                Console.Beep();
            }
            titlesManager.Position++;
            SetText();
            GetAuthors();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            string savedName = txtYear.Text;
            int savedRow;
            try
            {
                titlesManager.EndCurrentEdit();
                SqlCommandBuilder ISBNCommandUpdate = new SqlCommandBuilder(ISBNAuthorsAdapter);
                if (ISBNAuthorsTable.Rows.Count != 0)
                {
                    for(int i = 0; i < ISBNAuthorsTable.Rows.Count; i++)
                    {
                        ISBNAuthorsTable.Rows[i].Delete();
                    }
                    ISBNAuthorsAdapter.Update(ISBNAuthorsTable);
                }
                for (int i = 0; i < 4; i++)
                {
                    if (authorsCombo[i].SelectedIndex != -1)
                    {
                        ISBNAuthorsTable.Rows.Add();
                        ISBNAuthorsTable.Rows[ISBNAuthorsTable.Rows.Count - 1]["ISBN"] = txtISBN.Text;
                        ISBNAuthorsTable.Rows[ISBNAuthorsTable.Rows.Count - 1]["Au_ID"] = authorsCombo[i].SelectedValue;
                    }
                }
                ISBNAuthorsAdapter.Update(ISBNAuthorsTable);
                titlesTable.DefaultView.Sort = "Title";
                savedRow = titlesTable.DefaultView.Find(savedName);
                titlesManager.Position = savedRow;
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(response == DialogResult.No)
            {
                return;
            }
            try
            {
                titlesManager.RemoveAt(titlesManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetAuthors();
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    txtTitle.BackColor = Color.White;
                    txtTitle.ForeColor = Color.Black;
                    txtYear.ReadOnly = true;
                    txtISBN.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtNotes.ReadOnly = true;
                    txtSubject.ReadOnly = true;
                    txtComments.ReadOnly = true;
                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    grpFindTitle.Enabled = true;
                    cboAuthor1.Enabled = false;
                    cboAuthor2.Enabled = false;
                    cboAuthor3.Enabled = false;
                    cboAuthor4.Enabled = false;
                    btnXAuthor1.Enabled = false;
                    btnXAuthor2.Enabled = false;
                    btnXAuthor3.Enabled = false;
                    btnXAuthor4.Enabled = false;
                    txtTitle.Focus();
                    break;
                default:
                    txtTitle.ReadOnly = false;
                    txtYear.ReadOnly = false;
                    txtISBN.ReadOnly = false;
                    if (myState.Equals("Edit"))
                    {
                        txtISBN.BackColor = Color.Red;
                        txtISBN.ForeColor = Color.White;
                        txtISBN.ReadOnly = true;
                        txtISBN.TabStop = false;
                    }
                    else
                    {
                        txtISBN.TabStop = true;
                    }
                    txtDescription.ReadOnly = false;
                    txtNotes.ReadOnly = false;
                    txtSubject.ReadOnly = false;
                    txtComments.ReadOnly = false;
                    btnFirst.Enabled = false;
                    btnLast.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    grpFindTitle.Enabled = false;
                    cboAuthor1.Enabled = true;
                    cboAuthor2.Enabled = true;
                    cboAuthor3.Enabled = true;
                    cboAuthor4.Enabled = true;
                    btnXAuthor1.Enabled = true;
                    btnXAuthor2.Enabled = true;
                    btnXAuthor3.Enabled = true;
                    btnXAuthor4.Enabled = true;
                    txtTitle.Focus();
                    break;
            }
        }
        private void SetText()
        {
            this.Text = "Titles - Record " + (titlesManager.Position + 1).ToString() + " of " + titlesManager.Count.ToString() + " Records";
        }
        private void btnXAuthor_Click(object sender, EventArgs e)
        {

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            cboAuthor1.SelectedIndex = -1;
            cboAuthor2.SelectedIndex = -1;
            cboAuthor3.SelectedIndex = -1;
            cboAuthor4.SelectedIndex = -1;
            try
            {
                myBookmark = titlesManager.Position;
                titlesManager.AddNew();
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            titlesManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                titlesManager.Position = myBookmark;
            }
            SetState("View");
        }
        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            if (txtTitle.Text.Equals(""))
            {
                message = "You must input a Title.\r\n";
                txtTitle.Focus();
                allOK = false;
            }
            int inputYear, currentYear;
            if (!txtYear.Text.Trim().Equals(""))
            {
                inputYear = Convert.ToInt32(txtYear.Text);
                currentYear = DateTime.Now.Year;
                if (inputYear > currentYear || inputYear < currentYear - 150)
                {
                    message += "Year published must be between " + (currentYear - 150).ToString() + " and " + currentYear.ToString() + "\r\n";
                    txtYear.Focus();
                    allOK = false;
                }
            }
            if (txtISBN.Text.Length != 13)
            {
                message += "Incomplete ISBN entry.\r\n";
                txtISBN.Focus();
                allOK = false;
            }
            if (cboPublisher.Text.Equals(""))
            {
                message += "You must select a Publisher.";
                cboPublisher.Focus();
                allOK = false;
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPublishers.HelpNamespace);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
            SetText();
            GetAuthors();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
            SetText();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Equals(" "))
            {
                return;
            }
            int savedRow = titlesManager.Position;
            DataRow[] foundRows;
            titlesTable.DefaultView.Sort = "Title";
            foundRows = titlesTable.Select("Title LIKE '" + txtFind.Text + "*'");
            if (foundRows.Length == 0)
            {
                titlesManager.Position = savedRow;
            }
            else
            {
                titlesManager.Position = titlesTable.DefaultView.Find(foundRows[0]["Title"]);
            }
            SetText();
            GetAuthors();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            frmPublishers pubForm = new frmPublishers();
            string pubSave = cboPublisher.Text;
            pubForm.ShowDialog();
            pubForm.Dispose();
            booksConnection.Close();
            booksConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;"
                                                  + "AttachDbFilename=" + Path.GetFullPath("SQLBooksDB.mdf")
                                                  + ";Integrated Security=True;"
                                                  + "Connect Timeout=30;");
            booksConnection.Open();
            publishersAdapter.SelectCommand = publishersCommand;
            publishersTable = new DataTable();
            publishersAdapter.Fill(publishersTable);
            cboPublisher.DataSource = publishersTable;
            cboPublisher.Text = pubSave;
        }
        private void GetAuthors()
        {
            string SQLStatement = "SELECT Title_Author.* FROM Title_Author WHERE Title_Author.ISBN = '" + txtISBN.Text + "'";
            for (int i = 0; i < 4; i++)
            {
                authorsCombo[i].SelectedIndex = -1;
            }
            ISBNAuthorsCommand = new SqlCommand(SQLStatement, booksConnection);
            ISBNAuthorsAdapter = new SqlDataAdapter();
            ISBNAuthorsAdapter.SelectCommand = ISBNAuthorsCommand;
            ISBNAuthorsTable = new DataTable();
            ISBNAuthorsAdapter.Fill(ISBNAuthorsTable);
            if (ISBNAuthorsTable.Rows.Count == 0)
            {
                return;
            }
            for (int i = 0; i < ISBNAuthorsTable.Rows.Count; i++)
            {
                authorsCombo[i].SelectedValue = ISBNAuthorsTable.Rows[i]["Au_ID"].ToString();
            }
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            frmAuthors authorsForm = new frmAuthors();
            string[] authorsSave = new string[4];
            authorsSave[0] = authorsCombo[0].Text;
            authorsSave[1] = authorsCombo[1].Text;
            authorsSave[2] = authorsCombo[2].Text;
            authorsSave[3] = authorsCombo[3].Text;
            authorsForm.ShowDialog();
            authorsForm.Dispose();
            booksConnection.Close();
            booksConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;"
                                      + "AttachDbFilename=" + Path.GetFullPath("SQLBooksDB.mdf")
                                      + ";Integrated Security=True;"
                                      + "Connect Timeout=30;");
            booksConnection.Open();
            authorsAdapter.SelectCommand = authorsCommand;
            for (int i = 0; i < 4; i++)
            {
                authorsTable[i] = new DataTable();
                authorsAdapter.Fill(authorsTable[i]);
                authorsCombo[i].DataSource = authorsTable[i];
                if (!authorsSave[i].Equals(""))
                {
                    authorsCombo[i].Text = authorsSave[i];
                }
                else
                {
                    authorsCombo[i].SelectedIndex = -1;
                }
            }
        }

        private void cboPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                txtDescription.Focus();
            }
        }
        private void cboAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox whichComboBox = (ComboBox)sender;
            switch (whichComboBox.Name)
            {
                case "cboAuthor1":
                    cboAuthor2.Focus();
                    break;
                case "cboAuthor2":
                    cboAuthor3.Focus();
                    break;
                case "cboAuthor3":
                    cboAuthor4.Focus();
                    break;
                case "cboAuthor4":
                    cboPublisher.Focus();
                    break;
            }
        }
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox whichTextBox = (TextBox)sender;
            if ((int) e.KeyChar == 13)
            {
                switch (whichTextBox.Name)
                {
                    case "txtTitle":
                        txtYear.Focus();
                        break;
                    case "txtYear":
                        if (myState.Equals("Add"))
                        {
                            txtISBN.Focus();
                        }
                        else
                        {
                            cboAuthor1.Focus();
                        }
                        break;
                    case "txtISBN":
                        cboAuthor1.Focus();
                        break;
                    case "txtDescription":
                        txtNotes.Focus();
                        break;
                    case "txtNotes":
                        txtSubject.Focus();
                        break;
                    case "txtSubject":
                        txtComments.Focus();
                        break;
                    case "txtComments":
                        txtTitle.Focus();
                        break;
                }
            }
            if (whichTextBox.Name.Equals("txtYear"))
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int) e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    Console.Beep();
                    e.Handled = true;
                }
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                cboAuthor1.Focus();
            }
        }
    }
}
