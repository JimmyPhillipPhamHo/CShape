using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_3
{
    public partial class HelloVisualWorld : Form
    {
        public HelloVisualWorld()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Visible = true;
            btnClickMeLast.Enabled = true;
        }

        private void btnClickMeLast_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Goodbye";
        }
    }
}
