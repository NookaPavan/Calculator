using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        int pw;
        bool hided;
        public Form1()
        {
            InitializeComponent();
            pw = hist_text.Width;
            hided = false;
        }
        string[] parts;
        char currentOperator, lastOperator;
        public static string preEquation = "";
        private static bool EndsWithOperator(string str)
        {
            if (str.EndsWith("+") || str.EndsWith("-") || str.EndsWith("*") || str.EndsWith("/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ContainsOperator(string str)
        {
            if (str.Contains("+") || str.Contains("-") || str.Contains("*") || str.Contains("/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Operate(char op)
        {
            if (op != '=')
            {
                currentOperator = op;
            }

            if (ContainsOperator(textBox2.Text))
            {
                if (!EndsWithOperator(textBox2.Text))
                {
                    parts = textBox2.Text.Split("+-*/".ToCharArray());

                    if (textBox2.Text.StartsWith("-"))
                    {
                        parts[0] += "-" + parts[1];
                        for (int i = 1; i < parts.Length - 1; i++)
                        {
                            parts[i] = parts[i + 1];
                        }
                    }

                    switch (lastOperator)
                    {
                        case '+':
                            textBox2.Text = Convert.ToString(Convert.ToDouble(parts[0]) + Convert.ToDouble(parts[1]));
                            break;
                        case '-':
                            textBox2.Text = Convert.ToString(Convert.ToDouble(parts[0]) - Convert.ToDouble(parts[1]));
                            break;
                        case '*':
                            textBox2.Text = Convert.ToString(Convert.ToDouble(parts[0]) * Convert.ToDouble(parts[1]));
                            break;
                        case '/':
                            textBox2.Text = Convert.ToString(Convert.ToDouble(parts[0]) / Convert.ToDouble(parts[1]));
                            break;
                    }

                    if (op != '=')
                    {
                        textBox2.Text += Convert.ToString(currentOperator);
                        lastOperator = currentOperator;
                    }
                    else
                    {
                        currentOperator = lastOperator = '\0';
                    }
                }
                else
                {
                    if (op != '=')
                    {
                        textBox2.Text = textBox2.Text.TrimEnd("+-*/".ToCharArray());
                        if (textBox2.Text.Length != 0)
                        {
                            textBox2.Text += Convert.ToString(currentOperator);
                            lastOperator = currentOperator;
                        }
                    }
                }
            }
            else
            {
                if (op != '=')
                {
                    textBox2.Text += Convert.ToString(currentOperator);
                    lastOperator = currentOperator;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void ALLbttn_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "delbtn":
                    if (textBox2.Text.Length>0)
                    {
                        textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    }
                    break;
                case "clrbtn":
                    
                    textBox2.ResetText();
                    break;
                case "cebtn":
                    textBox1.ResetText();
                    textBox2.ResetText();
                    preEquation = "";
                    break;
                case "dotbtn":
                    String[] number = textBox2.Text.Split("(?=[-+*/()])|(?<=[^-+*/][-+*/])|(?<=[()])".ToCharArray());
                    if (!number[number.Length-1].Contains(".") /*&&  !(EndsWithOperator(textBox2.Text)) && !(textBox2.Text.EndsWith(".")*/)
                    {
                        if (!(textBox2.Text.Contains(".")))
                        {
                            textBox2.Text += ".";
                        }
                        else { }
                    }
                    break;
                case "adminbtn" :
                    if ((textBox2.Text.Length > 0))
                    {
                        if (!(textBox2.Text.Contains("-")))
                        {
                            textBox2.Text = "-" + textBox2.Text;
                        }
                        else if(textBox2.Text.Contains("-"))
                        {
                            textBox2.Text = textBox2.Text.Substring(1, textBox2.Text.Length-1);
                        }
                    }
                    break;
                default:
                    
                    textBox2.Text = textBox2.Text+btn.Text;
                    preEquation = textBox2.Text;
                    break;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            hist_text.ResetText();
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (hided)
            {
                hist_text.Width = hist_text.Width + 66;
                if (hist_text.Width >= pw)
                {
                    timer1.Stop();
                    this.Refresh();
                }
            }
            else
            {
                hist_text.Width = hist_text.Width - 66;
                if (hist_text.Width <= 0)
                {
                    timer1.Stop();
                    this.Refresh();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Operation_click(object sender, EventArgs e)
        {
            Button opr = sender as Button;
            switch (opr.Text)
            {
                case "+":
                    if (textBox2.Text.Length != 0)
                    {
                        Operate('+');
                    }
                    break;
                case "-":
                    if (textBox2.Text.Length != 0)
                    {
                        Operate('-');
                    }
                    break;
                case "/":
                    if (textBox2.Text.Length != 0)
                    {
                        Operate('/');
                    }
                    break;
                case "*":
                    if (textBox2.Text.Length != 0)
                    {
                        Operate('*');
                    }
                    break;
                case "=":
                    if (textBox2.Text.Length != 0)
                    {
                        Operate('=');
                        textBox1.Text = preEquation;
                        hist_text.Text += preEquation + Environment.NewLine + textBox2.Text + Environment.NewLine+ Environment.NewLine;
                    }
                    break; 
        }
            }
        }
        
    }
