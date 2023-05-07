using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace braile_final
{
    public partial class rectangleUC : UserControl
    {
        public rectangleUC()
        {
            InitializeComponent();
        }

        private void ans_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void recbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (recbutton != null && rectext1.Text != null && rectext2.Text != null)
                {
                    


                    int a = Convert.ToInt32(rectext1.Text);
                    int b = Convert.ToInt32(rectext2.Text);
                    int c, d;

                    c = (b + a);
                    d = 2 * c;

                    ans.Text = Convert.ToString(d);
                    gbPERI.Text = Convert.ToString("Perimeter of the Rectangle is ");

                    // Input number

                    float num = Convert.ToInt32(ans.Text);

                    // Braille conversion
                    string[] braille = {
                 "⠚", "⠁", "⠃", "⠉", "⠙",  // 0-4
             "⠑", "⠋", "⠛", "⠓", "⠊"   // 5-9
            };

                    string brailleNum = "";
                    foreach (char digit in num.ToString())
                    {
                        int index = int.Parse(digit.ToString());
                        brailleNum += braille[index];
                    }

                    // Output braille number
                    brailtext.Text = Convert.ToString(brailleNum);

                    panel3.Visible = true;
                }
            }

            catch (Exception)


            {
                panel3.Visible = false;
                MessageBox.Show("Error: Please Enter Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
