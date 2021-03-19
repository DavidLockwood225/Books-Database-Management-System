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

namespace OpenFileDialogControl_Project
{
    public partial class frmTitles : Form
    {
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        DataTable titlesTable;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    booksConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;"
                                                  + "AttachDbFilename=" + dlgOpen.FileName
                                                  + ";Integrated Security=True;"
                                                  + "Connect Timeout=30;");
                    titlesCommand = new SqlCommand("SELECT * FROM Titles ORDER BY Title", booksConnection);
                    titlesAdapter = new SqlDataAdapter();
                    titlesAdapter.SelectCommand = titlesCommand;
                    titlesTable = new DataTable();
                    titlesAdapter.Fill(titlesTable);
                    grdTitles.DataSource = titlesTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error establishing Titles table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No file selected", "Program stopping", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }

}
