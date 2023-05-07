using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace braile_final
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void countButton_Click(object sender, EventArgs e)
        {
            

        }

        private void countButton_Click_1(object sender, EventArgs e)
        {
            string userInput = inputTextBox.Text;

            if (countButton != null && comboBox1.SelectedIndex == 0)
            {
                //cirtext1
                //cirbox

                cirUC cir = new cirUC();
                addUserControl(cir);



            }
            else if (countButton != null && comboBox1.SelectedIndex == 1)
            {
                //tri
                //tribox1, tribox2, tribox3
                //tributton

                triUC tripanel = new triUC();
                addUserControl(tripanel);


            }

            else if (countButton != null && comboBox1.SelectedIndex == 2)
            {
                //sqbutton , squtext
                //squre

                squreUC sq = new squreUC();
                addUserControl(sq);


            }
            else if (countButton != null && comboBox1.SelectedIndex == 3)
            {
                //rectext1 , rectext2 , recbotton , recta

                rectangleUC re = new rectangleUC();
                addUserControl(re);

            }




            

            else if (Regex.IsMatch(userInput, @"^[a-zA-Z\s]+$"))
            {
                panel2.Visible = true;

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

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            
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
    }
}
