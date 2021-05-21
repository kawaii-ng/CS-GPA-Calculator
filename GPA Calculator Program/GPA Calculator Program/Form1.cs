using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator_Program
{
    public partial class Form1 : Form
    {

        int frontScreen = 1;

        public Form1()
        {
            InitializeComponent();
            userControl31.BringToFront();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
            frontScreen = 1;
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {

            userControl11.BringToFront();
            frontScreen = 2;

        }

        private void predictBtn_Click(object sender, EventArgs e)
        {

            userControl21.BringToFront();
            frontScreen = 3;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        double numGrade = 0;

        private void calBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool isMove = false;
        int x;
        int y;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            isMove = true;
            x = e.X;
            y = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (isMove == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X + 5;
            y = e.Y + 5;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X + 75;
            y = e.Y + 25;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
    }
}
