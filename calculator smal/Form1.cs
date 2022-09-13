using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_smal
{
    public partial class calculator : Form
    {
        Int32 x1,x2,sum;
        public calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(txtmumber1.Text);
            x2 = Convert.ToInt32(txtnumber2.Text);
            sum = x1 + x2;
            lblsum.Text = Convert.ToString(sum);
           // Convert.ToInt32();
           // Convert.ToString();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
