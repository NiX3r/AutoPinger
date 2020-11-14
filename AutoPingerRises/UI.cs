using AutoPingerRises.ChildForms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPingerRises
{
    public partial class UI : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public UI()
        {
            InitializeComponent();

            // first initialization
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            // set home as active button
            currentBtn = iconButtonHome;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = Color.FromArgb(95, 77, 221);
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = Color.FromArgb(95, 77, 221);
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;

            leftBorderBtn.BackColor = Color.FromArgb(95, 77, 221);
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

            OpenChildForm(new Home());

        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        // Methods

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object SenderBtn, Color color)
        {

            if(SenderBtn != null)
            {

                DisableButton();

                currentBtn = (IconButton)SenderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }

        }

        private void DisableButton()
        {

            if(currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }

        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            if (!Program.isActive)
            {
                ActivateButton(sender, Color.FromArgb(95, 77, 221));
                OpenChildForm(new Home());
            }
        }

        private void iconButtonPing_Click(object sender, EventArgs e)
        {
            if (!Program.isActive)
            {
                ActivateButton(sender, Color.FromArgb(95, 77, 221));
                OpenChildForm(new FormPing());
            }
        }

        private void iconButtonConvert_Click(object sender, EventArgs e)
        {
            if (!Program.isActive)
            {
                ActivateButton(sender, Color.FromArgb(95, 77, 221));
                OpenChildForm(new Converter());
            }
        }

        private void iconButtonSettings_Click(object sender, EventArgs e)
        {
            if (!Program.isActive)
            {
                ActivateButton(sender, Color.FromArgb(95, 77, 221));
                OpenChildForm(new Settings());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/profiles/76561198175401285");
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(95, 77, 221));
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBoxDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/g892nvr");
        }

        private void iconPictureBoxSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/niix3r/");
        }

        private void iconPictureBoxMaxiMini_Click(object sender, EventArgs e)
        {

            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                iconPictureBoxMaxiMini.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                iconPictureBoxMaxiMini.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxEmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:nixiicz@email.cz");
        }
    }
}
