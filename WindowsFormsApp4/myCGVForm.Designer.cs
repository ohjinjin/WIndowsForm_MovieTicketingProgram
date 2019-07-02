namespace WindowsFormsApp4
{
    partial class MyCGVForm
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_movie = new System.Windows.Forms.Button();
            this.btn_myCGV = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bannerLine;
            this.pictureBox3.Location = new System.Drawing.Point(0, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(639, 10);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.bannerLine;
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
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
            this.banner.Location = new System.Drawing.Point(0, 8);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(639, 133);
            this.banner.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.mycgv_banner;
            this.pictureBox1.Location = new System.Drawing.Point(197, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 76);
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
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
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
            this.btn_myCGV.TabIndex = 11;
            this.btn_myCGV.Text = "My CGV";
            this.btn_myCGV.UseVisualStyleBackColor = false;
            this.btn_myCGV.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(193, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 64);
            this.panel4.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 백제 M", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "예매 확인";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 336);
            this.panel2.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 백제 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // MyCGVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.banner);
            this.Name = "MyCGVForm";
            this.Text = "myCGVForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel banner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_movie;
        private System.Windows.Forms.Button btn_myCGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}