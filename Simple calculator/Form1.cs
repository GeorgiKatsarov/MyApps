namespace Simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal a = new decimal();
        decimal b = new decimal();
        decimal result =  new decimal();
        char operator1 = '+';
       
        #region TextBox 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region NumberBttns

        private void ZeroBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(0);
            
        }

        private void OneBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(1);
            
        }

        private void TwoBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(2);
            
        }

        private void ThreeBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(3);

        }

        private void FourBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(4);

        }

        private void FiveBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(5);

        }

        private void SixBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(6);

        }

        private void SevenBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(7);

        }

        private void EightBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(8);

        }

        private void NineBttn_Click(object sender, EventArgs e)
        {
            AppendNumber(9);
        }

        #endregion

        #region OperationsBttns
        private void PlusBttn_Click(object sender, EventArgs e)
        {
            CreateA();
            Clear();
            operator1 = '+';
            

        }

        private void DivisionBttn_Click(object sender, EventArgs e)
        {
            CreateA();
            Clear();
            operator1 = '/';



        }

        private void MinusBttn_Click(object sender, EventArgs e)
        {
            CreateA();
            Clear();
            operator1 = '-';


        }

        private void EquelBttn_Click(object sender, EventArgs e)
        {
            CreateB();
            if (b == 0)
            {
                textBox1.Text = "Invalid operation";
            }
            else
            {
                Clear();
                GetResult();
                textBox1.Text = result.ToString();
            }
            

        }

        private void CEBttn_Click(object sender, EventArgs e)
        {
            Clear();
           
        }

        private void DotBttn_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
        private void MultyplicationBttn_Click(object sender, EventArgs e)
        {
            CreateA();
            Clear();
            operator1 = '*';
        }
        #endregion

        #region Helpers
        public void AppendNumber(int a)
        {
            textBox1.Text += a.ToString();
        }
        public void CreateA()
        {
            a = decimal.Parse(textBox1.Text);
        }
        public void CreateB()
        {
            b = decimal.Parse(textBox1.Text);
        }
        public void Clear()
        {
            textBox1.Text = String.Empty;
        }
        public void GetResult()
        {
            if (operator1 == '+')
            {
                result = a + b;
            }
            else if (operator1 == '-')
            {
                result = a - b;
            }
            else if (operator1 == '/')
            {
                
              result = a / b;
            }
            else if (operator1 == '*')
            {
                result = a * b;
            }
        }
        #endregion

        
    }
}