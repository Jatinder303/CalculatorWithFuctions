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

        static String Add(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number + second_number;
            return result.ToString();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = Add(Txt_FirstNumber.Text, Txt_SecondNumber.Text);
        }
    }
}
