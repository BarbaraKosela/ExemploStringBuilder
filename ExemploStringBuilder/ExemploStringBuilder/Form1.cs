using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemploBuilder_Click(object sender, EventArgs e)
        {

        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i).Append(" / 2 = ").AppendLine(Convert.ToString(i / 2.0));
            }

            txtResultado.Text = sb.ToString();
        }
    }
}
