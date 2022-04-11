using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_a.Text != "" && tb_b.Text != "" && tb_c.Text != "" && tb_h.Text != "") ;
            double a = double.Parse(tb_a.Text);
            double b = double.Parse(tb_b.Text);
            double c = double.Parse(tb_c.Text);
            double h = double.Parse(tb_h.Text);

            double pRectangle = (a + b) * 2;
            tb_pRectangle.Text = pRectangle.ToString();

            double pSquare = a * 4;
            tb_pSquare.Text = pSquare.ToString();

            double pTriagle = a + b + c;
            tb_pTriangle.Text = pTriagle.ToString();

            double pRTriagle = a + b + c;
            tb_pRTriangle.Text = pRTriagle.ToString();

            double pComparator = 2 * a + 2 * b;
            tb_pComparator.Text = pComparator.ToString();

            double pTrapeze = 2 * c + a + b;
            tb_pTrapeze.Text = pTrapeze.ToString();

            double aRectangle = a * b;
            tb_aRectangle.Text = aRectangle.ToString();

            double aSquare = a * a;
            tb_aSquare.Text = aSquare.ToString();

            double aTriagle = (a * h) / 2;
            tb_aTriangle.Text = aTriagle.ToString();

            double aRTriagle = (a * b) / 2;
            tb_aRTriangle.Text = aRTriagle.ToString();

            double aComparator = a * h;
            tb_aComparator.Text = aComparator.ToString();

            double aTrapeze = ((a + b) / 2) * h;
            tb_aTrapeze.Text = aTrapeze.ToString();


        }

        private void tb_pRectangle_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pRectangle.Text);
        }

        private void tb_pSquare_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pSquare.Text);
        }

        private void tb_pTriangle_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pTriangle.Text);
        }

        private void tb_pRTriangle_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pRTriangle.Text);
        }

        private void tb_pComparator_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pComparator.Text);
        }

        private void tb_pTrapeze_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pTrapeze.Text);
        }

        private void tb_aRectangle_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_aRectangle.Text);
        }

        private void tb_aSquare_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_aSquare.Text);
        }

        private void tb_aTriangle_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_aTriangle.Text);
        }

        private void tb_aRTriangle_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_aRTriangle.Text);
        }

        private void tb_aComparator_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_aComparator.Text);
        }

        private void tb_aTrapeze_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tb_aTrapeze.Text);
        }
    }
}
