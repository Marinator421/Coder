using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder
{
    public partial class ZcoderForm : Form
    {
        public ZcoderForm()
        {
            InitializeComponent();
        }

        string Codovani(string zakodovat, bool tamCiZpet, int key1, int key2, int key3)
        {
            char[] text = zakodovat.ToCharArray();
            char[] zakodovano = new char[text.Length];
            long karel;
            if (text.Length != 0)
            {
                if (key1 != 0 || key2 != 0 || key3 != 0)
                {

                    for (int i = 0; i < text.Length; i++)
                    {
                        long oKolikZmenit = (key1 * i * i) + (key2 * i) + key3;
                        
                        if (tamCiZpet)
                        {
                            karel = text[i] + oKolikZmenit;
                        }
                        else
                        {
                            karel = text[i] - oKolikZmenit;
                        }

                        karel -= 32;

                        if (karel < 0)
                        {
                            karel = karel % 95;
                            karel = (long) 95 + karel;
                            if (karel == 95)
                            {
                                karel = 0;
                            }
                        }
                        else
                        {
                            karel = karel % 95;
                        }

                        karel += 32;

                        Console.Write(karel);

                        /*
                        while (karel < 32 || karel > 126)
                        {
                            if (karel < 32)
                            {
                                karel = karel + 95;
                            }
                            else if (karel > 126)
                            {
                                karel = karel - 95;
                            }
                        }
                        */

                        //Console.WriteLine(karel);
                        zakodovano[i] = Convert.ToChar(karel);
                    }
                    return new string(zakodovano);
                }
                else
                {
                    MessageBox.Show("Please insert keys :)",
                                   "Error :(", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1);
                    return "";
                }
            }
            else
            {
                MessageBox.Show("Please insert some text :)",
                                   "Error :(", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1);
                return "";
            }
        }


        private void Encode(object sender, EventArgs e)
        {          
            TextEncodeOutput.Text = Codovani(TextEncodeInput.Text, true, (int)NumFirst.Value, (int)NumSecond.Value, (int)NumThird.Value);
        }

        private void Decode(object sender, EventArgs e)
        {
            TextEncodeOutput.Text = Codovani(TextEncodeInput.Text, false, (int)NumFirst.Value, (int)NumSecond.Value, (int)NumThird.Value);
        }
    }
}
