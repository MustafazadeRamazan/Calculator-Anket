using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double calculator(string first,string second,string @operator)
        {
            if(@operator == "+")
            {             
                return double.Parse(first) + double.Parse(second);
            }

            else if(@operator == "-")
            {
                return double.Parse(first) - double.Parse(second);
            }

            else if (@operator == "X")
            {
                return double.Parse(first) * double.Parse(second);
            }

            else if (@operator == "/")
            {
                if (double.Parse(second) == 0)
                {
                    MessageBox.Show("Zero divison error!");
                    return 0;
                }
                return double.Parse(first) / double.Parse(second);
            }

            return 0;
        }
        static string first = "", second = "", @operator = "";
        private void btn_numb_Click(object sender, EventArgs e)
        {
            
            if (sender is Button)
            {
                Button btn = (Button)sender;

                if (btn.Text == "0" || btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5" || btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9")
                {
                    if (label_result.Text == "0"|| label_result.Text == "+" || label_result.Text == "-" || label_result.Text == "X" || label_result.Text == "/") { label_result.Text = btn.Text; }
                    else
                    {
                        label_result.Text += btn.Text;
                    }
                }

                else if (btn.Text == "+" || btn.Text == "-" || btn.Text == "X" || btn.Text == "/") { 
                    if(label_result.Text == "+"||label_result.Text=="-" || label_result.Text=="X" || label_result.Text=="/") {
                        label_result.Text = btn.Text;
                        @operator = btn.Text;
                    }
                    else
                    {
                        first = label_result.Text;
                        @operator = btn.Text;
                        label_result.Text=btn.Text;
                    }
                }

                else if (btn.Text == "=")
                {
                    if (first != "" && @operator != "")
                    {
                        second = label_result.Text;
                        label_result.Text= calculator(first, second, @operator).ToString();
                    }
                    else
                    {
                        label_result.Text = calculator(first, second, @operator).ToString();
                        first = "";
                        @operator = "";
                    }
                }

                else if(btn.Text == "+/-")
                {
                    if(label_result.Text !="0"|| label_result.Text != "+" || label_result.Text != "-" || label_result.Text != "*" || label_result.Text != "/")
                    {
                        label_result.Text = (double.Parse(label_result.Text) * -1).ToString();
                    }
                }

                else if (btn.Text == ".")
                {
                    if (label_result.Text.Split('.').Length == 1)
                    {
                        label_result.Text += ",";
                    }
                }

                else if (btn.Text == "C" || btn.Text == "CE")
                {
                    label_result.Text = "0";
                    first = "";
                    second = "";
                    @operator = "";
                }

                else if (btn.Text == "<<")
                {
                    if (label_result.Text.Length == 1)
                    {
                        label_result.Text = "0";
                    }

                    else
                    {
                        label_result.Text = label_result.Text.Remove(label_result.Text.Length - 1);
                    }
                }
            }
        }

    }
}
