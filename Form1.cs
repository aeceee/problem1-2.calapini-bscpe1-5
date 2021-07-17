using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem1_2.calapini_bscpe1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "hi!")
            {
                button1.Text = "you did great today. please have a good rest.";
            }

            else if (button1.Text == "you did great today. please have a good rest.")
            {
                button1.Text = "hi!";
            }
        }
    }
}
