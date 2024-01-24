using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Pathfinder
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private string sPath = Path.Combine(Application.StartupPath, "mydb.db");
        private string ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from skill";
            SelectTable(ConnectionString, selectCommand, dataGridViewSkills);
        }

        private void SelectTableProfSkills(string conString, string selectCmd, DataGridView dataGridView)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.DataSource = ds;
            dataGridView.DataMember = ds.Tables[0].ToString();
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            connect.Close();
        }

        private void SelectTable(string conString, string selectCmd, DataGridView dataGridView)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.DataSource = ds;
            dataGridView.DataMember = ds.Tables[0].ToString();
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[0].Visible = false;
            connect.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(dataGridViewSkills.CurrentRow != null)
            {
                string selectCommand = $"select p.* from Profession p join skill_profession sp on p.profId = sp.profId where sp.skillid in (select skillId from skill s where s.level <= {dataGridViewSkills.CurrentRow.Cells[2].Value} and name = '{dataGridViewSkills.CurrentRow.Cells[1].Value}')";
                SelectTable(ConnectionString, selectCommand, dataGridViewProfessions);
            }
        }

        private void dataGridViewProfessions_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProfessions.CurrentRow != null)
            {
                string selectCommand = $"select s.name, s.level from skill_profession sp join Skill s on sp.skillId = s.skillId where sp.profid = {dataGridViewProfessions.CurrentRow.Cells[0].Value}";
                SelectTableProfSkills(ConnectionString, selectCommand, dataGridViewSelectedProfSkills);
            }
        }
    }
}
