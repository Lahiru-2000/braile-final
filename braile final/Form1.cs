using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            string userInput = inputTextBox.Text;


            if (countButton != null && comboBox1.SelectedIndex == 0)
            {
                //cirtext1
                //cirbox

                cir.Visible = true;
                groupBox3.Hide();
                Braile_addUC.Hide();


                tri.Visible = false;
                squ.Visible = false;
                rec.Visible = false;



            }
            else if (countButton != null && comboBox1.SelectedIndex == 1)
            {
                //tri
                //tribox1, tribox2, tribox3
                //tributton


                tri.Visible = true;
                groupBox3.Hide();
                Braile_addUC.Hide();

                squ.Visible = false;
                rec.Visible = false;
                cir.Visible = false;


            }
            
            else if (countButton != null && comboBox1.SelectedIndex == 2)
            {
                //sqbutton , squtext
                //squre


                squ.Visible = true;
                groupBox3.Hide();
                Braile_addUC.Hide();

                rec.Visible = false;
                cir.Visible = false;
                tri.Visible = false;


            }
            else if (countButton != null && comboBox1.SelectedIndex == 3)
            {
                //rectext1 , rectext2 , recbotton , recta



                rec.Visible = true;
                groupBox3.Hide();
                Braile_addUC.Hide();

                cir.Visible = false;
                tri.Visible = false;
                squ.Visible = false;

            }



            
            else if (Regex.IsMatch(userInput, @"^[a-zA-Z\s]+$"))
            {
                int dotCount = CountBrailleDots(userInput);

                dotCountLabel.Text = "The word ' " + userInput + " ' contains ' " + dotCount + " ' Braille dots.";

                string brailleWord = ConvertWordToBraille(userInput);

               
                BrailleLabel.Text = brailleWord;
 
            }
            
                //dotCountLabel.Text = "Error: Please enter only English letters and spaces.";
                else
                {
                
                MessageBox.Show("Error: Please Select a Shape or Enter Text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string ConvertWordToBraille(string word)
        {
            string brailleWord = "";
            foreach (char letter in word.ToLower())
            {
                brailleWord += ConvertToBraille(letter);
            }
            return brailleWord;
            
        }

        private string ConvertToBraille(char letter)
        {
            switch (letter)
            {
                case 'a': return "⠁";
                case 'b': return "⠃";
                case 'c': return "⠉";
                case 'd': return "⠙";
                case 'e': return "⠑";
                case 'f': return "⠋";
                case 'g': return "⠛";
                case 'h': return "⠓";
                case 'i': return "⠊";
                case 'j': return "⠚";
                case 'k': return "⠅";
                case 'l': return "⠇";
                case 'm': return "⠍";
                case 'n': return "⠝";
                case 'o': return "⠕";
                case 'p': return "⠏";
                case 'q': return "⠟";
                case 'r': return "⠗";
                case 's': return "⠎";
                case 't': return "⠞";
                case 'u': return "⠥";
                case 'v': return "⠧";
                case 'w': return "⠺";
                case 'x': return "⠭";
                case 'y': return "⠽";
                case 'z': return "⠵";
                default: return "";
            }
        }

        private int CountBrailleDots(string input)
        {
            int dotCount = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case ' ':
                        dotCount += 0;
                        break;
                    case 'a':
                        dotCount += 1;
                        break;
                    case 'b':
                    case 'c':
                    case 'e':
                    case 'i':
                    case 'k':
                        dotCount += 2;
                        break;
                    case 'd':
                    case 'f':
                    case 'h':
                    case 'j':
                    case 'l':
                    case 'm':
                    case 'o':
                    case 's':
                    case 'u':
                        dotCount += 3;
                        break;
                    case 'g':
                    case 'n':
                    case 'p':
                    case 'r':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'z':
                        dotCount += 4;
                        break;
                    case 'q':
                    case 'y':
                        dotCount += 5;
                        break;
                    default:
                        break;
                }
            }

            return dotCount;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cirbutton_Click(object sender, EventArgs e)
        {
            //cir , cirbutton , cirtext
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
                    groupBox3.Visible = true;
                    comboBox1.Text = null;
                }
            }
            catch(Exception )
            {
                groupBox3.Visible = false;
                MessageBox.Show("Error: Please Enter Radius", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }


            



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
                    brailtext.Text = Convert.ToString(brailleNum);




                    comboBox1.Text = null;

                    groupBox3.Visible = true;
                }
            }
            catch(Exception )
           
            
            {
                groupBox3.Visible=false;
                MessageBox.Show("Error: Please Enter Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sqbutton_Click(object sender, EventArgs e)
        {
            //squ, sqbutton, sqtext1
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
                    comboBox1.Text = null;

                    groupBox3.Visible = true;
                }
            }
            catch (Exception )


            {
                groupBox3.Visible = false;
                MessageBox.Show("Error: Please Enter Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void recbutton_Click(object sender, EventArgs e)
        {
            //rec, rectext1, rectext2, recbutton
            try
            {
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
            
            catch(Exception )
           
            
            {
                groupBox3.Visible = false;
                MessageBox.Show("Error: Please Enter Length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbPERI_Click(object sender, EventArgs e)
        {

        }

        private void ClearLetter_Click(object sender, EventArgs e)
        {
            cirtext.Text = null;
            Braile_addUC.Visible=false;
            comboBox1.Text = null;
            inputTextBox.Text = null;
            rectext1.Text = null;
            rectext2.Text = null;
            tritext1.Text = null;
            tritext2.Text = null;
            tritext3.Text = null;
            sqtext1.Text = null;
        }

        private void shapebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void shapebutton1_Click(object sender, EventArgs e)
        {
            cirtext.Text = null;
            Braile_addUC.Visible = false;
            comboBox1.Text = null;
            inputTextBox.Text = null;
            rectext1.Text = null;
            rectext2.Text = null;
            tritext1.Text = null;
            tritext2.Text = null;
            tritext3.Text = null;
            sqtext1.Text = null;
            groupBox3.Visible = false;

            squ.Visible = false;

            rec.Visible = false;
            cir.Visible = false;
            tri.Visible = false;


        }
    }
    
}
