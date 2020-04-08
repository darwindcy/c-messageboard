namespace messageboard
{
    partial class messageboard_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMessageboard = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message Board";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightGray;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Maroon;
            this.btnNew.Location = new System.Drawing.Point(642, 59);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(238, 38);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Create New Message";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtMessageboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(43, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 628);
            this.panel1.TabIndex = 2;
            // 
            // txtMessageboard
            // 
            this.txtMessageboard.BackColor = System.Drawing.Color.Silver;
            this.txtMessageboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageboard.ForeColor = System.Drawing.Color.Maroon;
            this.txtMessageboard.Location = new System.Drawing.Point(145, 114);
            this.txtMessageboard.Multiline = true;
            this.txtMessageboard.Name = "txtMessageboard";
            this.txtMessageboard.ReadOnly = true;
            this.txtMessageboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageboard.Size = new System.Drawing.Size(627, 485);
            this.txtMessageboard.TabIndex = 2;
            // 
            // messageboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 672);
            this.Controls.Add(this.panel1);
            this.Name = "messageboard_form";
            this.Text = "messageboard_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMessageboard;
    }
}