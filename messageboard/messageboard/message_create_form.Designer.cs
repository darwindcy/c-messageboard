namespace messageboard
{
    partial class message_create_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtCurrentDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessagedetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessagetitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.buttonConfirmPost = new System.Windows.Forms.Button();
            this.txtConfirmdetail = new System.Windows.Forms.TextBox();
            this.txtConfirmtitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.panelDetail.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtCurrentDateTime
            // 
            this.dtCurrentDateTime.Enabled = false;
            this.dtCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCurrentDateTime.Location = new System.Drawing.Point(228, 156);
            this.dtCurrentDateTime.Name = "dtCurrentDateTime";
            this.dtCurrentDateTime.Size = new System.Drawing.Size(286, 26);
            this.dtCurrentDateTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message Detail";
            // 
            // txtMessagedetail
            // 
            this.txtMessagedetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessagedetail.Location = new System.Drawing.Point(228, 261);
            this.txtMessagedetail.Multiline = true;
            this.txtMessagedetail.Name = "txtMessagedetail";
            this.txtMessagedetail.Size = new System.Drawing.Size(427, 166);
            this.txtMessagedetail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message Title";
            // 
            // txtMessagetitle
            // 
            this.txtMessagetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessagetitle.Location = new System.Drawing.Point(228, 205);
            this.txtMessagetitle.Name = "txtMessagetitle";
            this.txtMessagetitle.Size = new System.Drawing.Size(427, 26);
            this.txtMessagetitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(228, 448);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(148, 38);
            this.btnPost.TabIndex = 9;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(228, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(286, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create Message";
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.LightGray;
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.buttonConfirmPost);
            this.panelDetail.Controls.Add(this.txtConfirmdetail);
            this.panelDetail.Controls.Add(this.txtConfirmtitle);
            this.panelDetail.Controls.Add(this.label8);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelDetail.Location = new System.Drawing.Point(164, 26);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(701, 572);
            this.panelDetail.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(210, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonConfirmPost
            // 
            this.buttonConfirmPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPost.ForeColor = System.Drawing.Color.Maroon;
            this.buttonConfirmPost.Location = new System.Drawing.Point(458, 456);
            this.buttonConfirmPost.Name = "buttonConfirmPost";
            this.buttonConfirmPost.Size = new System.Drawing.Size(98, 42);
            this.buttonConfirmPost.TabIndex = 14;
            this.buttonConfirmPost.Text = "Post";
            this.buttonConfirmPost.UseVisualStyleBackColor = true;
            this.buttonConfirmPost.Click += new System.EventHandler(this.buttonConfirmPost_Click);
            // 
            // txtConfirmdetail
            // 
            this.txtConfirmdetail.Enabled = false;
            this.txtConfirmdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmdetail.ForeColor = System.Drawing.Color.Maroon;
            this.txtConfirmdetail.Location = new System.Drawing.Point(210, 185);
            this.txtConfirmdetail.Multiline = true;
            this.txtConfirmdetail.Name = "txtConfirmdetail";
            this.txtConfirmdetail.Size = new System.Drawing.Size(376, 201);
            this.txtConfirmdetail.TabIndex = 13;
            // 
            // txtConfirmtitle
            // 
            this.txtConfirmtitle.Enabled = false;
            this.txtConfirmtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmtitle.ForeColor = System.Drawing.Color.Maroon;
            this.txtConfirmtitle.Location = new System.Drawing.Point(210, 108);
            this.txtConfirmtitle.Name = "txtConfirmtitle";
            this.txtConfirmtitle.Size = new System.Drawing.Size(263, 26);
            this.txtConfirmtitle.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(73, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Message Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(73, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Message Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(203, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "Message Detail";
            // 
            // panelCreate
            // 
            this.panelCreate.BackColor = System.Drawing.Color.LightGray;
            this.panelCreate.Controls.Add(this.label5);
            this.panelCreate.Controls.Add(this.txtUsername);
            this.panelCreate.Controls.Add(this.btnPost);
            this.panelCreate.Controls.Add(this.label1);
            this.panelCreate.Controls.Add(this.txtMessagetitle);
            this.panelCreate.Controls.Add(this.label2);
            this.panelCreate.Controls.Add(this.txtMessagedetail);
            this.panelCreate.Controls.Add(this.label3);
            this.panelCreate.Controls.Add(this.label4);
            this.panelCreate.Controls.Add(this.dtCurrentDateTime);
            this.panelCreate.ForeColor = System.Drawing.Color.Maroon;
            this.panelCreate.Location = new System.Drawing.Point(164, 26);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(704, 575);
            this.panelCreate.TabIndex = 9;
            // 
            // message_create_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 657);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelCreate);
            this.Name = "message_create_form";
            this.Text = "message_create_form";
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtCurrentDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessagedetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessagetitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button buttonConfirmPost;
        private System.Windows.Forms.TextBox txtConfirmdetail;
        private System.Windows.Forms.TextBox txtConfirmtitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}