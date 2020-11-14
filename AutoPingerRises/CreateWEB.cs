using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPingerRises
{
    class CreateWEB
    {

        public static Boolean web(OpenFileDialog ofd, SaveFileDialog sfd, int moreThan)
        {

            try
            {

                StreamReader txt = new StreamReader(ofd.FileName);
                String html = "<HTML><HEAD><meta charset='UTF-8'><TITLE>AutoPinger v%version%</TITLE><style>table, th, td {border: 1px solid black;}</style></HEAD><BODY><FIELDSET><LEGEND><H1><CENTER>Tested server: %server%</CENTER></H1></LEGEND><FIELDSET><LEGEND><H3>Informations</H3></LEGEND><BR><DIV ALIGN=%1%left%1%>Maximum: %maximum% | Minimum: %minimum%</DIV><DIV ALIGN=%1%center%1%>Average: %average% | Losts: %losts%</DIV><DIV ALIGN=%1%right%1%>File: %file%</DIV></FIELDSET><BR><BR><FIELDSET><LEGEND><H3>Records</H3></LEGEND><BR><DIV ALIGN=%1%left%1%>Total: %total% | UnReadable: %unreadable%</DIV><DIV ALIGN=%1%center%1%>Started: %started% | Ended: %ended%</DIV><DIV ALIGN=%1%right%1%>On: %on% | Off: %off%</DIV></FIELDSET><BR><BR><FIELDSET><LEGEND><H3>Could Not Pass Server</H3></LEGEND><BR><DIV ALIGN=%1%center%1%><TABLE width=%1%100%%1%><TR><TH>Date Time</TH><TH>Text Adress</TH></TR>%cnps%</TABLE></DIV></FIELDSET><BR><BR><FIELDSET><LEGEND><H3>Drops - more than: %morethan%</H3></LEGEND><BR><DIV ALIGN=%1%center%1%><TABLE width=%1%100%%1%><TR><TH>Date Time</TH><TH>Ping</TH><TH>Adress</TH><TH>Text Adress</TH></TR>%drops%</TABLE></DIV></FIELDSET><BR><BR><BR><DIV ALIGN=%1%center%1%><H3>© 2020 AutoPinger All rights reserved. Created by NiX3r</H3></DIV><BR><BR></FIELDSET></BODY></HTML>";
                String file = ofd.FileName, started = "", stopped = "", cnps = "", drops = "", server = "";
                int max = 0, min = 0, average = 0, losts = 0, total = 0, unread = 0, on = 0, off = 0;

                while (true)
                {

                    String line = txt.ReadLine();
                    Char[] cLine;

                    cLine = line.ToArray();

                    if (cLine[(line.Length - 1)].Equals('P'))
                    {

                        try
                        {

                            String[] variables = line.Split(';'); // 0 = date; 1 = ping; 2 = average; 3 = adress; 4 = text adress; 5 = losts; 6 = min; 7 = max; 8 = only P
                                                                  //MessageBox.Show("isLost = false\n" + variables[0] + "\n" + variables[1] + "\n" + variables[2] + "\n" + variables[3] + "\n" + variables[4] + "\n" + variables[5] + "\n" + variables[6] + "\n" + variables[7]);
                            int ping = int.Parse(variables[1]);
                            min = int.Parse(variables[6]);
                            max = int.Parse(variables[7]);
                            average = int.Parse(variables[2]);
                            stopped = variables[0];
                            server = variables[4] + "[" + variables[3] + "]";

                            if (total == 0)
                                started = variables[0];

                            if (ping > moreThan)
                            {

                                drops += "<TR>" +
                                        "<TD><CENTER>" + variables[0] + "</CENTER></TD>" +
                                        "<TD><CENTER>" + variables[1] + "</CENTER></TD>" +
                                        "<TD><CENTER>" + variables[3] + "</CENTER></TD>" +
                                        "<TD><CENTER>" + variables[4] + "</CENTER></TD>" +
                                        "</TR>";

                            }

                            total++;

                        }
                        catch (Exception e)
                        {

                            MessageBox.Show("error: " + e.ToString());
                            unread++;
                            break;

                        }

                    }
                    else if (cLine[(line.Length - 1)].Equals('L'))
                    {

                        String[] variables = line.Split(';'); // 0 = date time; 1 = text adress; 2 = losts; 3 = min; 4 = max; 5 = only L
                                                              //MessageBox.Show("isLost = false\n" + variables[0] + "\n" + variables[1] + "\n" + variables[2] + "\n" + variables[3] + "\n" + variables[4]);
                        server = variables[1] + $"[{variables[1]}]";

                        cnps += "<TR>" +
                                "<TD><CENTER>" + variables[0] + "</CENTER></TD>" +
                                "<TD><CENTER>" + variables[1] + "</CENTER></TD>" +
                                "</TR>";

                        losts++;

                    }
                    else if (cLine[(line.Length - 1)].Equals('T'))
                    {
                        on++;
                    }
                    else if (cLine[(line.Length - 1)].Equals('F'))
                    {
                        off++;
                    }
                    else
                    {
                        unread++;
                        break;
                    }

                    if (txt.EndOfStream)
                        break;

                }

                html = html.Replace("%1%", "\"");
                html = html.Replace("%maximum%", max.ToString());
                html = html.Replace("%minimum%", min.ToString());
                html = html.Replace("%average%", average.ToString());
                html = html.Replace("%losts%", losts.ToString());
                html = html.Replace("%file%", file);
                html = html.Replace("%total%", total.ToString());
                html = html.Replace("%started%", started);
                html = html.Replace("%ended%", stopped);
                html = html.Replace("%unreadable%", unread.ToString());
                html = html.Replace("%cnps%", cnps);
                html = html.Replace("%drops%", drops);
                html = html.Replace("%on%", on.ToString());
                html = html.Replace("%off%", off.ToString());
                html = html.Replace("%version%", Program.version);
                html = html.Replace("%server%", server);
                html = html.Replace("%morethan%", moreThan.ToString());

                //MessageBox.Show(drops);

                var pdf = OpenHtmlToPdf.Pdf.From(html).Content();
                File.WriteAllBytes(sfd.FileName, pdf);

                txt.Close();
                return true;

            }
            catch(Exception e)
            {

                MessageBox.Show("Error: " + e.Message);
                return false;

            }

        }

    }
}
