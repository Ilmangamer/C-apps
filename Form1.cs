using System.Data;
using System.Text;
using System.Windows.Forms;




namespace WinCalc
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
       
    
        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)  
        {
            if ((Input_field.Text == "0") || (isOperationPerformed))
                Input_field.Text = null;

            isOperationPerformed = false;
            Button button = (Button)sender;
            Input_field.Text = Input_field.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(Input_field.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;   
            isOperationPerformed = true;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Input_field.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Input_field.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    Input_field.Text = (resultValue + Double.Parse(Input_field.Text)).ToString();
                    break;
                case "-":
                    Input_field.Text = (resultValue - Double.Parse(Input_field.Text)).ToString();
                    break;
                case "x":
                    Input_field.Text = (resultValue * Double.Parse(Input_field.Text)).ToString();
                    break;
                case "�":
                    Input_field.Text = (resultValue / Double.Parse(Input_field.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }           
}
