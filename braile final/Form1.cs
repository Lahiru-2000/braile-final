using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace braile_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void box1Button_Click(object sender, EventArgs e)
        {
            if (box1Button != null && comboBox1.SelectedIndex == 0)
            {
                //cirtext1
                //cirbox

                cir.Visible = true;
                groupBox3.Hide();
               


                tri.Visible = false;
                squ.Visible = false;
                rec.Visible = false;



            }
            else if (box1Button != null && comboBox1.SelectedIndex == 1)
            {
                //tri
                //tribox1, tribox2, tribox3
                //tributton


                tri.Visible = true;
                groupBox3.Hide();

                squ.Visible = false;
                rec.Visible = false;
                cir.Visible = false;


            }
            else if (box1Button != null && comboBox1.SelectedIndex == 2)
            {
                //sqbutton , squtext
                //squre


                squ.Visible = true;
                groupBox3.Hide();

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;


            }
            else if (box1Button != null && comboBox1.SelectedIndex == 3)
            {
                //rectext1 , rectext2 , recbotton , recta



                rec.Visible = true;
                groupBox3.Hide();

                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;

            }

            else if ((letterbox.Text == "a" || letterbox.Text == "A") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("1");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "B" || letterbox.Text == "b") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("2");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }   
            else if ((letterbox.Text == "c" || letterbox.Text == "C") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("3");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "d" || letterbox.Text == "D") && box1Button  != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("4");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "e" || letterbox.Text == "E") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("5");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "f" || letterbox.Text == "F") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("6");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "g" || letterbox.Text == "G") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("7");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "h" || letterbox.Text == "H") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("8");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;

            }
            else if ((letterbox.Text == "i" || letterbox.Text == "I") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("9");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "j" || letterbox.Text == "J") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("10");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "k" || letterbox.Text == "K") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("11");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "l" || letterbox.Text == "L") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("12");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "m" || letterbox.Text == "M") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("13");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;

            }
            else if ((letterbox.Text == "n" || letterbox.Text == "N") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("14");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "o" || letterbox.Text == "O") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("15");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "p" || letterbox.Text == "P") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("16");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "q" || letterbox.Text == "Q") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("17");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "r" || letterbox.Text == "R") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("18");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "s" || letterbox.Text == "S") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("19");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "t" || letterbox.Text == "T") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("20");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "u" || letterbox.Text == "U") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("21");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "v" || letterbox.Text == "V") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("22");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "w" || letterbox.Text == "W") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("23");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "x" || letterbox.Text == "X") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("24");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
            else if ((letterbox.Text == "y" || letterbox.Text == "Y") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("25");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }   
            else if ((letterbox.Text == "z" || letterbox.Text == "Z") && box1Button != null)
            {
                groupBox3.Show();
                letterbox.Clear();

                ans.Text = Convert.ToString("26");

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cirbutton_Click(object sender, EventArgs e)
        {
            //cir , cirbutton , cirtext

            comboBox1.Text = null;

            if (cirbutton != null && cirtext != null)
            {
                groupBox3.Visible = true;
            }

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

        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tributton_Click(object sender, EventArgs e)
        {
            //tri , tributton ,tritext1, tritext2, tritext3

            if (tributton != null && tritext1.Text != null && tritext2.Text != null && tritext3 != null)
            {
                comboBox1.Text = null;

                groupBox3.Visible = true;


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
                brailtext.Text = Convert.ToString(brailleNum);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sqbutton_Click(object sender, EventArgs e)
        {
            //squ, sqbutton, sqtext1

            if (sqbutton != null && sqtext1.Text != null)
            {
                comboBox1.Text = null;

                groupBox3.Visible = true;


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
            }
        }

        private void recbutton_Click(object sender, EventArgs e)
        {
            //rec, rectext1, rectext2, recbutton

            if (recbutton != null && rectext1.Text != null && rectext2.Text != null)
            {
                comboBox1.Text = null;

                groupBox3.Visible = true;


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
            }
        }
    }
}
