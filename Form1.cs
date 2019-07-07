using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSCoopRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sl, sl_max, sl_min;

            try
            {
                sl = int.Parse(textBox1.Text);
                if (sl < 1) sl = 1;
                if (sl > 715) sl = 715;
                textBox1.Text = sl.ToString();

                sl_min = (int)(sl * 0.9 - 10);
                sl_max = (int)(sl * 1.1 + 10);
                
                if (sl_min < 1) sl_min = 1;
                if (sl_max > 715) sl_max = 715;
                textBox2.Text = sl_min.ToString();
                textBox3.Text = sl_max.ToString();
            }
            catch(ArgumentNullException)
            {
                System.Windows.Forms.MessageBox.Show("Non so come ci sei riuscito. Bravo.");
            }
            catch(FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Omae wa mou shindeiru");
            }
            catch(OverflowException)
            {
                System.Windows.Forms.MessageBox.Show("Esagerato");
            }
        }
    }
}
