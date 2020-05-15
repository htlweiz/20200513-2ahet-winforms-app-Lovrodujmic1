using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations
{
    public partial class titel : Form
    {
        public titel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            Int32.TryParse(txt1.Text, out number1);
            Int32.TryParse(txt2.Text, out number2);
            result = number1 + number2;
            LblNumber4.Text = Convert.ToString(result);

            try
            {
                number1 = Convert.ToInt32(txt1.Text);
                number2 = Convert.ToInt32(txt2.Text);
                result = number1 + number2;
                LblNumber4.Text = Convert.ToString(result);
            }
            catch
            {
                LblNumber4.Text = "Fehler";
                MessageBox.Show("Bitte Schreib Sie nur Zahlen ein!","Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Focus();
                txt1.SelectAll();
            }
                }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {

            int number1, number2;
            double result;
            Int32.TryParse(txt1.Text, out number1);
            Int32.TryParse(txt2.Text, out number2);
            result = (double)number1 / number2;
            LblNumber4.Text = Convert.ToString(result);

            try
            {

                number1 = Convert.ToInt32(txt1.Text);
                number2 = Convert.ToInt32(txt2.Text);

                if (number1 == 0 || number2 == 0)
                {
                    LblNumber4.Text = "Fehler";
                    MessageBox.Show("Eingabefehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt1.Focus();
                    txt1.SelectAll();
                }
                else
                {
                    result = Math.Pow(number1, number2);
                    LblNumber4.Text = Convert.ToString(result);
                }
            }
            catch
            {
                LblNumber4.Text = "Fehler";
                MessageBox.Show("Eingabefehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Focus();
                txt1.SelectAll();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            {
                int number1, number2, result;
                Int32.TryParse(txt1.Text, out number1);
                Int32.TryParse(txt2.Text, out number2);
                result = number1 - number2;
                LblNumber4.Text = Convert.ToString(result);

                try
                {
                    number1 = Convert.ToInt32(txt1.Text);
                    number2 = Convert.ToInt32(txt2.Text);
                    result = number1 - number2;
                    LblNumber4.Text = Convert.ToString(result);
                }
                catch
                {
                    LblNumber4.Text = "Fehler";
                    MessageBox.Show("Bitte Schreib Sie nur Zahlen ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt1.Focus();
                    txt1.SelectAll();
                }
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            {
                int number1, number2;
                double result;
                Int32.TryParse(txt1.Text, out number1);
                Int32.TryParse(txt2.Text, out number2);
                result = number1 * number2;
                LblNumber4.Text = Convert.ToString(result);

                try
                {
                    number1 = Convert.ToInt32(txt1.Text);
                    number2 = Convert.ToInt32(txt2.Text);
                    result = number1 * number2;
                    LblNumber4.Text = Convert.ToString(result);
                }
                catch
                {
                    LblNumber4.Text = "Fehler";
                    MessageBox.Show("Eingabefehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt1.Focus();
                    txt1.SelectAll();
                }
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int number1, number2;
            double result;
            Int32.TryParse(txt1.Text, out number1);
            Int32.TryParse(txt2.Text, out number2);
            result = (double) number1 / number2;
            LblNumber4.Text = Convert.ToString(result);

            try
            {
                
                number1 = Convert.ToInt32(txt1.Text);
                number2 = Convert.ToInt32(txt2.Text);
                if (number2 == 0)
                {
                    LblNumber4.Text = "Fehler";
                    MessageBox.Show("Division durch 0!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt1.Focus();
                    txt1.SelectAll();
                }
                else
                {
                    result = (double)number1 / number2;
                    LblNumber4.Text = Convert.ToString(result);

                }
            }
            catch
            {
                LblNumber4.Text = "Fehler";
                MessageBox.Show("Eingabefehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Focus();
                txt1.SelectAll();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            
                int number1, number2;
                double result;
                Int32.TryParse(txt1.Text, out number1);
                Int32.TryParse(txt2.Text, out number2);
                result = (double)number1 / number2;
                LblNumber4.Text = Convert.ToString(result);

                try
                {

                    number1 = Convert.ToInt32(txt1.Text);
                    number2 = Convert.ToInt32(txt2.Text);
                    
                    if (number1==0 || number2==0)
                    {
                        LblNumber4.Text = "Fehler";
                        MessageBox.Show("Eingabefehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt1.Focus();
                        txt1.SelectAll();
                    }
                    else
                    {
                    result = Math.Pow(number1, 1.0 / number2);
                    LblNumber4.Text = Convert.ToString(result);
                    }
                }
                catch
                {
                    LblNumber4.Text = "Fehler";
                    MessageBox.Show("Eingabefehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt1.Focus();
                    txt1.SelectAll();
                }

                



        }
    }
}
