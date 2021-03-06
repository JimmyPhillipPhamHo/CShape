﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class ChatterboxDinerDailySpecial : Form
    {
        public ChatterboxDinerDailySpecial()
        {
            InitializeComponent();
        }
        enum Day
        {
            SUNDAY = 1, MONDAY, TUESDAY, WENESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        private void btnGetSpecial_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtDay.Text);
            string special;

            switch ((Day)day)
            {
                case Day.SUNDAY:
                    special = "fried chicken";
                    break;
                case Day.MONDAY:
                    special = "Sorry - closed";
                    break;
                case Day.TUESDAY:
                case Day.WENESDAY:
                case Day.THURSDAY:
                    special = "meat loaf";
                    break;
                case Day.FRIDAY:
                    special = "fish fry";
                    break;
                case Day.SATURDAY:
                    special = "liver and onions";
                    break;
                default:
                    special = "Invalid day";
                    break;
                        
            }
            lblSpecial.Text = "Today's special is " + special;
        }
    }
}
