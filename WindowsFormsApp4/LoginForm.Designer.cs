namespace WindowsFormsApp4
{
    partial class LoginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tbox_pw = new System.Windows.Forms.TextBox();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.btn_potentialUser = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_login.Location = new System.Drawing.Point(24, 151);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(280, 31);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbox_pw
            // 
            this.tbox_pw.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbox_pw.Location = new System.Drawing.Point(63, 117);
            this.tbox_pw.Name = "tbox_pw";
            this.tbox_pw.PasswordChar = '*';
            this.tbox_pw.Size = new System.Drawing.Size(241, 28);
            this.tbox_pw.TabIndex = 18;
            // 
            // tbox_id
            // 
            this.tbox_id.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbox_id.Location = new System.Drawing.Point(63, 83);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(241, 28);
            this.tbox_id.TabIndex = 18;
            // 
            // btn_potentialUser
            // 
            this.btn_potentialUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_potentialUser.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_potentialUser.FlatAppearance.BorderSize = 0;
            this.btn_potentialUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_potentialUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_potentialUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_potentialUser.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_potentialUser.Location = new System.Drawing.Point(124, 188);
            this.btn_potentialUser.Name = "btn_potentialUser";
            this.btn_potentialUser.Size = new System.Drawing.Size(86, 34);
            this.btn_potentialUser.TabIndex = 21;
            this.btn_potentialUser.Text = "비회원 예매";
            this.btn_potentialUser.UseVisualStyleBackColor = false;
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.Color.Transparent;
            this.btn_join.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_join.FlatAppearance.BorderSize = 0;
            this.btn_join.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_join.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_join.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_join.Location = new System.Drawing.Point(229, 188);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 34);
            this.btn_join.TabIndex = 21;
            this.btn_join.Text = "회원가입";
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(213, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("한컴 백제 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "CGV회원 로그인";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.pw;
            this.pictureBox2.Location = new System.Drawing.Point(24, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.userid;
            this.pictureBox1.Location = new System.Drawing.Point(19, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 45);
            this.panel1.TabIndex = 24;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_potentialUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.tbox_pw);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbox_pw;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_potentialUser;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}