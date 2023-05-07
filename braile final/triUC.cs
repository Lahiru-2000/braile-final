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
    public partial class triUC : UserControl
    {
        public triUC()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel11.Controls.Clear();
            panel11.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            
        }

        private void recbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tributton != null && tritext1.Text != null && tritext2.Text != null && tritext3.Text != null)
                {



                    int a = Convert.ToInt32(tritext1.Text);
                    int b = Convert.ToInt32(tritext2.Text);
                    int d = Convert.ToInt32(tritext3.Text);
                    int c;


                    c = b + a + d;

                    ans.Text = Convert.ToString(c);
                    gbPERI.Text = Convert.ToString("Perimeter of the Triangle is ");

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
                    BrailleLabel.Text = Convert.ToString(brailleNum);


                    panel3.Visible = true;



                }
            }
            catch (Exception)


            {
                panel3.Visible = false;
                MessageBox.Show("Error: Please Enter Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tritext1.Clear();
            tritext2.Clear();
            tritext3.Clear();

            panel3.Hide();
        }
    }
}
