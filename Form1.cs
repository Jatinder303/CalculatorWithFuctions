using System;
using System.Windows.Forms;

namespace CalculatorWithFuctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Add function to add 2 numbers. This function accept two string type parameters and string type return value
        static String Add(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number + second_number;
            return result.ToString();
        }

        // Sub function to perform subtraction operation. This function accept two string type parameters and string type return value
        static String Sub(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number - second_number;
            return result.ToString();
        }

        // Mult function to perform multiplication operation. This function accept two string type parameters and string type return value
        static String Mult(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number * second_number;
            return result.ToString();
        }

        // Div function to perform Division operation. This function accept two string type parameters and string type return value
        static String Div(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number / second_number;
            return result.ToString();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Add(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Sub(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Mul_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Mult(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Div(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
