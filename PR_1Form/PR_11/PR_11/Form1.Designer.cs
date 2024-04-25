namespace PR_11
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
            this.components = new System.ComponentModel.Container();
            this.btn_Close1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ResultIndustryType = new System.Windows.Forms.TextBox();
            this.textBox_ResultName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Math1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Data1 = new System.Windows.Forms.GroupBox();
            this.textBox_Calculate = new System.Windows.Forms.TextBox();
            this.textBox_Employees = new System.Windows.Forms.TextBox();
            this.textBox_AddEmployees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddEmployees = new System.Windows.Forms.Label();
            this.textBox_IndustryType = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.IndustryType = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Data1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close1
            // 
            this.btn_Close1.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Close1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Close1.Location = new System.Drawing.Point(522, 403);
            this.btn_Close1.Name = "btn_Close1";
            this.btn_Close1.Size = new System.Drawing.Size(111, 60);
            this.btn_Close1.TabIndex = 6;
            this.btn_Close1.Text = "Выход";
            this.btn_Close1.UseVisualStyleBackColor = false;
            this.btn_Close1.Click += new System.EventHandler(this.btn_Close1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox_Result);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_ResultIndustryType);
            this.groupBox3.Controls.Add(this.textBox_ResultName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(346, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 237);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выходные данные:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(69, 148);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(180, 20);
            this.textBox_Result.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Кол-во сотрудников после изменения:";
            // 
            // textBox_ResultIndustryType
            // 
            this.textBox_ResultIndustryType.Location = new System.Drawing.Point(69, 91);
            this.textBox_ResultIndustryType.Name = "textBox_ResultIndustryType";
            this.textBox_ResultIndustryType.ReadOnly = true;
            this.textBox_ResultIndustryType.Size = new System.Drawing.Size(180, 20);
            this.textBox_ResultIndustryType.TabIndex = 1;
            // 
            // textBox_ResultName
            // 
            this.textBox_ResultName.Location = new System.Drawing.Point(69, 36);
            this.textBox_ResultName.Name = "textBox_ResultName";
            this.textBox_ResultName.ReadOnly = true;
            this.textBox_ResultName.Size = new System.Drawing.Size(180, 20);
            this.textBox_ResultName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Отрасль промышленности:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Название промышленной организации: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Page1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 518);
            this.tabControl1.TabIndex = 7;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.btn_Close1);
            this.Page1.Controls.Add(this.textBox1);
            this.Page1.Controls.Add(this.groupBox3);
            this.Page1.Controls.Add(this.btn_Math1);
            this.Page1.Controls.Add(this.groupBox1);
            this.Page1.Controls.Add(this.groupBox_Data1);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(688, 492);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Расчеты";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Math1
            // 
            this.btn_Math1.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Math1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Math1.Location = new System.Drawing.Point(26, 403);
            this.btn_Math1.Name = "btn_Math1";
            this.btn_Math1.Size = new System.Drawing.Size(111, 60);
            this.btn_Math1.TabIndex = 2;
            this.btn_Math1.Text = "Добавить";
            this.btn_Math1.UseVisualStyleBackColor = false;
            this.btn_Math1.Click += new System.EventHandler(this.btn_Math1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте, данная программа прибавляет сотрудников в\r\n промышленной организаци" +
    "и";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Data1
            // 
            this.groupBox_Data1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Data1.Controls.Add(this.textBox_Calculate);
            this.groupBox_Data1.Controls.Add(this.textBox_Employees);
            this.groupBox_Data1.Controls.Add(this.textBox_AddEmployees);
            this.groupBox_Data1.Controls.Add(this.label3);
            this.groupBox_Data1.Controls.Add(this.AddEmployees);
            this.groupBox_Data1.Controls.Add(this.textBox_IndustryType);
            this.groupBox_Data1.Controls.Add(this.textBox_Name);
            this.groupBox_Data1.Controls.Add(this.IndustryType);
            this.groupBox_Data1.Controls.Add(this.Name);
            this.groupBox_Data1.Location = new System.Drawing.Point(6, 150);
            this.groupBox_Data1.Name = "groupBox_Data1";
            this.groupBox_Data1.Size = new System.Drawing.Size(328, 237);
            this.groupBox_Data1.TabIndex = 1;
            this.groupBox_Data1.TabStop = false;
            this.groupBox_Data1.Text = "Исходные данные:";
            // 
            // textBox_Calculate
            // 
            this.textBox_Calculate.Location = new System.Drawing.Point(69, 198);
            this.textBox_Calculate.Name = "textBox_Calculate";
            this.textBox_Calculate.Size = new System.Drawing.Size(0, 20);
            this.textBox_Calculate.TabIndex = 2;
            // 
            // textBox_Employees
            // 
            this.textBox_Employees.Location = new System.Drawing.Point(69, 127);
            this.textBox_Employees.Name = "textBox_Employees";
            this.textBox_Employees.Size = new System.Drawing.Size(180, 20);
            this.textBox_Employees.TabIndex = 1;
            // 
            // textBox_AddEmployees
            // 
            this.textBox_AddEmployees.Location = new System.Drawing.Point(69, 173);
            this.textBox_AddEmployees.Name = "textBox_AddEmployees";
            this.textBox_AddEmployees.Size = new System.Drawing.Size(180, 20);
            this.textBox_AddEmployees.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите кол-во сотрудников:";
            // 
            // AddEmployees
            // 
            this.AddEmployees.AutoSize = true;
            this.AddEmployees.Location = new System.Drawing.Point(6, 153);
            this.AddEmployees.Name = "AddEmployees";
            this.AddEmployees.Size = new System.Drawing.Size(290, 13);
            this.AddEmployees.TabIndex = 0;
            this.AddEmployees.Text = "Введите кол-во сотрудников которых нужно прибавить:";
            // 
            // textBox_IndustryType
            // 
            this.textBox_IndustryType.Location = new System.Drawing.Point(69, 84);
            this.textBox_IndustryType.Name = "textBox_IndustryType";
            this.textBox_IndustryType.Size = new System.Drawing.Size(180, 20);
            this.textBox_IndustryType.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(69, 36);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(180, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // IndustryType
            // 
            this.IndustryType.AutoSize = true;
            this.IndustryType.Location = new System.Drawing.Point(6, 64);
            this.IndustryType.Name = "IndustryType";
            this.IndustryType.Size = new System.Drawing.Size(188, 13);
            this.IndustryType.TabIndex = 0;
            this.IndustryType.Text = "Введите отрасль промышленности:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(255, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Введите название промышленной организации: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.выполнитьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчётToolStripMenuItem});
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выполнитьToolStripMenuItem.Text = "Выполнить";
            // 
            // расчётToolStripMenuItem
            // 
            this.расчётToolStripMenuItem.Name = "расчётToolStripMenuItem";
            this.расчётToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.расчётToolStripMenuItem.Text = "Расчёт";
            this.расчётToolStripMenuItem.Click += new System.EventHandler(this.расчётToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // мToolStripMenuItem
            // 
            this.мToolStripMenuItem.Name = "мToolStripMenuItem";
            this.мToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.мToolStripMenuItem.Text = "О программе";
            this.мToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(718, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Промышленная организация";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Data1.ResumeLayout(false);
            this.groupBox_Data1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ResultIndustryType;
        private System.Windows.Forms.TextBox textBox_ResultName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Math1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Data1;
        private System.Windows.Forms.TextBox textBox_Calculate;
        private System.Windows.Forms.TextBox textBox_AddEmployees;
        private System.Windows.Forms.Label AddEmployees;
        private System.Windows.Forms.TextBox textBox_IndustryType;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label IndustryType;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Employees;
        private System.Windows.Forms.Label label3;
    }
}

