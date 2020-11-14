using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPingerRises.ChildForms
{
    public partial class Settings : Form
    {

        String path;

        public Settings()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (Program.saveFile)
            {

                saveFileDialog1.Filter = "TXT File | *.txt";

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    path = saveFileDialog1.FileName;

                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                Program.saveFile = true;
            }
            else
            {
                Program.saveFile = false;
            }

        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {

            if (Program.saveFile)
            {
                Program.pathToFile = path;
                Program.minPingToSave = (int)numericUpDown2.Value;
            }
            Program.waitMillis = (int) numericUpDown1.Value;
            Program.adress = textBox1.Text;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            checkBox1.Checked = false;
            saveFileDialog1 = null;
            textBox1.Text = "www.google.com";
            numericUpDown1.Value = 1000;
            numericUpDown2.Value = 0;

        }
    }
}
