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

        private void listBox4_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionString = @"Data Source=" + sPath + ";New=False;Version=3";
            string selectCommand = "Select * from skill";
            SelectTableSkills(ConnectionString, selectCommand);
        }

        private void SelectTableSkills(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewSkills.DataSource = ds;
            dataGridViewSkills.DataMember = ds.Tables[0].ToString();
            dataGridViewSkills.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSkills.Columns[0].Visible = false;
            connect.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(dataGridViewSkills.CurrentRow != null)
            {
                string selectCommand = $"select p.* from Profession p join skill_profession sp on p.profId = sp.profId where sp.skillid in (select skillId from skill s where s.level <= {dataGridViewSkills.CurrentRow.Cells[2].Value} and name = '{dataGridViewSkills.CurrentRow.Cells[1].Value}')";
                SelectTableProfessions(ConnectionString, selectCommand);
            }
        }

        private void SelectTableProfessions(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewProfessions.DataSource = ds;
            dataGridViewProfessions.DataMember = ds.Tables[0].ToString();
            dataGridViewProfessions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProfessions.Columns[0].Visible = false;
            connect.Close();
        }

        private void dataGridViewProfessions_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProfessions.CurrentRow != null)
            {
                string selectCommand = $"select s.name, s.level from skill_profession sp join Skill s on sp.skillId = s.skillId where sp.profid = {dataGridViewProfessions.CurrentRow.Cells[0].Value}";
                SelectTableSelectedProfSkills(ConnectionString, selectCommand);
            }
        }

        private void SelectTableSelectedProfSkills(string conString, string selectCmd)
        {
            SQLiteConnection connect = new SQLiteConnection(conString);
            connect.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectCmd, connect);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridViewSelectedProfSkills.DataSource = ds;
            dataGridViewSelectedProfSkills.DataMember = ds.Tables[0].ToString();
            dataGridViewSelectedProfSkills.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            connect.Close();
        }
    }
}
