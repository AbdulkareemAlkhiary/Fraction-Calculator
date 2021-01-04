using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_9
{
    public partial class Form1 : Form
    {
        private Button[] button;
        private Fraction[] fractionArray;
        private string line;
        public Form1()
        {
            InitializeComponent();
            button = new Button[16];

            button[0] = button0;
            button[1] = button1;
            button[2] = button2;
            button[3] = button3;
            button[4] = button4;
            button[5] = button5;
            button[6] = button6;
            button[7] = button7;
            button[8] = button8;
            button[9] = button9;
            button[10] = button10;
            button[11] = button11;
            button[12] = button13;
            button[13] = button14;
            button[14] = button15;
            button[15] = button16;

            for (int k = 0; k < button.Length; k++ )
            {
                button[k].Click += new EventHandler(Button_Click);
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            

            if (b.Text.Equals("-") || b.Text.Equals("+") || b.Text.Equals("*") || b.Text.Equals("Div"))
            {
                
                textBox1.Text = "";

                line += " " + b.Text[0] + " ";

            }
            else if (b.Text.Equals("="))
            {
                textBox1.Text = "";

                for (int p = 0; p < 12; p++)
                {
                    button[p].Enabled = false;
                }

                fractionArray = new Fraction[3];

                string[] st = line.Split(' ');
                string first = st[0];
                string op = st[1];
                string second = st[2];

                // Determine if first value is a whole number or fraction
                string[] pieces = first.Split('/');
                if (pieces.Length == 1) // whole number, call one-arg constructor
                    fractionArray[0] = new Fraction(Convert.ToInt32(pieces[0]));
                else                    // fraction, call two-arg constructor
                                        // Split into numeration and denominator and create fraction object
                    fractionArray[0] = new Fraction(Convert.ToInt32(pieces[0]),
                                                        Convert.ToInt32(pieces[1]));

                // Determine if second value is a whole number or fraction
                pieces = second.Split('/');
                if (pieces.Length == 1) // whole number, call one-arg constructor
                    fractionArray[1] = new Fraction(Convert.ToInt32(pieces[0]));
                else                    // fraction, call two-arg constructor
                                        // Split into numeration and denominator and create fraction object
                    fractionArray[1] = new Fraction(Convert.ToInt32(pieces[0]),
                                                        Convert.ToInt32(pieces[1]));

                switch (op)
                {
                    case "+":
                        // 'plus' returns a reduced fraction object
                        fractionArray[2] = fractionArray[0].plus(fractionArray[1]);
                        break;
                    case "-":
                        // 'minus' returns a reduced fraction object
                        fractionArray[2] = fractionArray[0].minus(fractionArray[1]);
                        break;
                    case "*":
                        // 'times' returns a reduced fraction object
                        fractionArray[2] = fractionArray[0].times(fractionArray[1]);
                        break;
                    case "Div":
                        // 'divide' returns a reduced fraction object
                        fractionArray[2] = fractionArray[0].divide(fractionArray[1]);
                        break;
                    default:
                        break;
                } // end switch-case
                textBox1.Text = fractionArray[0] + " " + op + " " + fractionArray[1] + " = " + fractionArray[2];

            }
            else
            {
                textBox1.Text += b.Text;
                line += b.Text;

            }


        }

        private void Operation_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            line = "";
            for (int p = 0; p < 12; p++)
            {
                button[p].Enabled = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            }

        private void button8_Click(object sender, EventArgs e)
        {
           }

        private void button9_Click(object sender, EventArgs e)
        {
           }

        private void button15_Click(object sender, EventArgs e)
        {
           }

        private void button16_Click(object sender, EventArgs e)
        {
           }

        private void button14_Click(object sender, EventArgs e)
        {
            }

        private void button13_Click(object sender, EventArgs e)
        {
            }
    }
}