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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

            creditE1.SelectedItem = "0";
            creditE2.SelectedItem = "0";
            creditE3.SelectedItem = "0";
            creditE4.SelectedItem = "0";
            creditE5.SelectedItem = "0";
            creditE6.SelectedItem = "0";
            creditE7.SelectedItem = "0";

            lowGradeE1.SelectedItem = "F";
            lowGradeE2.SelectedItem = "F";
            lowGradeE3.SelectedItem = "F";
            lowGradeE4.SelectedItem = "F";
            lowGradeE5.SelectedItem = "F";
            lowGradeE6.SelectedItem = "F";
            lowGradeE7.SelectedItem = "F";

            highGradeE1.SelectedItem = "A+";
            highGradeE2.SelectedItem = "A+";
            highGradeE3.SelectedItem = "A+";
            highGradeE4.SelectedItem = "A+";
            highGradeE5.SelectedItem = "A+";
            highGradeE6.SelectedItem = "A+";
            highGradeE7.SelectedItem = "A+";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }


        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        double showGPA1 = 0;
        double showGPA2 = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            showGPA1 = CalGPA1();
            lowGpaText.Text = String.Format("{0:n2}", showGPA1);

            showGPA2 = CalGPA2();
            highGpaText.Text = String.Format("{0:n2}", showGPA2);

        }

        double gpa1 = 0;
        int totalCredit1 = 0;
        double totalGradePoint1 = 0;

        double gpa2 = 0;
        int totalCredit2 = 0;
        double totalGradePoint2 = 0;

        bool needCal1 = false;
        bool needCal2 = false;

        public double CalGPA1()
        {

            gpa1 = 0;
            totalCredit1 = 0;
            totalGradePoint1 = 0;
            needCal1 = false;

            int[] credit1 = new int[7];
            credit1[0] = Convert.ToInt32(creditE1.SelectedItem);
            credit1[1] = Convert.ToInt32(creditE2.SelectedItem);
            credit1[2] = Convert.ToInt32(creditE3.SelectedItem);
            credit1[3] = Convert.ToInt32(creditE4.SelectedItem);
            credit1[4] = Convert.ToInt32(creditE5.SelectedItem);
            credit1[5] = Convert.ToInt32(creditE6.SelectedItem);
            credit1[6] = Convert.ToInt32(creditE7.SelectedItem);

            string[] lowGrade = new string[7];
            lowGrade[0] = lowGradeE1.SelectedItem.ToString();
            lowGrade[1] = lowGradeE2.SelectedItem.ToString();
            lowGrade[2] = lowGradeE3.SelectedItem.ToString();
            lowGrade[3] = lowGradeE4.SelectedItem.ToString();
            lowGrade[4] = lowGradeE5.SelectedItem.ToString();
            lowGrade[5] = lowGradeE6.SelectedItem.ToString();
            lowGrade[6] = lowGradeE7.SelectedItem.ToString();


            double[] gradePoint1 = new double[7];
            for (int i = 0; i < 7; i++)
            {

                switch (lowGrade[i])
                {

                    case "A+":
                        gradePoint1[i] = 4.3;
                        continue;
                    case "A":
                        gradePoint1[i] = 4.0;
                        continue;
                    case "A-":
                        gradePoint1[i] = 3.7;
                        continue;
                    case "B+":
                        gradePoint1[i] = 3.3;
                        continue;
                    case "B":
                        gradePoint1[i] = 3.0;
                        continue;
                    case "B-":
                        gradePoint1[i] = 2.7;
                        continue;
                    case "C+":
                        gradePoint1[i] = 2.3;
                        continue;
                    case "C":
                        gradePoint1[i] = 2.0;
                        continue;
                    case "C-":
                        gradePoint1[i] = 1.7;
                        continue;
                    case "D+":
                        gradePoint1[i] = 1.3;
                        continue;
                    case "D":
                        gradePoint1[i] = 1.0;
                        continue;
                    case "P":
                        gradePoint1[i] = 0;
                        credit1[i] = 0;
                        continue;
                    default:
                        gradePoint1[i] = 0;
                        continue;

                }

            }

            for (int i = 0; i < 7; i++)
            {
                if (checkBox1.Checked)
                {

                    needCal1 = true;

                }

                if (checkBox2.Checked)
                {

                    needCal1 = true;

                }

                if (checkBox3.Checked)
                {

                    needCal1 = true;

                }

                if (checkBox4.Checked)
                {

                    needCal1 = true;

                }

                if (checkBox5.Checked)
                {

                    needCal1 = true;

                }

                if (checkBox6.Checked)
                {

                    needCal1 = true;

                }

                if (checkBox7.Checked)
                {

                    needCal1 = true;

                }

                if (needCal1)
                {
                    
                    totalCredit1 += credit1[i];
                    totalGradePoint1 += credit1[i] * gradePoint1[i];
                    needCal1 = false;

                }

            }

            gpa1 = totalGradePoint1 / totalCredit1;

            if (totalCredit1 == 0)
            {

                gpa1 = 0;

            }

            return gpa1;

        }

        public double CalGPA2()
        {

            gpa2 = 0;
            totalCredit2 = 0;
            totalGradePoint2 = 0;
            needCal2 = false;

            int[] credit2 = new int[7];
            credit2[0] = Convert.ToInt32(creditE1.SelectedItem);
            credit2[1] = Convert.ToInt32(creditE2.SelectedItem);
            credit2[2] = Convert.ToInt32(creditE3.SelectedItem);
            credit2[3] = Convert.ToInt32(creditE4.SelectedItem);
            credit2[4] = Convert.ToInt32(creditE5.SelectedItem);
            credit2[5] = Convert.ToInt32(creditE6.SelectedItem);
            credit2[6] = Convert.ToInt32(creditE7.SelectedItem);

            string[] highGrade = new string[7];
            highGrade[0] = highGradeE1.SelectedItem.ToString();
            highGrade[1] = highGradeE2.SelectedItem.ToString();
            highGrade[2] = highGradeE3.SelectedItem.ToString();
            highGrade[3] = highGradeE4.SelectedItem.ToString();
            highGrade[4] = highGradeE5.SelectedItem.ToString();
            highGrade[5] = highGradeE6.SelectedItem.ToString();
            highGrade[6] = highGradeE7.SelectedItem.ToString();

            double[] gradePoint2 = new double[7];
            for (int i = 0; i < 7; i++)
            {

                switch (highGrade[i])
                {

                    case "A+":
                        gradePoint2[i] = 4.3;
                        continue;
                    case "A":
                        gradePoint2[i] = 4.0;
                        continue;
                    case "A-":
                        gradePoint2[i] = 3.7;
                        continue;
                    case "B+":
                        gradePoint2[i] = 3.3;
                        continue;
                    case "B":
                        gradePoint2[i] = 3.0;
                        continue;
                    case "B-":
                        gradePoint2[i] = 2.7;
                        continue;
                    case "C+":
                        gradePoint2[i] = 2.3;
                        continue;
                    case "C":
                        gradePoint2[i] = 2.0;
                        continue;
                    case "C-":
                        gradePoint2[i] = 1.7;
                        continue;
                    case "D+":
                        gradePoint2[i] = 1.3;
                        continue;
                    case "D":
                        gradePoint2[i] = 1.0;
                        continue;
                    case "P":
                        gradePoint2[i] = 0;
                        credit2[i] = 0;
                        continue;
                    default:
                        gradePoint2[i] = 0;
                        continue;

                }

            }

            for (int i = 0; i < 7; i++)
            {
                if (checkBox1.Checked)
                {

                    needCal2 = true;

                }

                if (checkBox2.Checked)
                {

                    needCal2 = true;

                }

                if (checkBox3.Checked)
                {

                    needCal2 = true;

                }

                if (checkBox4.Checked)
                {

                    needCal2 = true;

                }

                if (checkBox5.Checked)
                {

                    needCal2 = true;

                }

                if (checkBox6.Checked)
                {

                    needCal2 = true;

                }

                if (checkBox7.Checked)
                {

                    needCal2 = true;

                }

                if (needCal2)
                {

                    totalCredit2 += credit2[i];
                    totalGradePoint2 += credit2[i] * gradePoint2[i];
                    needCal2 = false;

                }

            }

            gpa2 = totalGradePoint2 / totalCredit2;

            if (totalCredit2 == 0)
            {

                gpa2 = 0;

            }

            return gpa2;

        }

    }
}
