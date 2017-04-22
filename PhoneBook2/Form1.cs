using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook2
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection;
        MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        MySqlCommandBuilder mySqlCommandBuilder;
        DataSet ds = new DataSet();
        BindingSource bindingSource;
        int pgSize = 15;
        int curPage;
        bool sort = false;
        bool ascDate = false;

        public Form1()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(
                         "SERVER=localhost;" +
                         "DATABASE=pt2017;" +
                         "UID=root;" +
                         "PASSWORD=;");
            curPage = 1;
            ShowDB(curPage);
        }

        private void ShowDB(int curPage)
        {
            ds.Tables.Clear();
            mySqlConnection.Open();
            int PreviousPageOffSet = (curPage - 1) * pgSize;
            string query;
            if (!sort)
            {
                query = "SELECT * FROM phonebook";
            }
            else
            {
                if (ascDate)
                {
                    query = "SELECT * FROM phonebook ORDER BY date ASC";
                }
                else
                {
                    query = "SELECT * FROM phonebook ORDER BY date DESC";
                }
            }
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds, "allrows");
            mySqlDataAdapter.Fill(ds, PreviousPageOffSet, pgSize, "phonebook");
            bindingSource = new BindingSource();
            bindingSource.DataSource = ds;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.DataMember = "phonebook";
            mySqlConnection.Close();
        }
        
        public void Search()
        {
            mySqlConnection.Open();
            ds.Clear();
            string query = "SELECT * FROM phonebook WHERE name like '%" + txtSearch.Text + "%'";
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds, "search");
            bindingSource = new BindingSource();
            bindingSource.DataSource = ds;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.DataMember = "search";
            mySqlConnection.Close();
        }

        public void Delete()
        {
            mySqlConnection.Open();
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string deleteRow = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

            MySqlCommand cmd = new MySqlCommand(@"
                DELETE FROM phonebook WHERE (phonenumber = '" + deleteRow + "')", mySqlConnection);
            cmd.ExecuteNonQuery();
            mySqlConnection.Close();
            ShowDB(curPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlDataAdapter.Update(ds.Tables[1]);
            //ShowDB((ds.Tables["allrows"].Rows.Count) / pgSize + 1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
            if (txtSearch.TextLength == 0)
            {
                ShowDB(curPage);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curPage++;
            if (curPage >= ((ds.Tables["allrows"].Rows.Count) / pgSize + 1))
            {
                curPage = ((ds.Tables["allrows"].Rows.Count) / pgSize + 1);
            }
            ShowDB(curPage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            curPage--;
            if (curPage <= 0)
            {
                curPage = 1;
            }
            ShowDB(curPage);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!sort)
            {
                sort = true;
            }
            if (ascDate)
                ascDate = false;
            else
                ascDate = true;
            ShowDB(curPage);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            curPage = 1;
            sort = false;
            ascDate = false;
            ShowDB(curPage);
        }

        private void dataGridView1_Paint_1(object sender, PaintEventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 176, 221);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Rows[0].ReadOnly = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 30;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 125;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 100;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 100;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
        }


        private void button4_Paint(object sender, PaintEventArgs e)
        {
            button4.FlatAppearance.BorderSize = 0;
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;
        }

        private void button2_Paint_1(object sender, PaintEventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button1_Paint_1(object sender, PaintEventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            button5.FlatAppearance.BorderSize = 0;
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
        }
    }
}
