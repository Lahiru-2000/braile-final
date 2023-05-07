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
    public partial class squreUC : UserControl
    {
        public squreUC()
        {
            InitializeComponent();
        }

        private void recbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqbutton != null && sqtext1.Text != null)
                {



                    int a = Convert.ToInt32(sqtext1.Text);

                    int c;

                    c = 4 * a;

                    ans.Text = Convert.ToString(c);
                    gbPERI.Text = Convert.ToString("Perimeter of the Squre is ");

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
