using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace messageboard
{
    public partial class messageboard_form : Form
    {
        static String folderPath = "../../files/";
        System.Timers.Timer timer;

        private delegate void SafeCallDelegate(string text);

        public messageboard_form()
        {
            InitializeComponent();
            RetrieveData();
            timer = new System.Timers.Timer(30000); // 30 secs
            timer.Elapsed += new ElapsedEventHandler(Tmr_ElapsedEvent);
            timer.Start();
        }

        private void Tmr_ElapsedEvent(object sender, ElapsedEventArgs e)
        {
            clearScreen("null");
            RetrieveData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            message_create_form create_form = new message_create_form();
            create_form.Show();
        }
        private void clearScreen(String content)
        {
            if (txtMessageboard.InvokeRequired)
            {
                var d = new SafeCallDelegate(clearScreen);

                txtMessageboard.Invoke(d, new object[] { content });
            }
            else
            {
                txtMessageboard.Clear();
            }
        }

        private void WriteToScreen(String content)
        {
            if (txtMessageboard.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteToScreen);

                txtMessageboard.Invoke(d, new object[] { content });
            } 
            else
            {
                txtMessageboard.AppendText(content);
            }
            
        }
        private void RetrieveData()
        {
            String totalData = "";
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                String data = "";

                String random = "------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
                totalData = random + totalData;
                using (StreamReader readtext = new StreamReader(file))
                {
                    while (readtext.Peek() >= 0){
                        data += readtext.ReadLine() + Environment.NewLine;
                    }
                    //WriteToScreen(data);
                    totalData = data + totalData;
                }

                //WriteToScreen(random + Environment.NewLine);
                // Since 1 inch = 96 px, and 1 font = 1/72 inches
                //MessageBox.Show(txtMessageboard.Width.ToString());
            }
            WriteToScreen(totalData);
        }
    }
}
