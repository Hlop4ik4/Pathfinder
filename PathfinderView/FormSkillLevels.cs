using PathfinderDatabaseImplement.Implements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderView
{
    public partial class FormSkillLevels : Form
    {
        private SkillLevelStorage skillLevelStorage = new SkillLevelStorage();

        public FormSkillLevels()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormSkillLevel();

            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                var form = new FormSkillLevel();
                form.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                form.SkillId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                skillLevelStorage.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormSkillLevels_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var list = skillLevelStorage.GetFullList();

            if(list != null)
            {
                dataGridView1.DataSource = list;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
            }
        }
    }
}
