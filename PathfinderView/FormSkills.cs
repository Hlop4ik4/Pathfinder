using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PathfinderDatabaseImplement.Implements;
using PathfinderContracts.Models;

namespace PathfinderView
{
    public partial class FormSkills : Form
    {
        private SkillStorage skillStorage = new SkillStorage();

        public FormSkills()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            skillStorage.Insert(new SkillViewModel
            {
                Name = textBoxName.Text
            });

            LoadData();
        }

        private void FormSkills_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var list = skillStorage.GetFullList();

            if(list != null)
            {
                dataGridView1.DataSource = list;

                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                if (!ValidateForm())
                {
                    return;
                }

                skillStorage.Update(new SkillViewModel
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    Name = textBoxName.Text
                });

                LoadData();
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
                skillStorage.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
