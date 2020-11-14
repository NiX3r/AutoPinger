using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPingerRises.ChildForms
{
    public partial class FormPing : Form
    {

        private static int pLosts = 0, pMin = 10000, pMax = 0, arrayIndex = 0;
        private static long[] pingsArray = new long[30];
        private static decimal index = 0;

        public FormPing()
        {
            InitializeComponent();
        }

        private void Ping_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {

            if (Program.isActive)
            {
                iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Play;
                stopping();
            }
            else
            {
                iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Pause;
                starting();
            }

        }

        private void stopping()
        {

            Program.isActive = false;

            if (Program.saveFile)
                WritingToFile.writeToFile($";{Program.adress};F");
            
            Program.saveFile = false;
            
            iconButtonHome.Text = "Start";

            richTextBox1.Text += $"[{DateTime.Now}] -> Stoping pinging server={Program.adress}\n";

        }

        private void starting()
        {

            Program.isActive = true;

            iconButtonHome.Text = "Stop";

            if (Program.saveFile)
                WritingToFile.writeToFile($";{Program.adress}:T");

            richTextBox1.Text += $"[{DateTime.Now}] -> Starting pinging server={Program.adress}\n";

            pingLoop();

        }

        private void pingLoop()
        {
            
            try
            {

                Ping aP = new Ping();
                PingReply aR = aP.Send(Program.adress, 100);
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Cannot reached IP from DNS server");
                stopping();

            }

            while (Program.isActive)
            {

                try //success ping
                {

                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send(Program.adress, 100);
                    long lAverage;

                    if (reply != null && reply.RoundtripTime != 0)
                    {

                        if (reply.RoundtripTime <= 50)
                        {
                            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TemperatureLow;
                            iconPictureBox1.IconColor = Color.Lime;
                        }
                        else if (reply.RoundtripTime <= 100 && reply.RoundtripTime > 50)
                        {
                            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ThermometerQuarter;
                            iconPictureBox1.IconColor = Color.Yellow;
                        }
                        else if (reply.RoundtripTime <= 250 && reply.RoundtripTime > 100)
                        {
                            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ThermometerThreeQuarters;
                            iconPictureBox1.IconColor = Color.Orange;
                        }
                        else
                        {
                            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TemperatureHigh;
                            iconPictureBox1.IconColor = Color.Red;
                        }

                        if (reply.Status != IPStatus.TimedOut || reply.Status != IPStatus.TtlExpired)
                        {
                            label1.Text = "Ping: " + reply.RoundtripTime.ToString() + " ms";
                        }
                        else
                        {
                            label1.Text = "Ping: LOST";
                            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TemperatureHigh;
                            iconPictureBox1.IconColor = Color.Red;
                            pLosts++;
                        }

                        if (reply.RoundtripTime > pMax)
                            pMax = (int) reply.RoundtripTime;

                        if (reply.RoundtripTime < pMin)
                            pMin = (int) reply.RoundtripTime;

                        
                        lAverage = calculateAvarage(reply.RoundtripTime);
                        index++;

                        label6.Text = $"Index: {index}";
                        label2.Text = $"Minimum: {pMin}ms";
                        label3.Text = $"Maximum: {pMax}ms";
                        label4.Text = $"Average: {lAverage}ms";
                        label5.Text = $"Losts: {pLosts}";
                        
                        richTextBox1.Text += $"[{DateTime.Now}] -> Ping: {reply.RoundtripTime}ms | Average: {lAverage}ms | Server: {reply.Address}[{Program.adress}] | Losts: {pLosts} | Min/Max: {pMin}/{pMax}ms\n";

                        if ((Program.saveFile) && (reply.RoundtripTime >= Program.minPingToSave) && (reply.Status != IPStatus.TimedOut || reply.Status != IPStatus.TtlExpired))
                        {

                            WritingToFile.writeToFile($";{reply.RoundtripTime};{lAverage};{reply.Address};{Program.adress};{pLosts};{pMin};{pMax};P");

                        }

                    }
                }
                catch //un success ping
                {

                    
                    if(Program.saveFile)
                        WritingToFile.writeToFile($";{Program.adress};{pLosts};{pMin};{pMax};L");

                    richTextBox1.Text += $"[{DateTime.Now}] -> Ping: LOST | Average: NONE | Server: 0.0.0.0[{Program.adress}] | Losts: {pLosts} | Min/Max: {pMin}/{pMax}ms\n";
                    label1.Text = "Ping: LOST";
                    richTextBox1.BackColor = Color.Red;
                    pLosts++;

                }

                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                wait(Program.waitMillis);

            }

        }

        private void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private long calculateAvarage(long millis)
        {

            long result = 0, hN3 = 0;

            if (arrayIndex >= 30)
                arrayIndex = 0;

            pingsArray[arrayIndex] = millis;

            for (int i = 0; i < 30; i++)
            {

                if (pingsArray[i] != 0)
                {
                    hN3++;
                    result = result + pingsArray[i];

                }

                //chart1.Series["Series1"].Points.AddXY(i, pingsArray[i]);

            }

            //chart1.Series["Series1"].Points[arrayIndex].Color = Color.Red;

            result = result / hN3;
            arrayIndex++;

            return result;

        }

    }
}
