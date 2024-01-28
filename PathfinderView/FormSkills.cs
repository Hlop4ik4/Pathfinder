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
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            skillStorage.Insert(new SkillViewModel
            {

            })
        }
    }
}
