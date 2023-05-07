using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace braile_final
{
    public partial class cirUC : UserControl
    {
        public cirUC()
        {
            InitializeComponent();
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            select se = new select();
            
         }

        private void recbutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (cirbutton != null && cirtext != null)
                {


                    int a = Convert.ToInt32(cirtext.Text);
                    gbPERI.Text = Convert.ToString("Perimeter of the Circle is ");

                    int c, b;

                    c = 2 * 3;
                    b = c * a;

                    ans.Text = Convert.ToString(b);


                    // Input number

                    int num = Convert.ToInt32(ans.Text);

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
                MessageBox.Show("Error: Please Enter Radius", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
