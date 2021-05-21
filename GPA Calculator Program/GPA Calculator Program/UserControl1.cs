using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator_Program
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            creditE1.SelectedItem = "0";
            creditE2.SelectedItem = "0";
            creditE3.SelectedItem = "0";
            creditE4.SelectedItem = "0";
            creditE5.SelectedItem = "0";
            creditE6.SelectedItem = "0";
            creditE7.SelectedItem = "0";

            gradeE1.SelectedItem = "F";
            gradeE2.SelectedItem = "F";
            gradeE3.SelectedItem = "F";
            gradeE4.SelectedItem = "F";
            gradeE5.SelectedItem = "F";
            gradeE6.SelectedItem = "F";
            gradeE7.SelectedItem = "F";

        }

        private void creditEntry1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry1_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditEntry2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry2_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditEntry3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry3_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditEntry4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry4_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditEntry5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry5_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditEntry6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry6_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditEntry7_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeEntry7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        double showGPA = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            showGPA = CalGPA();
            gpaText.Text = String.Format("{0:n2}", showGPA);

        }

        double gpa = 0;
        int totalCredit = 0;
        double totalGradePoint = 0;
        internal object userControl;
        bool needCal = false;

        public double CalGPA()
        {

            gpa = 0;
            totalCredit = 0;
            totalGradePoint = 0;
            needCal = false;

            int[] credit = new int[7];
            credit[0] = Convert.ToInt32(creditE1.SelectedItem);
            credit[1] = Convert.ToInt32(creditE2.SelectedItem);
            credit[2] = Convert.ToInt32(creditE3.SelectedItem);
            credit[3] = Convert.ToInt32(creditE4.SelectedItem);
            credit[4] = Convert.ToInt32(creditE5.SelectedItem);
            credit[5] = Convert.ToInt32(creditE6.SelectedItem);
            credit[6] = Convert.ToInt32(creditE7.SelectedItem);

            string[] grade = new string[7];
            grade[0] = gradeE1.SelectedItem.ToString();
            grade[1] = gradeE2.SelectedItem.ToString();
            grade[2] = gradeE3.SelectedItem.ToString();
            grade[3] = gradeE4.SelectedItem.ToString();
            grade[4] = gradeE5.SelectedItem.ToString();
            grade[5] = gradeE6.SelectedItem.ToString();
            grade[6] = gradeE7.SelectedItem.ToString();

            double[] gradePoint = new double[7];
            for (int i = 0; i < 7; i++)
            {

                switch (grade[i])
                {

                    case "A+":
                        gradePoint[i] = 4.3;
                        continue;
                    case "A":
                        gradePoint[i] = 4.0;
                        continue;
                    case "A-":
                        gradePoint[i] = 3.7;
                        continue;
                    case "B+":
                        gradePoint[i] = 3.3;
                        continue;
                    case "B":
                        gradePoint[i] = 3.0;
                        continue;
                    case "B-":
                        gradePoint[i] = 2.7;
                        continue;
                    case "C+":
                        gradePoint[i] = 2.3;
                        continue;
                    case "C":
                        gradePoint[i] = 2.0;
                        continue;
                    case "C-":
                        gradePoint[i] = 1.7;
                        continue;
                    case "D+":
                        gradePoint[i] = 1.3;
                        continue;
                    case "D":
                        gradePoint[i] = 1.0;
                        continue;
                    case "P":
                        gradePoint[i] = 0;
                        credit[i] = 0;
                        continue;
                    default:
                        gradePoint[i] = 0;
                        continue;

                }

            }

            for (int i = 0; i < 7; i++)
            {
                if (checkBox1.Checked){

                    needCal = true;

                }

                if (checkBox2.Checked)
                {

                    needCal = true;

                }

                if (checkBox3.Checked)
                {

                    needCal = true;

                }

                if (checkBox4.Checked)
                {

                    needCal = true;

                }

                if (checkBox5.Checked)
                {

                    needCal = true;

                }

                if (checkBox6.Checked)
                {

                    needCal = true;

                }

                if (checkBox7.Checked)
                {

                    needCal = true;

                }

                if (needCal) {

                    totalCredit += credit[i];
                    totalGradePoint += credit[i] * gradePoint[i];
                    needCal = false;

                }
                
            }

            gpa = totalGradePoint / totalCredit;

            if (totalCredit == 0) {

                gpa = 0;

            }

            return gpa;

        }

        private void gradeE1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
