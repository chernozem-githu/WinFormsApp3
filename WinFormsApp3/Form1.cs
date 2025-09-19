using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = (double)numericWeight.Value;
                double height = (double)numericHeight.Value / 100.0; // перевод см в метры

                if (height <= 0)
                {
                    MessageBox.Show("Рост должен быть больше нуля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double bmi = weight / (height * height);

                string category;
                if (bmi < 18.5) category = "Недостаточный вес";
                else if (bmi < 25) category = "Норма";
                else if (bmi < 30) category = "Избыточный вес";
                else category = "Ожирение";

                string message = $"Ваш BMI: {bmi:F2}\nКатегория: {category}";

                labelResult.Text = message;
                MessageBox.Show(message, "Результат BMI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
