namespace Pathfinder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.dataGridViewProfessions = new System.Windows.Forms.DataGridView();
            this.dataGridViewSelectedProfSkills = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedProfSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.AllowUserToAddRows = false;
            this.dataGridViewSkills.AllowUserToDeleteRows = false;
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSkills.MultiSelect = false;
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.ReadOnly = true;
            this.dataGridViewSkills.Size = new System.Drawing.Size(274, 476);
            this.dataGridViewSkills.TabIndex = 0;
            // 
            // dataGridViewProfessions
            // 
            this.dataGridViewProfessions.AllowUserToAddRows = false;
            this.dataGridViewProfessions.AllowUserToDeleteRows = false;
            this.dataGridViewProfessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessions.Location = new System.Drawing.Point(699, 12);
            this.dataGridViewProfessions.MultiSelect = false;
            this.dataGridViewProfessions.Name = "dataGridViewProfessions";
            this.dataGridViewProfessions.ReadOnly = true;
            this.dataGridViewProfessions.Size = new System.Drawing.Size(274, 476);
            this.dataGridViewProfessions.TabIndex = 0;
            this.dataGridViewProfessions.DoubleClick += new System.EventHandler(this.dataGridViewProfessions_DoubleClick);
            // 
            // dataGridViewSelectedProfSkills
            // 
            this.dataGridViewSelectedProfSkills.AllowUserToAddRows = false;
            this.dataGridViewSelectedProfSkills.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedProfSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedProfSkills.Location = new System.Drawing.Point(419, 12);
            this.dataGridViewSelectedProfSkills.MultiSelect = false;
            this.dataGridViewSelectedProfSkills.Name = "dataGridViewSelectedProfSkills";
            this.dataGridViewSelectedProfSkills.ReadOnly = true;
            this.dataGridViewSelectedProfSkills.Size = new System.Drawing.Size(274, 476);
            this.dataGridViewSelectedProfSkills.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(292, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 81);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 500);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewSelectedProfSkills);
            this.Controls.Add(this.dataGridViewProfessions);
            this.Controls.Add(this.dataGridViewSkills);
            this.Name = "Form1";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedProfSkills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSkills;
        private System.Windows.Forms.DataGridView dataGridViewProfessions;
        private System.Windows.Forms.DataGridView dataGridViewSelectedProfSkills;
        private System.Windows.Forms.Button buttonSearch;
    }
}

