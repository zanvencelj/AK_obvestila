namespace AK_obvestila
{
    partial class Credentials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credentials));
            this.img = new System.Windows.Forms.PictureBox();
            this.Credentials_saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.portUD = new CustomControls.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.serverTB = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recieverTB = new CustomControls.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTB = new CustomControls.RJControls.RJTextBox();
            this.senderTB = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img.BackgroundImage")));
            this.img.Location = new System.Drawing.Point(-418, -31);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(928, 545);
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // Credentials_saveBtn
            // 
            this.Credentials_saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.Credentials_saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Credentials_saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Credentials_saveBtn.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Credentials_saveBtn.Location = new System.Drawing.Point(16, 259);
            this.Credentials_saveBtn.Name = "Credentials_saveBtn";
            this.Credentials_saveBtn.Size = new System.Drawing.Size(153, 43);
            this.Credentials_saveBtn.TabIndex = 5;
            this.Credentials_saveBtn.Text = "SHRANI";
            this.Credentials_saveBtn.UseVisualStyleBackColor = false;
            this.Credentials_saveBtn.Click += new System.EventHandler(this.Credentials_saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vaš mail:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.cancelBTN);
            this.panel1.Controls.Add(this.portUD);
            this.panel1.Controls.Add(this.Credentials_saveBtn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.serverTB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.recieverTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.senderTB);
            this.panel1.Location = new System.Drawing.Point(27, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 317);
            this.panel1.TabIndex = 13;
            // 
            // cancelBTN
            // 
            this.cancelBTN.FlatAppearance.BorderSize = 0;
            this.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBTN.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelBTN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBTN.Location = new System.Drawing.Point(174, 279);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 6;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // portUD
            // 
            this.portUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.portUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.portUD.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.portUD.BorderSize = 2;
            this.portUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portUD.ForeColor = System.Drawing.Color.DimGray;
            this.portUD.Location = new System.Drawing.Point(174, 208);
            this.portUD.Margin = new System.Windows.Forms.Padding(4);
            this.portUD.Multiline = false;
            this.portUD.Name = "portUD";
            this.portUD.Padding = new System.Windows.Forms.Padding(7);
            this.portUD.PasswordChar = false;
            this.portUD.Size = new System.Drawing.Size(64, 31);
            this.portUD.TabIndex = 4;
            this.portUD.Texts = "";
            this.portUD.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(170, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(12, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Server:";
            // 
            // serverTB
            // 
            this.serverTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.serverTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.serverTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.serverTB.BorderSize = 2;
            this.serverTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTB.ForeColor = System.Drawing.Color.DimGray;
            this.serverTB.Location = new System.Drawing.Point(16, 208);
            this.serverTB.Margin = new System.Windows.Forms.Padding(4);
            this.serverTB.Multiline = false;
            this.serverTB.Name = "serverTB";
            this.serverTB.Padding = new System.Windows.Forms.Padding(7);
            this.serverTB.PasswordChar = false;
            this.serverTB.Size = new System.Drawing.Size(150, 31);
            this.serverTB.TabIndex = 3;
            this.serverTB.Texts = "";
            this.serverTB.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(12, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pošlji na:";
            // 
            // recieverTB
            // 
            this.recieverTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.recieverTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.recieverTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.recieverTB.BorderSize = 2;
            this.recieverTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieverTB.ForeColor = System.Drawing.Color.DimGray;
            this.recieverTB.Location = new System.Drawing.Point(16, 150);
            this.recieverTB.Margin = new System.Windows.Forms.Padding(4);
            this.recieverTB.Multiline = false;
            this.recieverTB.Name = "recieverTB";
            this.recieverTB.Padding = new System.Windows.Forms.Padding(7);
            this.recieverTB.PasswordChar = false;
            this.recieverTB.Size = new System.Drawing.Size(222, 31);
            this.recieverTB.TabIndex = 2;
            this.recieverTB.Texts = "";
            this.recieverTB.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Geslo:";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.passwordTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.passwordTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordTB.BorderSize = 2;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.Location = new System.Drawing.Point(16, 92);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTB.PasswordChar = true;
            this.passwordTB.Size = new System.Drawing.Size(222, 31);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.Texts = "";
            this.passwordTB.UnderlinedStyle = true;
            // 
            // senderTB
            // 
            this.senderTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.senderTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.senderTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.senderTB.BorderSize = 2;
            this.senderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderTB.ForeColor = System.Drawing.Color.DimGray;
            this.senderTB.Location = new System.Drawing.Point(16, 34);
            this.senderTB.Margin = new System.Windows.Forms.Padding(4);
            this.senderTB.Multiline = false;
            this.senderTB.Name = "senderTB";
            this.senderTB.Padding = new System.Windows.Forms.Padding(7);
            this.senderTB.PasswordChar = false;
            this.senderTB.Size = new System.Drawing.Size(222, 31);
            this.senderTB.TabIndex = 0;
            this.senderTB.Texts = "";
            this.senderTB.UnderlinedStyle = true;
            // 
            // Credentials
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Credentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credentials";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Credentials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button Credentials_saveBtn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox senderTB;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox portUD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox serverTB;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJTextBox recieverTB;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox passwordTB;
        private System.Windows.Forms.Button cancelBTN;
    }
}