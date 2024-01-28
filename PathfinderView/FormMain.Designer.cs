namespace PathfinderView
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спраочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmplyeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillLevelsНавыковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(154, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спраочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спраочникиToolStripMenuItem
            // 
            this.спраочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkillsToolStripMenuItem,
            this.EmplyeesToolStripMenuItem,
            this.ProfessionsToolStripMenuItem,
            this.SkillLevelsНавыковToolStripMenuItem});
            this.спраочникиToolStripMenuItem.Name = "спраочникиToolStripMenuItem";
            this.спраочникиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.спраочникиToolStripMenuItem.Text = "Спраочники";
            // 
            // SkillsToolStripMenuItem
            // 
            this.SkillsToolStripMenuItem.Name = "SkillsToolStripMenuItem";
            this.SkillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SkillsToolStripMenuItem.Text = "Навыки";
            this.SkillsToolStripMenuItem.Click += new System.EventHandler(this.SkillsToolStripMenuItem_Click);
            // 
            // EmplyeesToolStripMenuItem
            // 
            this.EmplyeesToolStripMenuItem.Name = "EmplyeesToolStripMenuItem";
            this.EmplyeesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmplyeesToolStripMenuItem.Text = "Сотрудники";
            // 
            // ProfessionsToolStripMenuItem
            // 
            this.ProfessionsToolStripMenuItem.Name = "ProfessionsToolStripMenuItem";
            this.ProfessionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProfessionsToolStripMenuItem.Text = "Профессии";
            // 
            // SkillLevelsНавыковToolStripMenuItem
            // 
            this.SkillLevelsНавыковToolStripMenuItem.Name = "SkillLevelsНавыковToolStripMenuItem";
            this.SkillLevelsНавыковToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SkillLevelsНавыковToolStripMenuItem.Text = "Уровни навыков";
            this.SkillLevelsНавыковToolStripMenuItem.Click += new System.EventHandler(this.SkillLevelsНавыковToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спраочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmplyeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillLevelsНавыковToolStripMenuItem;
    }
}