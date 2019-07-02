namespace WindowsFormsApp4
{
    partial class SeatsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_teen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_default = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_old = new System.Windows.Forms.NumericUpDown();
            this.lb_theater = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_remain = new System.Windows.Forms.Label();
            this.lb_auditorium = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_seoul = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pn_daejeon = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pn_daegu = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_payment = new System.Windows.Forms.Button();
            this.lb_details = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_cost = new System.Windows.Forms.Label();
            this.moviePoster = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_default)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_old)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_seoul.SuspendLayout();
            this.pn_daejeon.SuspendLayout();
            this.pn_daegu.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("한컴 백제 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "인원 / 좌석";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 45);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "일반";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "청소년";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "우대";
            // 
            // numericUpDown_teen
            // 
            this.numericUpDown_teen.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown_teen.Location = new System.Drawing.Point(93, 49);
            this.numericUpDown_teen.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_teen.Name = "numericUpDown_teen";
            this.numericUpDown_teen.Size = new System.Drawing.Size(34, 25);
            this.numericUpDown_teen.TabIndex = 51;
            this.numericUpDown_teen.ValueChanged += new System.EventHandler(this.teen_numericUpDown);
            // 
            // numericUpDown_default
            // 
            this.numericUpDown_default.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown_default.Location = new System.Drawing.Point(93, 14);
            this.numericUpDown_default.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_default.Name = "numericUpDown_default";
            this.numericUpDown_default.Size = new System.Drawing.Size(34, 25);
            this.numericUpDown_default.TabIndex = 52;
            this.numericUpDown_default.ValueChanged += new System.EventHandler(this.default_numericUpDown);
            // 
            // numericUpDown_old
            // 
            this.numericUpDown_old.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown_old.Location = new System.Drawing.Point(93, 85);
            this.numericUpDown_old.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_old.Name = "numericUpDown_old";
            this.numericUpDown_old.Size = new System.Drawing.Size(34, 25);
            this.numericUpDown_old.TabIndex = 53;
            this.numericUpDown_old.ValueChanged += new System.EventHandler(this.old_numericUpDown);
            // 
            // lb_theater
            // 
            this.lb_theater.AutoSize = true;
            this.lb_theater.Font = new System.Drawing.Font("한컴 백제 M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_theater.Location = new System.Drawing.Point(28, 13);
            this.lb_theater.Name = "lb_theater";
            this.lb_theater.Size = new System.Drawing.Size(35, 20);
            this.lb_theater.TabIndex = 54;
            this.lb_theater.Text = "극장";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.numericUpDown_old);
            this.panel2.Controls.Add(this.numericUpDown_default);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown_teen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-2, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 121);
            this.panel2.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("한컴 백제 M", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(221, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 54;
            this.button1.Text = "관람 할인 안내";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_time);
            this.panel3.Controls.Add(this.lb_theater);
            this.panel3.Controls.Add(this.lb_remain);
            this.panel3.Controls.Add(this.lb_auditorium);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(301, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 121);
            this.panel3.TabIndex = 56;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("한컴 백제 M", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_time.Location = new System.Drawing.Point(26, 63);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(140, 31);
            this.lb_time.TabIndex = 55;
            this.lb_time.Text = "상영시작시간";
            // 
            // lb_remain
            // 
            this.lb_remain.AutoSize = true;
            this.lb_remain.Font = new System.Drawing.Font("한컴 백제 M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_remain.Location = new System.Drawing.Point(229, 13);
            this.lb_remain.Name = "lb_remain";
            this.lb_remain.Size = new System.Drawing.Size(35, 20);
            this.lb_remain.TabIndex = 54;
            this.lb_remain.Text = "여석";
            // 
            // lb_auditorium
            // 
            this.lb_auditorium.AutoSize = true;
            this.lb_auditorium.Font = new System.Drawing.Font("한컴 백제 M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_auditorium.Location = new System.Drawing.Point(120, 13);
            this.lb_auditorium.Name = "lb_auditorium";
            this.lb_auditorium.Size = new System.Drawing.Size(48, 20);
            this.lb_auditorium.TabIndex = 54;
            this.lb_auditorium.Text = "상영관";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("한컴 백제 M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(211, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴 백제 M", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(102, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "|";
            // 
            // pn_seoul
            // 
            this.pn_seoul.Controls.Add(this.label12);
            this.pn_seoul.Controls.Add(this.label11);
            this.pn_seoul.Controls.Add(this.label10);
            this.pn_seoul.Controls.Add(this.label9);
            this.pn_seoul.Controls.Add(this.label8);
            this.pn_seoul.Location = new System.Drawing.Point(34, 204);
            this.pn_seoul.Name = "pn_seoul";
            this.pn_seoul.Size = new System.Drawing.Size(547, 291);
            this.pn_seoul.TabIndex = 59;
            this.pn_seoul.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(38, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 80;
            this.label12.Text = "E";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(38, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 80;
            this.label11.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(37, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 80;
            this.label10.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(38, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(38, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "A";
            // 
            // pn_daejeon
            // 
            this.pn_daejeon.Controls.Add(this.label15);
            this.pn_daejeon.Controls.Add(this.label16);
            this.pn_daejeon.Controls.Add(this.label17);
            this.pn_daejeon.Controls.Add(this.label18);
            this.pn_daejeon.Controls.Add(this.label19);
            this.pn_daejeon.Location = new System.Drawing.Point(19, 216);
            this.pn_daejeon.Name = "pn_daejeon";
            this.pn_daejeon.Size = new System.Drawing.Size(547, 291);
            this.pn_daejeon.TabIndex = 60;
            this.pn_daejeon.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(75, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "E";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(75, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 80;
            this.label16.Text = "D";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(74, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 80;
            this.label17.Text = "C";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(75, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 17);
            this.label18.TabIndex = 80;
            this.label18.Text = "B";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(75, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 80;
            this.label19.Text = "A";
            // 
            // pn_daegu
            // 
            this.pn_daegu.Controls.Add(this.label20);
            this.pn_daegu.Controls.Add(this.label21);
            this.pn_daegu.Controls.Add(this.label22);
            this.pn_daegu.Controls.Add(this.label23);
            this.pn_daegu.Location = new System.Drawing.Point(28, 207);
            this.pn_daegu.Name = "pn_daegu";
            this.pn_daegu.Size = new System.Drawing.Size(547, 291);
            this.pn_daegu.TabIndex = 81;
            this.pn_daegu.Visible = false;
            this.pn_daegu.Click += new System.EventHandler(this.seatsSelected);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(67, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 17);
            this.label20.TabIndex = 80;
            this.label20.Text = "D";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(66, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 17);
            this.label21.TabIndex = 80;
            this.label21.Text = "C";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(67, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 17);
            this.label22.TabIndex = 80;
            this.label22.Text = "B";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("한컴 백제 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(67, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 17);
            this.label23.TabIndex = 80;
            this.label23.Text = "A";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.lb_title);
            this.panel5.Controls.Add(this.lb_cost);
            this.panel5.Controls.Add(this.lb_details);
            this.panel5.Controls.Add(this.btn_payment);
            this.panel5.Controls.Add(this.moviePoster);
            this.panel5.Location = new System.Drawing.Point(-2, 513);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(642, 107);
            this.panel5.TabIndex = 50;
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.Gray;
            this.btn_payment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_payment.FlatAppearance.BorderSize = 3;
            this.btn_payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_payment.Location = new System.Drawing.Point(546, 6);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(83, 85);
            this.btn_payment.TabIndex = 17;
            this.btn_payment.Text = "결제선택";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // lb_details
            // 
            this.lb_details.AutoSize = true;
            this.lb_details.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_details.ForeColor = System.Drawing.Color.White;
            this.lb_details.Location = new System.Drawing.Point(172, 37);
            this.lb_details.Name = "lb_details";
            this.lb_details.Size = new System.Drawing.Size(65, 21);
            this.lb_details.TabIndex = 18;
            this.lb_details.Text = "details";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(172, 6);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(40, 21);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "title";
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Font = new System.Drawing.Font("한컴 백제 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_cost.ForeColor = System.Drawing.Color.White;
            this.lb_cost.Location = new System.Drawing.Point(406, 6);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(45, 21);
            this.lb_cost.TabIndex = 18;
            this.lb_cost.Text = "cost";
            // 
            // moviePoster
            // 
            this.moviePoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moviePoster.Location = new System.Drawing.Point(59, 6);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(69, 85);
            this.moviePoster.TabIndex = 0;
            this.moviePoster.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.hatchedline;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(34, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 27);
            this.panel4.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("한컴 백제 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(232, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "SCREEN";
            // 
            // SeatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 616);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pn_daejeon);
            this.Controls.Add(this.pn_daegu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pn_seoul);
            this.Name = "SeatsForm";
            this.Text = "SeatsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_default)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_old)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pn_seoul.ResumeLayout(false);
            this.pn_seoul.PerformLayout();
            this.pn_daejeon.ResumeLayout(false);
            this.pn_daejeon.PerformLayout();
            this.pn_daegu.ResumeLayout(false);
            this.pn_daegu.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_teen;
        private System.Windows.Forms.NumericUpDown numericUpDown_default;
        private System.Windows.Forms.NumericUpDown numericUpDown_old;
        private System.Windows.Forms.Label lb_theater;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_remain;
        private System.Windows.Forms.Label lb_auditorium;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pn_seoul;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pn_daejeon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pn_daegu;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox moviePoster;
        private System.Windows.Forms.Label lb_details;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_cost;
    }
}