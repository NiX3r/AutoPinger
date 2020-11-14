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
    public partial class Converter : Form
    {

        private OpenFileDialog input = null;
        private SaveFileDialog output = null;

        public Converter()
        {
            InitializeComponent();
            check.Hide();
            notCheck.Hide();
        }

        private void iconButtonFrom_Click(object sender, EventArgs e)
        {

            openFileDialog1.Reset();

            openFileDialog1.Filter = "TXT File | *.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                input = openFileDialog1;

            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Reset();

            saveFileDialog1.Filter = "PDF File | *.pdf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                output = saveFileDialog1;

            }

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            int minPing;
            Boolean succesCreated;

            if(input != null && output != null)
            {

                minPing = (int) numericUpDown1.Value;

                succesCreated = CreateWEB.web(input, output, minPing);

                if (succesCreated)
                {
                    check.Show();
                }
                else
                {
                    notCheck.Show();
                }

            }

        }
    }
}
