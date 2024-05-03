using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            stopwatch.Stop();

            if (stopwatch.ElapsedMilliseconds > 2000) 
            {
                EventLog myLog = new EventLog();
                myLog.Source = "Application";
                myLog.WriteEntry("Application initialization time exceeded 2 seconds.", EventLogEntryType.Warning);
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox1.Text += button.Text;
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox1.Text += button.Text;
        }


        private void ResultButton_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;

            try
            {
                object result = new System.Data.DataTable().Compute(expression, null);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OperationButton_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OperationButton_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OperationButton_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OperationButton_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ResultButton_Click(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
