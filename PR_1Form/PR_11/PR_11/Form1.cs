using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async void CountCalculation()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (String.IsNullOrEmpty(textBox_Name.Text))
            {
                textBox_ResultName.Clear();
                textBox_Result.Clear();
                textBox_ResultIndustryType.Clear();
                errorProvider.SetError(textBox_Name, "Поле не должно быть пустым");
                await Task.Delay(1500); // Задержка в 3 секунды
                errorProvider.SetError(textBox_Name, "");
            }
            if (String.IsNullOrEmpty(textBox_IndustryType.Text))
            {
                textBox_ResultName.Clear();
                textBox_Result.Clear();
                textBox_ResultIndustryType.Clear();
                errorProvider.SetError(textBox_IndustryType, "Поле не должно быть пустым");
                await Task.Delay(1500); // Задержка в 3 секунды
                errorProvider.SetError(textBox_IndustryType, "");
            }
            if (String.IsNullOrEmpty(textBox_Employees.Text))
            {
                textBox_ResultName.Clear();
                textBox_Result.Clear();
                textBox_ResultIndustryType.Clear();
                errorProvider.SetError(textBox_Employees, "Поле не должно быть пустым");
                await Task.Delay(1500); // Задержка в 3 секунды
                errorProvider.SetError(textBox_Employees, "");
            }
            if (String.IsNullOrEmpty(textBox_AddEmployees.Text))
            {
                textBox_ResultName.Clear();
                textBox_Result.Clear();
                textBox_ResultIndustryType.Clear();
                errorProvider.SetError(textBox_AddEmployees, "Поле не должно быть пустым");
                await Task.Delay(1500); // Задержка в 3 секунды
                errorProvider.SetError(textBox_AddEmployees, "");
            }
            else if (Int32.TryParse(textBox_AddEmployees.Text, out int addEmployees))
            {
                if (addEmployees < 0 || addEmployees == 0)
                {
                    textBox_ResultName.Clear();
                    textBox_Result.Clear();
                    textBox_ResultIndustryType.Clear();
                    errorProvider.SetError(textBox_AddEmployees, "Введите положительное число больше нуля");
                    await Task.Delay(1500); // Задержка в 3 секунды
                    errorProvider.SetError(textBox_AddEmployees, "");
                }
                if (Int32.TryParse(textBox_Employees.Text, out int Employees))
                {
                    if (Employees < 0 || Employees == 0)
                    {
                        textBox_ResultName.Clear();
                        textBox_Result.Clear();
                        textBox_ResultIndustryType.Clear();
                        errorProvider.SetError(textBox_Employees, "Введите положительное число больше нуля");
                        await Task.Delay(1500); // Задержка в 3 секунды
                        errorProvider.SetError(textBox_Employees, "");

                    }
                    else
                    {
                        CalculateAdding addingEmployees = new CalculateAdding(Employees, addEmployees);
                        textBox_ResultName.Text = textBox_Name.Text;
                        textBox_ResultIndustryType.Text = textBox_IndustryType.Text;
                        int count = addingEmployees.CalculateCount();
                        textBox_Result.Text = $"{count} сотрудников";
                    }
                }
                else
                {
                    textBox_ResultName.Clear();
                    textBox_Result.Clear();
                    textBox_ResultIndustryType.Clear();
                    errorProvider.SetError(textBox_AddEmployees, "Введите целое число");
                    await Task.Delay(1500); // Задержка в 3 секунды
                    errorProvider.SetError(textBox_AddEmployees, "");
                }
            }
        }
        private void btn_Math1_Click(object sender, EventArgs e)
        {
            CountCalculation();
        }

        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_AddEmployees.Clear();
            textBox_ResultIndustryType.Clear();
            textBox_IndustryType.Clear();
            textBox_Name.Clear();
            textBox_ResultName.Clear();
            textBox_Result.Clear();
            textBox_Employees.Clear();
        }

        private void расчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountCalculation();
        }
        }
    }
