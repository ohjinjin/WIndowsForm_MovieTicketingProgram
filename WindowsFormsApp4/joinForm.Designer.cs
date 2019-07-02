namespace WindowsFormsApp4
{
    partial class JoinForm
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
            this.comboBox_for_email = new System.Windows.Forms.ComboBox();
            this.comboBox_phone = new System.Windows.Forms.ComboBox();
            this.label_at = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.email2 = new System.Windows.Forms.TextBox();
            this.phone2 = new System.Windows.Forms.TextBox();
            this.phone1 = new System.Windows.Forms.TextBox();
            this.email1 = new System.Windows.Forms.TextBox();
            this.verifyPw = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_verifyPw = new System.Windows.Forms.Label();
            this.label_pw = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_join = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_for_email
            // 
            this.comboBox_for_email.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_for_email.FormattingEnabled = true;
            this.comboBox_for_email.Items.AddRange(new object[] {
            "gmail.com",
            "hanmail.net",
            "naver.com",
            "직접입력"});
            this.comboBox_for_email.Location = new System.Drawing.Point(317, 180);
            this.comboBox_for_email.Name = "comboBox_for_email";
            this.comboBox_for_email.Size = new System.Drawing.Size(77, 24);
            this.comboBox_for_email.Sorted = true;
            this.comboBox_for_email.TabIndex = 45;
            this.comboBox_for_email.SelectedIndexChanged += new System.EventHandler(this.comboBox_for_email_SelectedIndexChanged);
            // 
            // comboBox_phone
            // 
            this.comboBox_phone.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_phone.FormattingEnabled = true;
            this.comboBox_phone.Items.AddRange(new object[] {
            "010",
            "011",
            "016",
            "017",
            "018",
            "019"});
            this.comboBox_phone.Location = new System.Drawing.Point(132, 208);
            this.comboBox_phone.Name = "comboBox_phone";
            this.comboBox_phone.Size = new System.Drawing.Size(77, 24);
            this.comboBox_phone.TabIndex = 44;
            // 
            // label_at
            // 
            this.label_at.AutoSize = true;
            this.label_at.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_at.Location = new System.Drawing.Point(213, 183);
            this.label_at.Name = "label_at";
            this.label_at.Size = new System.Drawing.Size(18, 16);
            this.label_at.TabIndex = 37;
            this.label_at.Text = "@";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(132, 99);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(136, 23);
            this.id.TabIndex = 35;
            // 
            // email2
            // 
            this.email2.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email2.Location = new System.Drawing.Point(236, 180);
            this.email2.Name = "email2";
            this.email2.Size = new System.Drawing.Size(75, 23);
            this.email2.TabIndex = 36;
            // 
            // phone2
            // 
            this.phone2.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone2.Location = new System.Drawing.Point(296, 208);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(75, 23);
            this.phone2.TabIndex = 33;
            // 
            // phone1
            // 
            this.phone1.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone1.Location = new System.Drawing.Point(215, 208);
            this.phone1.Name = "phone1";
            this.phone1.Size = new System.Drawing.Size(75, 23);
            this.phone1.TabIndex = 27;
            // 
            // email1
            // 
            this.email1.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email1.Location = new System.Drawing.Point(132, 180);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(75, 23);
            this.email1.TabIndex = 32;
            // 
            // verifyPw
            // 
            this.verifyPw.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.verifyPw.Location = new System.Drawing.Point(132, 153);
            this.verifyPw.Name = "verifyPw";
            this.verifyPw.PasswordChar = '*';
            this.verifyPw.Size = new System.Drawing.Size(136, 23);
            this.verifyPw.TabIndex = 30;
            // 
            // pw
            // 
            this.pw.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw.Location = new System.Drawing.Point(132, 126);
            this.pw.Name = "pw";
            this.pw.PasswordChar = '*';
            this.pw.Size = new System.Drawing.Size(136, 23);
            this.pw.TabIndex = 29;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(132, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(136, 23);
            this.name.TabIndex = 28;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_phone.Location = new System.Drawing.Point(12, 208);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(66, 21);
            this.label_phone.TabIndex = 23;
            this.label_phone.Text = "전화번호";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_email.Location = new System.Drawing.Point(12, 180);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(52, 21);
            this.label_email.TabIndex = 22;
            this.label_email.Text = "이메일";
            // 
            // label_verifyPw
            // 
            this.label_verifyPw.AutoSize = true;
            this.label_verifyPw.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_verifyPw.Location = new System.Drawing.Point(12, 153);
            this.label_verifyPw.Name = "label_verifyPw";
            this.label_verifyPw.Size = new System.Drawing.Size(114, 21);
            this.label_verifyPw.TabIndex = 18;
            this.label_verifyPw.Text = "비밀번호 재입력";
            // 
            // label_pw
            // 
            this.label_pw.AutoSize = true;
            this.label_pw.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_pw.Location = new System.Drawing.Point(12, 126);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(66, 21);
            this.label_pw.TabIndex = 21;
            this.label_pw.Text = "비밀번호";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_id.Location = new System.Drawing.Point(12, 99);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(52, 21);
            this.label_id.TabIndex = 20;
            this.label_id.Text = "아이디";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(12, 72);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 21);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("한컴 백제 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "CGV 회원 가입";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 45);
            this.panel1.TabIndex = 47;
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.Color.Red;
            this.btn_join.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_join.FlatAppearance.BorderSize = 3;
            this.btn_join.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_join.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_join.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_join.Location = new System.Drawing.Point(296, 251);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(98, 31);
            this.btn_join.TabIndex = 48;
            this.btn_join.Text = "회원가입";
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_for_email);
            this.Controls.Add(this.comboBox_phone);
            this.Controls.Add(this.label_at);
            this.Controls.Add(this.id);
            this.Controls.Add(this.email2);
            this.Controls.Add(this.phone2);
            this.Controls.Add(this.phone1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.verifyPw);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_verifyPw);
            this.Controls.Add(this.label_pw);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_name);
            this.Name = "JoinForm";
            this.Text = "joinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_for_email;
        private System.Windows.Forms.ComboBox comboBox_phone;
        private System.Windows.Forms.Label label_at;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox email2;
        private System.Windows.Forms.TextBox phone2;
        private System.Windows.Forms.TextBox phone1;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.TextBox verifyPw;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_verifyPw;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_join;
    }
}