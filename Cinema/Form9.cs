using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 1;

            {
                var tb = sender as TextBox;
                if (tb == null) return;
                var actual = tb.Text;
                var disallowed = @"[^1-5]";
                var newText = Regex.Replace(actual, disallowed, string.Empty);
                if (string.CompareOrdinal(tb.Text, newText) != 0)
                {
                    var sstart = tb.SelectionStart;
                    tb.Text = newText;
                    tb.SelectionStart = sstart - 1;
                }
                {



                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 20;

            {
                var tb = sender as TextBox;
                if (tb == null) return;
                var actual = tb.Text;
                var disallowed = @"[^0,1,2,3,4,5,6,7,8,9,10,11,12]";
                var newText = Regex.Replace(actual, disallowed, string.Empty);
                if (string.CompareOrdinal(tb.Text, newText) != 0)
                {
                    var sstart = tb.SelectionStart;
                    tb.Text = newText;
                    tb.SelectionStart = sstart - 1;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }
    }
}
