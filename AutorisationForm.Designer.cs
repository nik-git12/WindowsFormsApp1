namespace WindowsFormsApp1
{
    partial class AutorisationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorisationForm));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.LeftTopPictureBox = new System.Windows.Forms.PictureBox();
            this.RightTopPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.RightButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.refrashKaphaButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(106, 62);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(321, 22);
            this.loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(106, 128);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(322, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LeftTopPictureBox
            // 
            this.LeftTopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LeftTopPictureBox.Image")));
            this.LeftTopPictureBox.Location = new System.Drawing.Point(106, 200);
            this.LeftTopPictureBox.Name = "LeftTopPictureBox";
            this.LeftTopPictureBox.Size = new System.Drawing.Size(74, 80);
            this.LeftTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftTopPictureBox.TabIndex = 2;
            this.LeftTopPictureBox.TabStop = false;
            // 
            // RightTopPictureBox
            // 
            this.RightTopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RightTopPictureBox.Image")));
            this.RightTopPictureBox.Location = new System.Drawing.Point(194, 200);
            this.RightTopPictureBox.Name = "RightTopPictureBox";
            this.RightTopPictureBox.Size = new System.Drawing.Size(74, 80);
            this.RightTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightTopPictureBox.TabIndex = 3;
            this.RightTopPictureBox.TabStop = false;
            // 
            // LeftButtonPictureBox
            // 
            this.LeftButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LeftButtonPictureBox.Image")));
            this.LeftButtonPictureBox.Location = new System.Drawing.Point(106, 286);
            this.LeftButtonPictureBox.Name = "LeftButtonPictureBox";
            this.LeftButtonPictureBox.Size = new System.Drawing.Size(74, 80);
            this.LeftButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftButtonPictureBox.TabIndex = 4;
            this.LeftButtonPictureBox.TabStop = false;
            // 
            // RightButtonPictureBox
            // 
            this.RightButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RightButtonPictureBox.Image")));
            this.RightButtonPictureBox.Location = new System.Drawing.Point(194, 286);
            this.RightButtonPictureBox.Name = "RightButtonPictureBox";
            this.RightButtonPictureBox.Size = new System.Drawing.Size(74, 80);
            this.RightButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightButtonPictureBox.TabIndex = 5;
            this.RightButtonPictureBox.TabStop = false;
            // 
            // refrashKaphaButton
            // 
            this.refrashKaphaButton.Location = new System.Drawing.Point(330, 240);
            this.refrashKaphaButton.Name = "refrashKaphaButton";
            this.refrashKaphaButton.Size = new System.Drawing.Size(118, 23);
            this.refrashKaphaButton.TabIndex = 6;
            this.refrashKaphaButton.Text = "Перемешать";
            this.refrashKaphaButton.UseVisualStyleBackColor = true;
            this.refrashKaphaButton.Click += new System.EventHandler(this.refrashKaphaButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(330, 308);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(118, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.refrashKaphaButton);
            this.Controls.Add(this.RightButtonPictureBox);
            this.Controls.Add(this.LeftButtonPictureBox);
            this.Controls.Add(this.RightTopPictureBox);
            this.Controls.Add(this.LeftTopPictureBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "AutorisationForm";
            this.Text = "AutorisationForm";
            ((System.ComponentModel.ISupportInitialize)(this.LeftTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightButtonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox LeftTopPictureBox;
        private System.Windows.Forms.PictureBox RightTopPictureBox;
        private System.Windows.Forms.PictureBox LeftButtonPictureBox;
        private System.Windows.Forms.PictureBox RightButtonPictureBox;
        private System.Windows.Forms.Button refrashKaphaButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}