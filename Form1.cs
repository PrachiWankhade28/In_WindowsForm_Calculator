using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_in_windows_forms
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string operationperformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text=="0" || (isoperationperformed))
            {
                textBox_Result.Clear();
            }
            Button button = (Button)sender;
            isoperationperformed = false;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            resultvalue = Double.Parse(textBox_Result.Text);
            labelcurrentoperation.Text = resultvalue + "" + operationperformed;
            isoperationperformed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultvalue = 0;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox_Result.Text = (resultvalue + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;



            }
        }
        	

	}
    }

