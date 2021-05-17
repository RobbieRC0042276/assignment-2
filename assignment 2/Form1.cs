using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads what text is in the force and angle textboxs
                double Height = double.Parse(textBox1.Text);
                double Length = double.Parse(textBox2.Text);
                double Width = double.Parse(textBox3.Text);
                //Inputs the numbers into the equation
                double Volume = Width * Length * Height;
                double SurfaceArea = 2 * (Width * Length + Height * Length + Height * Width);
                //Rewrites the answers into the label 
                label1.Text = "Volume = " + Volume;
                label2.Text = "Surface Area = " + SurfaceArea;
            }
            catch
            {
                //shows an message if an error occurs
                MessageBox.Show("your numbers are wrong, check again");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads what text is in the force and angle textboxs
                double Radius = double.Parse(textBox4.Text);
                //Inputs the numbers into the equation
                double Volume = 4/3 * 3.14159265359 * (Radius * 3);
                double SurfaceArea = 4 * 3.14159265359 * (Radius * 2);
                //Rewrites the answers into the label 
                label3.Text = "Volume = " + Volume;
                label4.Text = "SurfaceArea = " + SurfaceArea;
            }
            catch
            {
                //shows an message if an error occurs
                MessageBox.Show("your numbers are wrong, check again");
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads what text is in the force and angle textboxs
                double Radius = double.Parse(textBox6.Text);
                double Height = double.Parse(textBox5.Text);
                //Inputs the numbers into the equation
                double Volume = Math.PI * (Radius * 2) * Height/3;
                double SurfaceArea = 3.14159265359 * Radius * (Radius + Math.Sqrt ( Height * 2 + Radius * 2));
                //Rewrites the answers into the label 
                label6.Text = "Volume = " + Volume;
                label5.Text = "SurfaceArea = " + SurfaceArea;
            }
            catch
            {
                //shows an message if an error occurs
                MessageBox.Show("your numbers are wrong, check again");
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
