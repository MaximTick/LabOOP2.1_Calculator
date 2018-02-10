using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0.00;
        String operation = "";
        bool operation_pressed = false;
        Calc C;
        int k;
        public Form1()
        {
            InitializeComponent();
            C = new Calc();
            result.Text = "0";

        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if ((result.Text == "0") || (operation_pressed))
                    result.Clear();
                operation_pressed = false;
                Button b = (Button)sender;
                result.Text = result.Text + b.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {        
                result.Text = "0";           
        }

        private void operator_click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                equation.Text = "";
                switch (operation)
                {
                    case "+":
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        break;
                    default: break;
                }//switch
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {           
                result.Text = "0";
                value = 0;           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if ((result.Text == "0") || (operation_pressed))
                    result.Clear();
                operation_pressed = false;
                Button b = (Button)sender;
                // result.Text = result.Text + b.Text;
                double res = Double.Parse(result.Text);
                double sin = Math.Sin(res);
                string sinstr = Convert.ToString(sin);
                result.Text = sinstr;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if ((result.Text == "0") || (operation_pressed))
                    result.Clear();
                operation_pressed = false;
                Button b = (Button)sender;
                double res = Double.Parse(result.Text);
                double cos = Math.Cos(res);
                string cosstr = Convert.ToString(cos);
                result.Text = cosstr;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //КОРЕНЬ
            try
            {
                if ((result.Text == "0") || (operation_pressed))
                    result.Clear();
                operation_pressed = false;
                Button b = (Button)sender;
                double res = Double.Parse(result.Text);
                double sqrt = Math.Sqrt(res);
                string cosstr = Convert.ToString(sqrt);
                result.Text = cosstr;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //кнопка М+
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(result.Text));
        }

        //кнопка М-
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(result.Text));
        }

        //кнопка М*
        private void buttonMMult_Click(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(result.Text));
        }

        //кнопка М/
        private void buttonMDiv_Click(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(result.Text));
        }

        //кнопка МRC
        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    result.Text = C.MemoryShow().ToString();

                if (k == 2)
                {
                    C.Memory_Clear();
                    result.Text = "0";

                    k = 0;
                }
            }
        }

        //проверяет не нажата ли еще какая-либо из кнопок мат.операций
        private bool CanPress()
        {
            if (!button13.Enabled)
                return false;

            if (!button12.Enabled)
                return false;

            if (!button15.Enabled)
                return false;

            if (!button14.Enabled)
                return false;

            if (!button21.Enabled)
                return false;                       

            return true;
        }
    }
}   
