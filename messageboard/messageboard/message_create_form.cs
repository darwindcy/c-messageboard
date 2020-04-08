using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageboard
{
    public partial class message_create_form : Form
    {
        static String fileLocation = "../../files/";

        static String messageDate;
        static String messageTitle;
        static String messageDetail;
        static String postedBy;

        public message_create_form()
        {
            InitializeComponent();
            SetUserName();
            panelDetail.Hide();
        }

        private void WriteToFile()
        {

        }

        private void SetUserName()
        {
            txtUsername.Text = Form1.userName;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

            messageDate = dtCurrentDateTime.Value.ToString();
            messageTitle = txtMessagetitle.Text;
            messageDetail = txtMessagedetail.Text;
            postedBy = txtUsername.Text;

            if (String.IsNullOrEmpty(messageDetail))
            {
                MessageBox.Show("Message Detail cannot be empty or spaces");
            }

            if (String.IsNullOrEmpty(messageTitle))
            {
                MessageBox.Show("Message Title cannot be empty or spaces");
            }


            if (!String.IsNullOrEmpty(messageDetail) && !String.IsNullOrEmpty(messageTitle))
            {

                panelCreate.Hide();

                panelDetail.Show();

                txtConfirmtitle.Text = messageTitle;
                txtConfirmdetail.Text = messageDetail;
            }
        }
    
        private string CreateFileName()
        {
            String fileName = "";
            String dateNow = DateTime.Now.ToString("HH-mm-ss_MM-dd-yyyy_");

            return dateNow;
        }

        private void buttonConfirmPost_Click(object sender, EventArgs e)
        {
            String fileName = CreateFileName() + ".txt";

            using (StreamWriter writeFile = new StreamWriter(fileLocation + fileName, true))
            {
                writeFile.WriteLine("Posted By: " + postedBy);
                writeFile.WriteLine("Date:" + messageDate + Environment.NewLine);
                writeFile.WriteLine("Title: " + messageTitle + Environment.NewLine);
                writeFile.WriteLine("Detail:" + Environment.NewLine + messageDetail);
            }
            this.Close();
            messageboard_form newForm = new messageboard_form();
            newForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            messageboard_form newForm = new messageboard_form();
            newForm.Show();
        }
    }
}
