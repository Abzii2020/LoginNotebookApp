namespace LoginNotebookApp
{
    partial class Form1
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
            this.lb1_Login = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bttn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1_Login
            // 
            this.lb1_Login.AutoSize = true;
            this.lb1_Login.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1_Login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb1_Login.Location = new System.Drawing.Point(62, 9);
            this.lb1_Login.Name = "lb1_Login";
            this.lb1_Login.Size = new System.Drawing.Size(258, 97);
            this.lb1_Login.TabIndex = 0;
            this.lb1_Login.Text = "Login";
            this.lb1_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(368, 359);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Azure;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(50, 132);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(274, 41);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.Azure;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.BorderWidth = 3;
            this.rectangleShape2.CornerRadius = 3;
            this.rectangleShape2.Location = new System.Drawing.Point(50, 185);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(274, 41);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Azure;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.LightGray;
            this.tb_username.Location = new System.Drawing.Point(50, 138);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(275, 31);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "username";
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_username.Click += new System.EventHandler(this.tb_username_Click);
            this.tb_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Azure;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.LightGray;
            this.tb_password.Location = new System.Drawing.Point(67, 190);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(241, 31);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "password";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.Click += new System.EventHandler(this.tb_password_Click);
            // 
            // bttn_login
            // 
            this.bttn_login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttn_login.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttn_login.Location = new System.Drawing.Point(67, 258);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(241, 64);
            this.bttn_login.TabIndex = 4;
            this.bttn_login.Text = "login";
            this.bttn_login.UseVisualStyleBackColor = false;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 359);
            this.Controls.Add(this.bttn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb1_Login);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Notebook Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1_Login;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bttn_login;
    }
}

