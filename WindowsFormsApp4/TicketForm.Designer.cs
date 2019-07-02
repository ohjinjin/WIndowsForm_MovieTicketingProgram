namespace WindowsFormsApp4
{
    partial class TicketForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.ch_theater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ticketing = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.Panel();
            this.btn_myCGV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_movie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 백제 M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_title,
            this.ch_available});
            this.listView1.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.Location = new System.Drawing.Point(5, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 291);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_Clicked);
            // 
            // ch_title
            // 
            this.ch_title.Text = "제목";
            this.ch_title.Width = 120;
            // 
            // ch_available
            // 
            this.ch_available.Text = "이용가";
            this.ch_available.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_available.Width = 80;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_theater});
            this.listView2.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView2.Location = new System.Drawing.Point(211, 158);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(200, 292);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_Clicked);
            // 
            // ch_theater
            // 
            this.ch_theater.Text = "극장";
            this.ch_theater.Width = 200;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView3.Font = new System.Drawing.Font("한컴 백제 M", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView3.Location = new System.Drawing.Point(417, 158);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(200, 292);
            this.listView3.TabIndex = 6;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_Clicked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상영시작시간";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "상영관";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
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
            this.btn_ticketing.Location = new System.Drawing.Point(544, 573);
            this.btn_ticketing.Name = "btn_ticketing";
            this.btn_ticketing.Size = new System.Drawing.Size(83, 31);
            this.btn_ticketing.TabIndex = 16;
            this.btn_ticketing.Text = "좌석선택";
            this.btn_ticketing.UseVisualStyleBackColor = false;
            this.btn_ticketing.Click += new System.EventHandler(this.btn_selectSeats_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bannerLine;
            this.pictureBox3.Location = new System.Drawing.Point(0, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 10);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bannerLine;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(639, 10);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // banner
            // 
            this.banner.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bgimg;
            this.banner.Controls.Add(this.btn_myCGV);
            this.banner.Controls.Add(this.pictureBox1);
            this.banner.Controls.Add(this.btn_ticket);
            this.banner.Controls.Add(this.btn_home);
            this.banner.Controls.Add(this.btn_movie);
            this.banner.Location = new System.Drawing.Point(0, 12);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(639, 133);
            this.banner.TabIndex = 2;
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
            this.btn_myCGV.Location = new System.Drawing.Point(359, 90);
            this.btn_myCGV.Name = "btn_myCGV";
            this.btn_myCGV.Size = new System.Drawing.Size(91, 34);
            this.btn_myCGV.TabIndex = 10;
            this.btn_myCGV.Text = "My CGV";
            this.btn_myCGV.UseVisualStyleBackColor = false;
            this.btn_myCGV.Visible = false;
            this.btn_myCGV.Click += new System.EventHandler(this.btn_myCGV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.ticket_banner;
            this.pictureBox1.Location = new System.Drawing.Point(196, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 79);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.btn_ticket.Location = new System.Drawing.Point(278, 89);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.Size = new System.Drawing.Size(75, 34);
            this.btn_ticket.TabIndex = 9;
            this.btn_ticket.Text = "예매";
            this.btn_ticket.UseVisualStyleBackColor = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Image = global::WindowsFormsApp4.Properties.Resources.logo;
            this.btn_home.Location = new System.Drawing.Point(5, 30);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(160, 75);
            this.btn_home.TabIndex = 6;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
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
            this.btn_movie.Location = new System.Drawing.Point(197, 89);
            this.btn_movie.Name = "btn_movie";
            this.btn_movie.Size = new System.Drawing.Size(75, 34);
            this.btn_movie.TabIndex = 8;
            this.btn_movie.Text = "영화";
            this.btn_movie.UseVisualStyleBackColor = false;
            this.btn_movie.Click += new System.EventHandler(this.btn_movie_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ticketing);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.banner);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel banner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_movie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ch_title;
        private System.Windows.Forms.ColumnHeader ch_available;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader ch_theater;
        private System.Windows.Forms.Button btn_ticketing;
        private System.Windows.Forms.Button btn_myCGV;
    }
}