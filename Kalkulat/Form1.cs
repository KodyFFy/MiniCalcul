using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulat
{
    public partial class Калькулятор : Form
    {

        public Калькулятор()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So;
                Sk = Convert.ToDouble(textBox1.Text);
                Skw = Convert.ToDouble(textBox2.Text);
                So = Convert.ToDouble(textBox3.Text);
                
                double answer = mat.Math1(Sk, Skw, So);


                textBox7.Text = answer.ToString();
            }
            catch
            {
                textBox7.Text = "Ошибка";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So;
                Sk = Convert.ToDouble(textBox1.Text);
                Skw = Convert.ToDouble(textBox2.Text);
                So = Convert.ToDouble(textBox3.Text);

                double answer = mat.Math1(Sk, Skw, So);


                textBox7.Text = answer.ToString();
            }
            catch
            {
                textBox7.Text = "Ошибка";
            }
    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So;
                Sk = Convert.ToDouble(textBox1.Text);
                Skw = Convert.ToDouble(textBox2.Text);
                So = Convert.ToDouble(textBox3.Text);

                double answer = mat.Math1(Sk, Skw, So);


                textBox7.Text = answer.ToString();
            }
            catch
            {
                textBox7.Text = "Ошибка";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox2.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox2.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox2.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox5.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox5.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox5.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Maths mat = new Maths();
                double Sk, Skw, So, i;
                Sk = Convert.ToDouble(textBox6.Text);
                Skw = Convert.ToDouble(textBox5.Text);
                So = Convert.ToDouble(textBox4.Text);
                i = Convert.ToDouble(textBox9.Text);

                double answer = mat.Math2(Sk, Skw, So, i);


                textBox8.Text = answer.ToString();
            }
            catch
            {
                textBox8.Text = "Ошибка";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Калькулятор_Load(object sender, EventArgs e)
        {

        }
    }
    }
    public class Maths
    {
        public double Math1(double Sk, double Skw, double So)
        {
            double answ = (Sk - Skw) / So;
            return answ;
        }
        public double Math2(double Sk, double Skw, double So, double i)
        {
            double SKi = Math.Pow(Skw, i);
            double answ = (Sk - SKi) / So;
            return answ;
        }

    }
