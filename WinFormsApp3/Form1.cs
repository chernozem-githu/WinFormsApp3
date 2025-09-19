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
                double height = (double)numericHeight.Value / 100.0; // ������� �� � �����

                if (height <= 0)
                {
                    MessageBox.Show("���� ������ ���� ������ ����!", "������",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double bmi = weight / (height * height);

                string category;
                if (bmi < 18.5) category = "������������� ���";
                else if (bmi < 25) category = "�����";
                else if (bmi < 30) category = "���������� ���";
                else category = "��������";

                string message = $"��� BMI: {bmi:F2}\n���������: {category}";

                labelResult.Text = message;
                MessageBox.Show(message, "��������� BMI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("������ ����� ������!", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
