namespace OrderEase
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.ImgPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGetStarted = new System.Windows.Forms.Panel();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblOrderEase = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkForgotPw = new System.Windows.Forms.LinkLabel();
            this.linkSingup = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgPanel.SuspendLayout();
            this.panelGetStarted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgPanel
            // 
            this.ImgPanel.BackColor = System.Drawing.Color.MintCream;
            this.ImgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgPanel.BackgroundImage")));
            this.ImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgPanel.Controls.Add(this.panelGetStarted);
            this.ImgPanel.Location = new System.Drawing.Point(591, 0);
            this.ImgPanel.Name = "ImgPanel";
            this.ImgPanel.Size = new System.Drawing.Size(393, 608);
            this.ImgPanel.TabIndex = 0;
            // 
            // panelGetStarted
            // 
            this.panelGetStarted.BackColor = System.Drawing.Color.White;
            this.panelGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGetStarted.Controls.Add(this.closeIcon);
            this.panelGetStarted.Controls.Add(this.label4);
            this.panelGetStarted.Controls.Add(this.label3);
            this.panelGetStarted.Location = new System.Drawing.Point(3, 3);
            this.panelGetStarted.Name = "panelGetStarted";
            this.panelGetStarted.Size = new System.Drawing.Size(403, 605);
            this.panelGetStarted.TabIndex = 0;
            // 
            // closeIcon
            // 
            this.closeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeIcon.BackgroundImage")));
            this.closeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeIcon.Location = new System.Drawing.Point(360, 9);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(19, 18);
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Brush Script MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(116, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = " Get Started ";
            //this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Craving Something ?";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginEmail.ForeColor = System.Drawing.Color.Black;
            this.txtLoginEmail.Location = new System.Drawing.Point(48, 237);
            this.txtLoginEmail.Multiline = true;
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(287, 36);
            this.txtLoginEmail.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.Location = new System.Drawing.Point(48, 317);
            this.txtLoginPassword.Multiline = true;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(287, 34);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(48, 204);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(48, 285);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOrderEase
            // 
            this.lblOrderEase.AutoSize = true;
            this.lblOrderEase.Font = new System.Drawing.Font("Snap ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOrderEase.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOrderEase.Location = new System.Drawing.Point(12, 18);
            this.lblOrderEase.Name = "lblOrderEase";
            this.lblOrderEase.Size = new System.Drawing.Size(161, 30);
            this.lblOrderEase.TabIndex = 5;
            this.lblOrderEase.Text = "OrderEase";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(48, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(150, 28);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Welcome Back";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkForgotPw
            // 
            this.linkForgotPw.AutoSize = true;
            this.linkForgotPw.LinkColor = System.Drawing.Color.IndianRed;
            this.linkForgotPw.Location = new System.Drawing.Point(175, 354);
            this.linkForgotPw.Name = "linkForgotPw";
            this.linkForgotPw.Size = new System.Drawing.Size(160, 20);
            this.linkForgotPw.TabIndex = 8;
            this.linkForgotPw.TabStop = true;
            this.linkForgotPw.Text = "Forgot your password?";
            // 
            // linkSingup
            // 
            this.linkSingup.AutoSize = true;
            this.linkSingup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkSingup.LinkColor = System.Drawing.Color.IndianRed;
            this.linkSingup.Location = new System.Drawing.Point(208, 511);
            this.linkSingup.Name = "linkSingup";
            this.linkSingup.Size = new System.Drawing.Size(63, 20);
            this.linkSingup.TabIndex = 9;
            this.linkSingup.TabStop = true;
            this.linkSingup.Text = "Sign Up";
            this.linkSingup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSingup_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(48, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Log In with your email and password";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkSingup);
            this.Controls.Add(this.linkForgotPw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblOrderEase);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.ImgPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImgPanel.ResumeLayout(false);
            this.panelGetStarted.ResumeLayout(false);
            this.panelGetStarted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel ImgPanel;
        private TextBox txtLoginEmail;
        private TextBox txtLoginPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblOrderEase;
        private Label lblLogin;
        private Button button1;
        private LinkLabel linkForgotPw;
        private LinkLabel linkSingup;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panelGetStarted;
        private PictureBox closeIcon;
    }
}