using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHristova7_1312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_morning.Checked)
            {
                lb_sport.Text = rb_morning.Text;
            }
            else if (rb_afternoon.Checked)
            {
                lb_sport.Text = rb_afternoon.Text;
            }
            else if (rb_night.Checked)
            {
                lb_sport.Text = rb_night.Text;
            }

            double cal = 0;

                double time = Convert.ToDouble(tb_time.Text);
                if (comboBox1.Text == "Плуване")
                {
                    cal = 10 * time;
                    lb_cal.Text = cal.ToString();
                    
                    
                    
                }else if (comboBox1.Text == "Бягане")
                {
                    cal = 8 * time;
                    lb_cal.Text = cal.ToString();
                }else if (comboBox1.Text == "Ходене")
                {
                    cal = 4 * time;
                    lb_cal.Text = cal.ToString();
                }else if (comboBox1.Text == "Колоездене")
                {
                    cal = 12 * time;
                    lb_cal.Text = cal.ToString();
                
            }
        }

        private void lb_cal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
