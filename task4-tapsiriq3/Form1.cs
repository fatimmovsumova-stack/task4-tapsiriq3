using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4_tapsiriq3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                int netice = a + b;
                lblResult.Text = "Nəticə: " + netice;
            }
            else
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa düzgün ədəd daxil edin!";
            }
        }

       

        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                int netice = a - b;
                lblResult.Text = "Nəticə: " + netice;
            }
            else
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa düzgün ədəd daxil edin!";
            }
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                int netice = a * b;
                lblResult.Text = "Nəticə: " + netice;
            }
            else
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa düzgün ədəd daxil edin!";
            }
        }
        

        private void btnDivine_Click(object sender, EventArgs e)
        {
if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                // Sıfıra bölmə yoxlanışı
                if (b == 0)
                {
                    lblResult.Text = "Sıfıra bölmək olmaz!";
                }
                else
                {
                    double netice = (double)a / b; 
                    lblResult.Text = "Nəticə: " + netice;
                }
            }
            else
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa düzgün ədəd daxil edin!";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
