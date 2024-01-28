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
using PathfinderContracts.Models;

namespace PathfinderView
{
    public partial class FormSkillLevel : Form
    {
        public int? Id { private get; set; }
        public int? SkillId { private get; set; }   

        private SkillStorage skillStorage = new SkillStorage();
        private SkillLevelStorage skillLevelStorage = new SkillLevelStorage();

        public FormSkillLevel()
        {
            InitializeComponent();
        }

        private void textBoxLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void FormSkillLevel_Load(object sender, EventArgs e)
        {
            var list = skillStorage.GetFullList();

            if(list != null)
            {
                comboBoxSkill.DisplayMember = "Name";
                comboBoxSkill.ValueMember = "Id";
                comboBoxSkill.DataSource = list;
                comboBoxSkill.SelectedItem = null;

                if (SkillId.HasValue)
                {
                    comboBoxSkill.SelectedValue = SkillId.Value;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            if (Id.HasValue)
            {
                skillLevelStorage.Update(new SkillLevelViewModel
                {
                    Id = this.Id.Value,
                    SkillId = Convert.ToInt32(comboBoxSkill.SelectedValue),
                    Level = Convert.ToInt32(textBoxLevel.Text)
                });
            }
            else
            {
                skillLevelStorage.Insert(new SkillLevelViewModel
                {
                    SkillId = Convert.ToInt32(comboBoxSkill.SelectedValue),
                    Level = Convert.ToInt32(textBoxLevel.Text)
                });
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateForm()
        {
            if(string.IsNullOrEmpty(textBoxLevel.Text) || comboBoxSkill.SelectedValue == null)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
