using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace WindowsFormsApp4
{
    public partial class SeatsForm : Form
    {
        int totalNum = 0;
        string[] finalDatas;
        string[] seatAvailableLists;
        string selectedMovie = "";
        string selectedTheater = "";
        string selectedAudi = "";
        string selectedTime = "";
        string selectedIdx = "1";
        string pathSeoul = @"..\..\seoulSeats";
        string pathDaejeon = @"..\..\daejeonSeats";
        string pathDaegu = @"..\..\daeguSeats";
        //string user = "";
        System.Windows.Forms.Button[] BtnLists_seoul = new Button[50];
        System.Windows.Forms.Button[] BtnLists_daejeon = new Button[40];
        System.Windows.Forms.Button[] BtnLists_daegu = new Button[40];
        bool isSeoul = false;
        bool isDaejeon = false;
        bool isDaegu = false;
        int tobebookedNum = 0;
        int bookedNum = 0;
        int totalCosts = 0;
        static int margin = 30;
        static int btnsize = 35;
        string[] alphabet = { "A", "B", "C", "D", "E", "F" };

        public SeatsForm(string[] inputDatas)
        {
            finalDatas = new string[9]; // 기존 5개에 금액, 좌석, 인원정보-성인/청소년/우대, 좌석이진정보
            //this.user = user;
            finalDatas[0] = selectedMovie = inputDatas[0];
            finalDatas[1] = selectedTheater = inputDatas[1];
            finalDatas[2] = selectedAudi = inputDatas[2];
            finalDatas[3] = selectedTime = inputDatas[3];
            finalDatas[4] = selectedIdx = inputDatas[4];
            InitializeComponent();
            lb_theater.Text = selectedTheater + " CGV";
            lb_auditorium.Text = selectedAudi;
            lb_time.Text = selectedTime;
            lb_title.Text = "< " +selectedMovie + " >";
            lb_details.Text = "극장   : " + selectedTheater + "\n상영관   : " + selectedAudi + "\n일시    : " + selectedTime;
            lb_cost.Text = totalCosts + " 원";
            Assembly assembly = Assembly.GetExecutingAssembly();
            string strBaseName = assembly.GetName().Name + "." + "Properties.Resources";
            ResourceManager rm = new ResourceManager(strBaseName, Assembly.GetExecutingAssembly());
            //if (selectedMovie.Equals("))
            moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            moviePoster.Image = rm.GetObject(selectedMovie) as Image;
            rm.ReleaseAllResources();
            //moviePoster.Image = global::WindowsFormsApp4.Properties.Resources

            // 추가적 예외처리!!!!!!!!!!!!!!!!!!!!!
            // 극장별 좌석배치도가 다르게 보이도록
            if (selectedTheater.Equals("서울"))
            {
                isSeoul = true;
                //isDaejeon = false;
                //isDaegu = false;
                pathSeoul += selectedIdx + ".txt";
                string rawTexts = System.IO.File.ReadAllText(pathSeoul, Encoding.Default);
                seatAvailableLists = rawTexts.Split(' ');
                
                pn_seoul.Visible = true;
                for (int i = 0; i< BtnLists_seoul.Length; i++)
                {
                    BtnLists_seoul[i] = new Button();
                    if (0 <= i && i < 20)
                    {
                        BtnLists_seoul[i].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    }
                    else if (20 <= i && i < 40)
                    {
                        BtnLists_seoul[i].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        BtnLists_seoul[i].FlatAppearance.BorderColor = System.Drawing.Color.Red;
                    }
                    BtnLists_seoul[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BtnLists_seoul[i].Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    BtnLists_seoul[i].Location = new System.Drawing.Point(margin * 3 + i%10*40, margin + i/10*40);
                    BtnLists_seoul[i].Size = new System.Drawing.Size(btnsize, btnsize);
                    BtnLists_seoul[i].Text = i%10+"";
                    BtnLists_seoul[i].UseVisualStyleBackColor = true;
                    BtnLists_seoul[i].Click += seatsSelected;
                    if (seatAvailableLists[i].Equals("1"))
                    {
                        BtnLists_seoul[i].BackColor = System.Drawing.Color.DimGray;
                    }
                    /*else
                    {
                        BtnLists_seoul[i].MouseHover += BtnLists_seoul[i].BackColor = System.Drawing.Color.Red;
                    }*/

                    this.pn_seoul.Controls.Add(BtnLists_seoul[i]);

                }
                int currRemain = 0;
                for (int i =0; i < seatAvailableLists.Length; i++)
                {
                    if (seatAvailableLists[i].Equals("1"))
                    {
                        currRemain++;
                    }
                }
                lb_remain.Text = (seatAvailableLists.Length - currRemain) + "/" + seatAvailableLists.Length + "석";
            }

            else if (selectedTheater.Equals("대전"))
            {
                //isSeoul = false;
                isDaejeon = true;
                //isDaegu = false;
                pathDaejeon += selectedIdx + ".txt";
                string rawTexts = System.IO.File.ReadAllText(pathDaejeon, Encoding.Default);
                seatAvailableLists = rawTexts.Split(' ');
                pn_daejeon.Visible = true;
                for (int i = 0; i < BtnLists_daejeon.Length; i++)
                {
                    BtnLists_daejeon[i] = new Button();
                    if (0 <= i && i < 8)
                    {
                        BtnLists_daejeon[i].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    }
                    else if (8 <= i && i < 16)
                    {
                        BtnLists_daejeon[i].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        BtnLists_daejeon[i].FlatAppearance.BorderColor = System.Drawing.Color.Red;
                    }
                    BtnLists_daejeon[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BtnLists_daejeon[i].Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    BtnLists_daejeon[i].Location = new System.Drawing.Point(margin * 4 + i % 8 * 40, margin + i / 8 * 40);
                    BtnLists_daejeon[i].Size = new System.Drawing.Size(btnsize, btnsize);
                    BtnLists_daejeon[i].Text = i%8 + "";
                    BtnLists_daejeon[i].UseVisualStyleBackColor = true;
                    BtnLists_daejeon[i].Click += seatsSelected;
                    if (seatAvailableLists[i].Equals("1"))
                    {
                        BtnLists_daejeon[i].BackColor = System.Drawing.Color.DimGray;
                    }
                    this.pn_daejeon.Controls.Add(BtnLists_daejeon[i]);
                }
            }
            //  대구
            else
            {
                //isSeoul = false;
                //isDaejeon = false;
                isDaegu = true;
                pathDaegu += selectedIdx + ".txt";
                string rawTexts = System.IO.File.ReadAllText(pathDaegu, Encoding.Default);
                seatAvailableLists = rawTexts.Split(' ');
                pn_daegu.Visible = true;
                for (int i = 0; i < BtnLists_daegu.Length; i++)
                {
                    BtnLists_daegu[i] = new Button();
                    if (0 <= i && i < 10)
                    {
                        BtnLists_daegu[i].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    }
                    else if (10 <= i && i < 30)
                    {
                        BtnLists_daegu[i].FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        BtnLists_daegu[i].FlatAppearance.BorderColor = System.Drawing.Color.Red;
                    }
                    BtnLists_daegu[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BtnLists_daegu[i].Font = new System.Drawing.Font("한컴 백제 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    BtnLists_daegu[i].Location = new System.Drawing.Point(margin * 3 + i % 10 * 40, margin + i / 10 * 40);
                    BtnLists_daegu[i].Size = new System.Drawing.Size(btnsize, btnsize);
                    BtnLists_daegu[i].Text = i % 10 + "";
                    BtnLists_daegu[i].UseVisualStyleBackColor = true;
                    BtnLists_daegu[i].Click += seatsSelected;
                    if (seatAvailableLists[i].Equals("1"))
                    {
                        BtnLists_daegu[i].BackColor = System.Drawing.Color.DimGray;
                    }
                    this.pn_daegu.Controls.Add(BtnLists_daegu[i]);
                }
            }
        }

        private void default_numericUpDown(object sender, EventArgs e)
        {
            // 추가적 예외처리!!!!!!!!!!!!!!!!!!!!!
            int tmpNum = (int)(numericUpDown_default.Value + numericUpDown_teen.Value + numericUpDown_old.Value);
            if (tmpNum > 5)
            {
                MessageBox.Show("최대 5명의 인원까지 예매가 가능합니다.");
                numericUpDown_default.Value = 0;
                totalNum = (int)(numericUpDown_default.Value + numericUpDown_teen.Value + numericUpDown_old.Value);
            }
            else if (tmpNum < bookedNum)
            {
                MessageBox.Show("선택좌석 수 보다 인원이 적습니다.");
                numericUpDown_default.Value += 1;
            }
            else
            {
                totalNum = tmpNum;
                tobebookedNum = totalNum - bookedNum;
                totalCosts = 10000*(int)(numericUpDown_default.Value) + 8000*(int)(numericUpDown_teen.Value) + 5000*(int)(numericUpDown_old.Value);
                lb_cost.Text = totalCosts + " 원";
            }
        }

        private void teen_numericUpDown(object sender, EventArgs e)
        {
            // 추가적 예외처리!!!!!!!!!!!!!!!!!!!!!
            int tmpNum = (int)(numericUpDown_default.Value + numericUpDown_teen.Value + numericUpDown_old.Value);
            if (tmpNum > 5)
            {
                MessageBox.Show("최대 5명의 인원까지 예매가 가능합니다.");
                numericUpDown_teen.Value = 0;
                totalNum = (int)(numericUpDown_default.Value + numericUpDown_teen.Value + numericUpDown_old.Value);
            }
            else if (tmpNum < bookedNum)
            {
                MessageBox.Show("선택좌석 수 보다 인원이 적습니다.");
                numericUpDown_teen.Value += 1;
            }
            else
            {
                totalNum = tmpNum;
                tobebookedNum = totalNum - bookedNum;
                totalCosts = 10000 * (int)(numericUpDown_default.Value) + 8000 * (int)(numericUpDown_teen.Value) + 5000 * (int)(numericUpDown_old.Value);
                lb_cost.Text = totalCosts + " 원";
            }
        }

        private void old_numericUpDown(object sender, EventArgs e)
        {
            // 추가적 예외처리!!!!!!!!!!!!!!!!!!!!!
            int tmpNum = (int)(numericUpDown_default.Value + numericUpDown_teen.Value + numericUpDown_old.Value);
            if (tmpNum > 5)
            {
                MessageBox.Show("최대 5명의 인원까지 예매가 가능합니다.");
                numericUpDown_old.Value = 0;
                totalNum = (int)(numericUpDown_default.Value + numericUpDown_teen.Value + numericUpDown_old.Value);
            }
            else if (tmpNum < bookedNum)
            {
                MessageBox.Show("선택좌석 수 보다 인원이 적습니다.");
                numericUpDown_old.Value += 1;
            }
            else
            {
                totalNum = tmpNum;
                tobebookedNum = totalNum - bookedNum;
                totalCosts = 10000 * (int)(numericUpDown_default.Value) + 8000 * (int)(numericUpDown_teen.Value) + 5000 * (int)(numericUpDown_old.Value);
                lb_cost.Text = totalCosts + " 원";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("할인 안내\n장애우대할인 : 현장에서 복지카드를 소지한 장애인\n청소년할인 : 만 18세 미만을 증명할 수 있는 신분증 제시");
        }

        private void seatsSelected(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int totalSeats = 0;

            //MessageBox.Show(tobebookedNum + "명남음"); 
            if (tobebookedNum > 0)
            {
                int delta = 1;
                // 한명 이상일 경우 2명씩 선택하도록
                if (tobebookedNum > 1)
                {
                    delta = 2;
                }
                if (isSeoul)
                {
                    for (int i = 0; i < BtnLists_seoul.Length; i++)
                    {
                        // 입력받은 좌석이
                        if (btn.Equals(BtnLists_seoul[i])) {
                            // 이미 선택된 좌석일 경우
                            if (seatAvailableLists[i].Equals("1"))
                            {
                                MessageBox.Show("이미 예약된 좌석입니다. 다른 좌석을 선택하세요");
                                return;
                            }

                            else if (BtnLists_seoul[i].BackColor == System.Drawing.Color.Red)
                            {
                                if (MessageBox.Show("이미 선택한 좌석입니다. 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    BtnLists_seoul[i].BackColor = System.Drawing.Color.White;
                                    if ((!(i % 10 + 1 >= 10)) && BtnLists_seoul[i + 1].BackColor == System.Drawing.Color.Red)
                                    {
                                        BtnLists_seoul[i + 1].BackColor = System.Drawing.Color.White;
                                        tobebookedNum += 2;
                                        break;
                                    }
                                    else if ((!(i % 10 - 1 < 0)) && BtnLists_seoul[i - 1].BackColor == System.Drawing.Color.Red)
                                    {
                                        BtnLists_seoul[i - 1].BackColor = System.Drawing.Color.White;
                                        tobebookedNum += 2;
                                        break;
                                    }
                                    else
                                    {
                                        tobebookedNum += 1;
                                        break;
                                    }
                                }
                            }

                            else
                            {
                                if (delta == 2)
                                {
                                    // 오른쪽으로 먼저 선택하도록, 현재 자리가 오른쪽 끝자리가 아니면서 오른쪽자리가 이미 예약된곳도 아니고 이미 선택한 곳이 아니라면
                                    if ((!(i % 10 + 1 >= 10)) && seatAvailableLists[i+1].Equals("0") && BtnLists_seoul[i + 1].BackColor != System.Drawing.Color.Red)
                                    {
                                        BtnLists_seoul[i].BackColor = System.Drawing.Color.Red;
                                        BtnLists_seoul[i+1].BackColor = System.Drawing.Color.Red;
                                        tobebookedNum -= delta;
                                        bookedNum += delta;
                                        break;
                                    }
                                    // 안되면 왼쪽
                                    else if ((!(i % 10 -1 < 0)) && seatAvailableLists[i - 1].Equals("0") && BtnLists_seoul[i - 1].BackColor != System.Drawing.Color.Red)
                                    {
                                        BtnLists_seoul[i].BackColor = System.Drawing.Color.Red;
                                        BtnLists_seoul[i - 1].BackColor = System.Drawing.Color.Red;
                                        tobebookedNum -= delta;
                                        bookedNum += delta;
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("이미 예약된 좌석입니다. 다른 좌석을 선택하세요");
                                        return;
                                    }
                                }
                                else
                                {
                                    BtnLists_seoul[i].BackColor = System.Drawing.Color.Red;
                                    tobebookedNum -= delta;
                                    bookedNum += delta;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if(isDaejeon){
                    for (int i = 0; i < BtnLists_daejeon.Length; i++)
                    {
                        // 입력받은 좌석이
                        if (btn.Equals(BtnLists_daejeon[i]))
                        {
                            // 이미 선택된 좌석일 경우
                            if (seatAvailableLists[i].Equals("1"))
                            {
                                MessageBox.Show("이미 예약된 좌석입니다. 다른 좌석을 선택하세요");
                                return;
                            }

                            else if (BtnLists_daejeon[i].BackColor == System.Drawing.Color.Red)
                            {
                                if (MessageBox.Show("이미 선택한 좌석입니다. 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    BtnLists_daejeon[i].BackColor = System.Drawing.Color.White;
                                    if ((!(i % 10 + 1 >= 10)) && BtnLists_daejeon[i + 1].BackColor == System.Drawing.Color.Red)
                                    {
                                        BtnLists_daejeon[i + 1].BackColor = System.Drawing.Color.White;
                                        tobebookedNum += 2;
                                        break;
                                    }
                                    else if ((!(i % 10 - 1 < 0)) && BtnLists_daejeon[i - 1].BackColor == System.Drawing.Color.Red)
                                    {
                                        BtnLists_daejeon[i - 1].BackColor = System.Drawing.Color.White;
                                        tobebookedNum += 2;
                                        break;
                                    }
                                    else
                                    {
                                        tobebookedNum += 1;
                                        break;
                                    }
                                }
                            }

                            else
                            {
                                if (delta == 2)
                                {
                                    // 오른쪽으로 먼저 선택하도록, 현재 자리가 오른쪽 끝자리가 아니면서 오른쪽자리가 이미 예약된곳도 아니고 이미 선택한 곳이 아니라면
                                    if ((!(i % 10 + 1 >= 10)) && seatAvailableLists[i + 1].Equals("0") && BtnLists_daejeon[i + 1].BackColor != System.Drawing.Color.Red)
                                    {
                                        BtnLists_daejeon[i].BackColor = System.Drawing.Color.Red;
                                        BtnLists_daejeon[i + 1].BackColor = System.Drawing.Color.Red;
                                        tobebookedNum -= delta;
                                        bookedNum += delta;
                                        break;
                                    }
                                    // 안되면 왼쪽
                                    else if ((!(i % 10 - 1 < 0)) && seatAvailableLists[i - 1].Equals("0") && BtnLists_daejeon[i - 1].BackColor != System.Drawing.Color.Red)
                                    {
                                        BtnLists_daejeon[i].BackColor = System.Drawing.Color.Red;
                                        BtnLists_daejeon[i - 1].BackColor = System.Drawing.Color.Red;
                                        tobebookedNum -= delta;
                                        bookedNum += delta;
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("이미 예약된 좌석입니다. 다른 좌석을 선택하세요");
                                        return;
                                    }
                                }
                                else
                                {
                                    BtnLists_daejeon[i].BackColor = System.Drawing.Color.Red;
                                    tobebookedNum -= delta;
                                    bookedNum += delta;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < BtnLists_daegu.Length; i++)
                    {
                        // 입력받은 좌석이
                        if (btn.Equals(BtnLists_daegu[i]))
                        {
                            // 이미 선택된 좌석일 경우
                            if (seatAvailableLists[i].Equals("1"))
                            {
                                MessageBox.Show("이미 예약된 좌석입니다. 다른 좌석을 선택하세요");
                                return;
                            }

                            else if (BtnLists_daegu[i].BackColor == System.Drawing.Color.Red)
                            {
                                if (MessageBox.Show("이미 선택한 좌석입니다. 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    BtnLists_daegu[i].BackColor = System.Drawing.Color.White;
                                    if ((!(i % 10 + 1 >= 10)) && BtnLists_daegu[i + 1].BackColor == System.Drawing.Color.Red)
                                    {
                                        BtnLists_daegu[i + 1].BackColor = System.Drawing.Color.White;
                                        tobebookedNum += 2;
                                        break;
                                    }
                                    else if ((!(i % 10 - 1 < 0)) && BtnLists_daegu[i - 1].BackColor == System.Drawing.Color.Red)
                                    {
                                        BtnLists_daegu[i - 1].BackColor = System.Drawing.Color.White;
                                        tobebookedNum += 2;
                                        break;
                                    }
                                    else
                                    {
                                        tobebookedNum += 1;
                                        break;
                                    }
                                }
                            }

                            else
                            {
                                if (delta == 2)
                                {
                                    // 오른쪽으로 먼저 선택하도록, 현재 자리가 오른쪽 끝자리가 아니면서 오른쪽자리가 이미 예약된곳도 아니고 이미 선택한 곳이 아니라면
                                    if ((!(i % 10 + 1 >= 10)) && seatAvailableLists[i + 1].Equals("0") && BtnLists_daegu[i + 1].BackColor != System.Drawing.Color.Red)
                                    {
                                        BtnLists_daegu[i].BackColor = System.Drawing.Color.Red;
                                        BtnLists_daegu[i + 1].BackColor = System.Drawing.Color.Red;
                                        tobebookedNum -= delta;
                                        bookedNum += delta;
                                        break;
                                    }
                                    // 안되면 왼쪽
                                    else if ((!(i % 10 - 1 < 0)) && seatAvailableLists[i - 1].Equals("0") && BtnLists_daegu[i - 1].BackColor != System.Drawing.Color.Red)
                                    {
                                        BtnLists_daegu[i].BackColor = System.Drawing.Color.Red;
                                        BtnLists_daegu[i - 1].BackColor = System.Drawing.Color.Red;
                                        tobebookedNum -= delta;
                                        bookedNum += delta;
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("이미 예약된 좌석입니다. 다른 좌석을 선택하세요");
                                        return;
                                    }
                                }
                                else
                                {
                                    BtnLists_daegu[i].BackColor = System.Drawing.Color.Red;
                                    tobebookedNum -= delta;
                                    bookedNum += delta;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            
            else if (tobebookedNum == 0)
            {
                if (isSeoul)
                {
                    for (int i = 0; i < BtnLists_seoul.Length; i++)
                    {
                        if (btn.Equals(BtnLists_seoul[i]) && BtnLists_seoul[i].BackColor == System.Drawing.Color.Red)
                        {
                            if (MessageBox.Show("이미 선택한 좌석입니다. 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                BtnLists_seoul[i].BackColor = System.Drawing.Color.White;
                                if ((!(i % 10 + 1 >= 10)) && BtnLists_seoul[i + 1].BackColor == System.Drawing.Color.Red)
                                {
                                    BtnLists_seoul[i + 1].BackColor = System.Drawing.Color.White;
                                    tobebookedNum += 2;
                                    bookedNum -= 2;
                                    break;
                                }
                                else if ((!(i % 10 - 1 < 0)) && BtnLists_seoul[i - 1].BackColor == System.Drawing.Color.Red)
                                {
                                    BtnLists_seoul[i - 1].BackColor = System.Drawing.Color.White;
                                    tobebookedNum += 2;
                                    bookedNum -= 2;
                                    break;
                                }
                                else
                                {
                                    tobebookedNum += 1;
                                    bookedNum -= 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (isDaejeon)
                {
                    for (int i = 0; i < BtnLists_daejeon.Length; i++)
                    {
                        if (btn.Equals(BtnLists_daejeon[i]) && BtnLists_daejeon[i].BackColor == System.Drawing.Color.Red)
                        {
                            if (MessageBox.Show("이미 선택한 좌석입니다. 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                BtnLists_daejeon[i].BackColor = System.Drawing.Color.White;
                                if ((!(i % 10 + 1 >= 10)) && BtnLists_daejeon[i + 1].BackColor == System.Drawing.Color.Red)
                                {
                                    BtnLists_daejeon[i + 1].BackColor = System.Drawing.Color.White;
                                    tobebookedNum += 2;
                                    bookedNum -= 2;
                                    break;
                                }
                                else if ((!(i % 10 - 1 < 0)) && BtnLists_daejeon[i - 1].BackColor == System.Drawing.Color.Red)
                                {
                                    BtnLists_daejeon[i - 1].BackColor = System.Drawing.Color.White;
                                    tobebookedNum += 2;
                                    bookedNum -= 2;
                                    break;
                                }
                                else
                                {
                                    tobebookedNum += 1;
                                    bookedNum -= 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (isDaegu)
                {
                    for (int i = 0; i < BtnLists_daegu.Length; i++)
                    {
                        if (btn.Equals(BtnLists_daegu[i]) && BtnLists_daegu[i].BackColor == System.Drawing.Color.Red)
                        {
                            if (MessageBox.Show("이미 선택한 좌석입니다. 지우시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                BtnLists_daegu[i].BackColor = System.Drawing.Color.White;
                                if ((!(i % 10 + 1 >= 10)) && BtnLists_daegu[i + 1].BackColor == System.Drawing.Color.Red)
                                {
                                    BtnLists_daegu[i + 1].BackColor = System.Drawing.Color.White;
                                    tobebookedNum += 2;
                                    bookedNum -= 2;
                                    break;
                                }
                                else if ((!(i % 10 - 1 < 0)) && BtnLists_daegu[i - 1].BackColor == System.Drawing.Color.Red)
                                {
                                    BtnLists_daegu[i - 1].BackColor = System.Drawing.Color.White;
                                    tobebookedNum += 2;
                                    bookedNum -= 2;
                                    break;
                                }
                                else
                                {
                                    tobebookedNum += 1;
                                    bookedNum -= 2;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("인원 "+ tobebookedNum + "명 선택완료");
                    return;
                }
            }
            //if ()
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            finalDatas[5] = totalCosts + "";

            if (isSeoul)
            {
                for (int i = 0; i < BtnLists_seoul.Length; i++)
                {
                    if (BtnLists_seoul[i].BackColor == System.Drawing.Color.Red)
                    {
                        finalDatas[6] += alphabet[i / 10] + i % 10 + " ";
                        seatAvailableLists[i] = "1";
                    }
                }
            }
            else if (isDaejeon)
            {
                for (int i = 0; i < BtnLists_daejeon.Length; i++)
                {
                    if (BtnLists_daejeon[i].BackColor == System.Drawing.Color.Red)
                    {
                        finalDatas[6] += alphabet[i / 10] + i % 10 + " ";
                        seatAvailableLists[i] = "1";
                    }
                }
            }
            else
            {
                for (int i = 0; i < BtnLists_daegu.Length; i++)
                {
                    if (BtnLists_daegu[i].BackColor == System.Drawing.Color.Red)
                    {
                        finalDatas[6] += alphabet[i / 10] + i % 10 + " ";
                        seatAvailableLists[i] = "1";
                    }
                }
            }
            
            finalDatas[7] = "일반" + numericUpDown_default.Value + "명/청소년" + numericUpDown_teen.Value + "명/우대" + numericUpDown_old.Value + "명";

            string seatsInfo=seatAvailableLists[0];
            for (int i = 1; i < seatAvailableLists.Length; i++)
            {
                seatsInfo += " " + seatAvailableLists[i];
            }
            finalDatas[8] = seatsInfo;
            // 파일에 보내기
            /*if (isSeoul)
            {
                System.IO.File.AppendAllText(pathSeoul, seatsInfo);
            }
            else if (isDaejeon)
            {
                System.IO.File.AppendAllText(pathSeoul, seatsInfo);
            }
            else
            {
                System.IO.File.AppendAllText(pathSeoul, seatsInfo);
            }*/
            /*string check = "";
            for (int i = 0; i < finalDatas.Length; i++)
            {
                check += finalDatas[i]+"\n";
            }
            MessageBox.Show(check);*/
            PayForm payform = new PayForm(finalDatas);
            payform.Show();

            this.Close();
        }
    }
}
