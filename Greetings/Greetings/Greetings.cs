using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greetings
{
    public partial class Greetings : Form
    {
        public Greetings()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int numGreetings = Convert.ToInt32(txtGreetings.Text);
            int count;
            for (count = 0; count < numGreetings; ++count)
                lblResult.Text += "Hello\n";
        }

        

        
    }
}
