namespace Calcolatrice_WinFormsApp
{
    public partial class Calcolatrice : Form
    {
        double firstNumber;
        double secondNumber;
        double result;
        string Operation;
        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox2.Text = firstNumber + "+";
                textBox1.Text = "0";
                Operation = "+";
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox2.Text = firstNumber + "-";
                textBox1.Text = "0";
                Operation = "-";
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void multipl_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox2.Text = firstNumber + "*";
                textBox1.Text = "0";
                Operation = "*";
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox2.Text = firstNumber + "/";
                textBox1.Text = "0";
                Operation = "/";
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void comma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        
        private void negative_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                result = Math.Sqrt(firstNumber);
                string final = Convert.ToString(result);
                textBox2.Text = (char)0x221A + "" + firstNumber + "=" + final;
                textBox1.Text = "0";
                firstNumber = 0;
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pow_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox2.Text = firstNumber + "^";
                textBox1.Text = "0";
                Operation = "^";
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void percentual_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox2.Text = firstNumber + "%";
                textBox1.Text = "0";
                Operation = "%";
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                // Gestione dell'eccezione: visualizza un messaggio di errore e esci dal metodo
                MessageBox.Show("Input non valido. Inserire un numero valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (Operation)
            {
                case "+":
                    result = (firstNumber + secondNumber);
                    string final = Convert.ToString(result);
                    textBox2.Text = $"{firstNumber}+{secondNumber}={final}";
                    textBox1.Text = "0";
                    firstNumber = 0;
                    secondNumber = 0;
                    break;
                case "-":
                    result = (firstNumber - secondNumber);
                    string final2 = Convert.ToString(result);
                    textBox2.Text = $"{firstNumber}-{secondNumber}={final2}";
                    textBox1.Text = "0";
                    firstNumber = 0;
                    secondNumber = 0;
                    break;
                case "*":
                    result = (firstNumber * secondNumber);
                    string final3 = Convert.ToString(result);
                    textBox2.Text = $"{firstNumber}*{secondNumber}={final3}";
                    textBox1.Text = "0";
                    firstNumber = 0;
                    secondNumber = 0;
                    break;
                case "/":
                    try
                    {
                        result = (firstNumber / secondNumber);
                        string final4 = Convert.ToString(result);
                        textBox2.Text = $"{firstNumber}/{secondNumber}={final4}";
                        textBox1.Text = "0";
                        firstNumber = 0;
                        secondNumber = 0;
                    }
                    catch (DivideByZeroException) { }
                    break;
                case "^":
                    result = Math.Pow(firstNumber, secondNumber);
                    string final5 = Convert.ToString(result);
                    textBox2.Text = $"{firstNumber}^{secondNumber}={final5}";
                    textBox1.Text = "0";
                    firstNumber = 0;
                    secondNumber = 0;
                    break;
                case "%":
                    result = (firstNumber / 100) * secondNumber;
                    string final6 = Convert.ToString(result);
                    textBox2.Text = $"({firstNumber}/ 100)*{secondNumber}={final6}";
                    textBox1.Text = "0";
                    firstNumber = 0;
                    secondNumber = 0;
                    break;
            }
        }
    }
}