namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_movie = new System.Windows.Forms.Button();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.btn_myCGV = new System.Windows.Forms.Button();
            this.no1 = new System.Windows.Forms.PictureBox();
            this.no2 = new System.Windows.Forms.PictureBox();
            this.no3 = new System.Windows.Forms.PictureBox();
            this.summary = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ticketing = new System.Windows.Forms.Button();
            this.btn_more = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Label();
            this.label_userid = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Label();
            this.lb_no1 = new System.Windows.Forms.Label();
            this.lb_no2 = new System.Windows.Forms.Label();
            this.lb_no3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp4.Properties.Resources.logo;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 75);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.main_banner;
            this.pictureBox1.Location = new System.Drawing.Point(166, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_movie
            // 
            this.btn_movie.BackColor = System.Drawing.Color.Transparent;
            this.btn_movie.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_movie.FlatAppearance.BorderSize = 0;
            this.btn_movie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_movie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movie.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_movie.Location = new System.Drawing.Point(192, 89);
            this.btn_movie.Name = "btn_movie";
            this.btn_movie.Size = new System.Drawing.Size(75, 34);
            this.btn_movie.TabIndex = 3;
            this.btn_movie.Text = "영화";
            this.btn_movie.UseVisualStyleBackColor = false;
            this.btn_movie.Click += new System.EventHandler(this.btn_movie_Click);
            // 
            // btn_ticket
            // 
            this.btn_ticket.BackColor = System.Drawing.Color.Transparent;
            this.btn_ticket.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_ticket.FlatAppearance.BorderSize = 0;
            this.btn_ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticket.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ticket.Location = new System.Drawing.Point(273, 89);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.Size = new System.Drawing.Size(75, 34);
            this.btn_ticket.TabIndex = 4;
            this.btn_ticket.Text = "예매";
            this.btn_ticket.UseVisualStyleBackColor = false;
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
            // 
            // btn_myCGV
            // 
            this.btn_myCGV.BackColor = System.Drawing.Color.Transparent;
            this.btn_myCGV.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_myCGV.FlatAppearance.BorderSize = 0;
            this.btn_myCGV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_myCGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_myCGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myCGV.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_myCGV.Location = new System.Drawing.Point(354, 89);
            this.btn_myCGV.Name = "btn_myCGV";
            this.btn_myCGV.Size = new System.Drawing.Size(91, 34);
            this.btn_myCGV.TabIndex = 5;
            this.btn_myCGV.Text = "My CGV";
            this.btn_myCGV.UseVisualStyleBackColor = false;
            this.btn_myCGV.Visible = false;
            this.btn_myCGV.Click += new System.EventHandler(this.btn_myCGV_Click);
            // 
            // no1
            // 
            this.no1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no1.Image = global::WindowsFormsApp4.Properties.Resources.알라딘;
            this.no1.Location = new System.Drawing.Point(18, 187);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(185, 259);
            this.no1.TabIndex = 6;
            this.no1.TabStop = false;
            this.no1.Click += new System.EventHandler(this.no1_Click);
            // 
            // no2
            // 
            this.no2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no2.Image = global::WindowsFormsApp4.Properties.Resources.기생충;
            this.no2.Location = new System.Drawing.Point(221, 187);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(185, 259);
            this.no2.TabIndex = 6;
            this.no2.TabStop = false;
            this.no2.Click += new System.EventHandler(this.no2_Click);
            // 
            // no3
            // 
            this.no3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no3.Image = global::WindowsFormsApp4.Properties.Resources.맨_인_블랙_인터내셔널;
            this.no3.Location = new System.Drawing.Point(426, 187);
            this.no3.Name = "no3";
            this.no3.Size = new System.Drawing.Size(185, 259);
            this.no3.TabIndex = 6;
            this.no3.TabStop = false;
            this.no3.Click += new System.EventHandler(this.no3_Click);
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Location = new System.Drawing.Point(31, 510);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(0, 12);
            this.summary.TabIndex = 7;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Black;
            this.info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.info.Location = new System.Drawing.Point(31, 454);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 12);
            this.info.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "현재 상영작";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp4.Properties.Resources.NO1;
            this.pictureBox2.Location = new System.Drawing.Point(10, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 41);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp4.Properties.Resources.NO2;
            this.pictureBox3.Location = new System.Drawing.Point(215, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 41);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp4.Properties.Resources.NO3;
            this.pictureBox4.Location = new System.Drawing.Point(420, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 41);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(10, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 269);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(215, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 269);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(420, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 269);
            this.panel3.TabIndex = 13;
            // 
            // btn_ticketing
            // 
            this.btn_ticketing.BackColor = System.Drawing.Color.Red;
            this.btn_ticketing.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ticketing.FlatAppearance.BorderSize = 3;
            this.btn_ticketing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_ticketing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_ticketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticketing.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ticketing.Location = new System.Drawing.Point(536, 564);
            this.btn_ticketing.Name = "btn_ticketing";
            this.btn_ticketing.Size = new System.Drawing.Size(83, 31);
            this.btn_ticketing.TabIndex = 14;
            this.btn_ticketing.Text = "ticketing";
            this.btn_ticketing.UseVisualStyleBackColor = false;
            this.btn_ticketing.Click += new System.EventHandler(this.ticketing_Click);
            // 
            // btn_more
            // 
            this.btn_more.AutoSize = true;
            this.btn_more.BackColor = System.Drawing.Color.Transparent;
            this.btn_more.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_more.Location = new System.Drawing.Point(571, 122);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(48, 17);
            this.btn_more.TabIndex = 9;
            this.btn_more.Text = "+더보기";
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_login.Location = new System.Drawing.Point(571, 9);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(41, 17);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "로그인";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.BackColor = System.Drawing.Color.Black;
            this.label_userid.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_userid.ForeColor = System.Drawing.Color.White;
            this.label_userid.Location = new System.Drawing.Point(574, 13);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(0, 17);
            this.label_userid.TabIndex = 15;
            this.label_userid.Visible = false;
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_logout.Location = new System.Drawing.Point(502, 9);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(52, 17);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "로그아웃";
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_no1
            // 
            this.lb_no1.AutoSize = true;
            this.lb_no1.BackColor = System.Drawing.Color.Transparent;
            this.lb_no1.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_no1.ForeColor = System.Drawing.Color.DimGray;
            this.lb_no1.Location = new System.Drawing.Point(47, 125);
            this.lb_no1.Name = "lb_no1";
            this.lb_no1.Size = new System.Drawing.Size(51, 16);
            this.lb_no1.TabIndex = 16;
            this.lb_no1.Text = "예매율 : ";
            // 
            // lb_no2
            // 
            this.lb_no2.AutoSize = true;
            this.lb_no2.BackColor = System.Drawing.Color.Transparent;
            this.lb_no2.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_no2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_no2.Location = new System.Drawing.Point(258, 125);
            this.lb_no2.Name = "lb_no2";
            this.lb_no2.Size = new System.Drawing.Size(51, 16);
            this.lb_no2.TabIndex = 16;
            this.lb_no2.Text = "예매율 : ";
            // 
            // lb_no3
            // 
            this.lb_no3.AutoSize = true;
            this.lb_no3.BackColor = System.Drawing.Color.Transparent;
            this.lb_no3.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_no3.ForeColor = System.Drawing.Color.DimGray;
            this.lb_no3.Location = new System.Drawing.Point(458, 125);
            this.lb_no3.Name = "lb_no3";
            this.lb_no3.Size = new System.Drawing.Size(51, 16);
            this.lb_no3.TabIndex = 16;
            this.lb_no3.Text = "예매율 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bgimg;
            this.ClientSize = new System.Drawing.Size(639, 616);
            this.Controls.Add(this.lb_no3);
            this.Controls.Add(this.lb_no2);
            this.Controls.Add(this.lb_no1);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.btn_ticketing);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no3);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.btn_myCGV);
            this.Controls.Add(this.btn_ticket);
            this.Controls.Add(this.btn_movie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_movie;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_myCGV;
        private System.Windows.Forms.PictureBox no1;
        private System.Windows.Forms.PictureBox no2;
        private System.Windows.Forms.PictureBox no3;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ticketing;
        private System.Windows.Forms.Label btn_more;
        private System.Windows.Forms.Label btn_login;
        private System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.Label btn_logout;
        private System.Windows.Forms.Label lb_no1;
        private System.Windows.Forms.Label lb_no2;
        private System.Windows.Forms.Label lb_no3;
    }
}

