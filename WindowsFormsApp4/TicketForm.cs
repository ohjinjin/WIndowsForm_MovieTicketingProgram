using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class TicketForm : Form
    {
        string path = @"..\..\movieInfo.txt";
        string path2 = @"..\..\theaterInfo.txt";
        string pathSeoul = @"..\..\seoulInfo.txt";
        string pathDaejeon = @"..\..\daejeonInfo.txt";
        string pathDaegu = @"..\..\daeguInfo.txt";
        public int value;
        string[][] movieLists;
        string[][] theaterLists;
        string[] regions;
        //string[][] seoulScreeningLists;
        //string[][] daejeonScreeningLists;
        //string[][] daeguScreeningLists;
        string[][][] theaterScreeningLists;
        string selectedMovie = "";
        string selectedTheater = "";
        string selectedAudi = "";
        string selectedTime = "";
        //string user = "";
        string[] finalDatas;

        public TicketForm(int paramVal = -1)
        {
            // 영화에 대한 문자열 처리
            //path =System.IO.Path.GetDirectoryName(path);
            //path = path + "/movieInfo.txt";
            //this.user = user;

            finalDatas = new string[5];
            string rawTexts = System.IO.File.ReadAllText(path, Encoding.Default);
            string[] tmpLists = rawTexts.Split('$');
            movieLists = new string[tmpLists.Length][];

            for (int i = 0; i< tmpLists.Length; i++)
            {
                movieLists[i] = tmpLists[i].Split('%');
            }

            value = paramVal;
            InitializeComponent();
            if (!(pubvar.user.Equals("")))
            {
                btn_myCGV.Visible = true;
            }
            //label1.Text = value + "" + movieLists[0][0];

            // 극장에 대한 문자열 처리
            string rawTexts2 = System.IO.File.ReadAllText(path2, Encoding.Default);
            string[] tmpLists2 = rawTexts2.Split('$');
            theaterLists = new string[tmpLists2.Length][];

            for (int i = 0; i < tmpLists2.Length; i++)
            {
                theaterLists[i] = tmpLists2[i].Split('%');
            }
            regions = theaterLists[0][1].Split('|');
            theaterScreeningLists = new string[regions.Length][][];


            // 서울극장에 대한 문자열 처리
            string rawTextsSeoul = System.IO.File.ReadAllText(pathSeoul, Encoding.Default);
            string[] tmpListsSeoul = rawTextsSeoul.Split('$');
            theaterScreeningLists[0] = new string[tmpListsSeoul.Length][];

            for (int i = 0; i < tmpListsSeoul.Length; i++)
            {
                theaterScreeningLists[0][i] = tmpListsSeoul[i].Split('%');
            }
            //theaterScreeningLists.

            // 대전극장에 대한 문자열 처리
            string rawTextsDaejeon = System.IO.File.ReadAllText(pathDaejeon, Encoding.Default);
            string[] tmpListsDaejeon = rawTextsDaejeon.Split('$');
            theaterScreeningLists[1] = new string[tmpListsDaejeon.Length][];

            for (int i = 0; i < tmpListsDaejeon.Length; i++)
            {
                theaterScreeningLists[1][i] = tmpListsDaejeon[i].Split('%');
            }

            // 대전극장에 대한 문자열 처리
            string rawTextsDaegu = System.IO.File.ReadAllText(pathDaegu, Encoding.Default);
            string[] tmpListsDaegu = rawTextsDaegu.Split('$');
            theaterScreeningLists[2] = new string[tmpListsDaegu.Length][];

            for (int i = 0; i < tmpListsDaegu.Length; i++)
            {
                theaterScreeningLists[2][i] = tmpListsDaegu[i].Split('%');
            }

            // listview에 각 영화 항목 및 이용가 추가
            for (int i = 0; i<movieLists.Length; i++)
            {
                listView1.Items.Add(new ListViewItem(movieLists[i][0]));
                for (int j = 1; j<movieLists[i].Length; j++)
                {
                    listView1.Items[i].SubItems.Add(movieLists[i][j]);
                }
            }
            
            // 영화를 미리선택하고 ticket으로 넘어온 경우 그 영화를 default로 선택해두게
            if (paramVal > -1)
            {
                listView1.Items[value].Selected = true;
                listView1.Select();
            }
        }

        private void btn_movie_Click(object sender, EventArgs e)
        {
            this.Close();
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 mainForm = new Form1();
            //mainForm.Show();
        }

        // 영화 선택하면 그 영화를 상영하는 극장들이 listview2에 뜨도록
        private void listView1_Clicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                selectedMovie = item.Text;
                listView2.Items.Clear();
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;

                //string[] regions = theaterLists[0][1].Split('|');
                for (int i = 1; i < theaterLists.Length; i++)
                {
                    if (theaterLists[i][0].Equals(item.Text))
                    {
                        string[] tmpOX = theaterLists[i][1].Split('|');
                        for (int j = 0; j <regions.Length; j++)
                        {
                            if (tmpOX[j].Equals("O"))
                            {
                                listView2.Items.Add(new ListViewItem(regions[j]));
                            }
                        }
                        break;
                    }
                }
            }
        }

        // 해당 영화에 해당 극장의 시간표가 listview3에 뜨도록
        private void listView2_Clicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                selectedTheater = item.Text;
                listView3.Items.Clear();
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;

                //List<string> auditoriums = new List<string>();
                //Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>();
                //if (item.Index==0)
                //{
                for (int i = 0; i < theaterScreeningLists[Array.IndexOf(regions, selectedTheater)].Length; i++)
                {
                    //MessageBox.Show(Array.IndexOf(regions, selectedTheater)+" " +item.Index+"gg"+theaterScreeningLists[Array.IndexOf(regions, selectedTheater)][i][0] + "gg" + selectedMovie);
                    // 같은 이름의 영화만 나오도록
                    if (theaterScreeningLists[Array.IndexOf(regions,selectedTheater)][i][0].Equals(selectedMovie))
                    {
                        string[] timeLists = theaterScreeningLists[Array.IndexOf(regions, selectedTheater)][i][2].Split('|');
                        for (int j = 0; j <timeLists.Length; j++)
                        {
                            listView3.Items.Add(new ListViewItem(timeLists[j]));
                            //listView3.Items[listView3.Items.Count - 1].Checked = false;
                            listView3.Items[listView3.Items.Count-1].SubItems.Add(theaterScreeningLists[Array.IndexOf(regions, selectedTheater)][i][1]);
                        }
                        break;
                    }
                }

            }
        }

        private void listView3_Clicked(object sender, EventArgs e)
        {
            // 시간 지난거 선택안되게 추가구현할것!
            foreach (ListViewItem item in listView3.SelectedItems)
            {
                //selectedTime = item.Text;
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                selectedTime = subItem[0].Text;
                selectedAudi = subItem[1].Text;
                label1.Text = selectedMovie + "|" + selectedTheater + "|" + selectedAudi + "|" + selectedTime;
                finalDatas[0] = selectedMovie;
                finalDatas[1] = selectedTheater;
                finalDatas[2] = selectedAudi;
                finalDatas[3] = selectedTime;
                finalDatas[4] = (item.Index%3+1)+"";
                //MessageBox.Show(finalDatas[4]);
            }
        }

        private void btn_selectSeats_Click(object sender, EventArgs e)
        {
            // 추가적 예외처리!!!!!!!!!!!!!!!!!!!!!
            if (selectedMovie.Equals("") || selectedTheater.Equals("") || selectedAudi.Equals("") || selectedTime.Equals(""))
            {
                MessageBox.Show("선택항목을 모두 선택하지 않았습니다.");
                return;
            }

            bool isLogin = false;
            // 아직 유저 인증이 안되었다면
            if (pubvar.user.Equals(""))
            {
                bool isJoin = false;
                //LoginForm loginForm = new LoginForm();
                //loginForm.Show();
                using (var loginForm = new LoginForm())
                {
                    //MessageBox.Show("check1");
                    var result = loginForm.ShowDialog();
                    //MessageBox.Show(result);
                    if (result == DialogResult.OK)
                    {
                        pubvar.user = loginForm.ReturnValue;
                        //MessageBox.Show(val + "님");
                        isLogin = true;
                    }
                    // 회원가입 누른경우
                    else if (result == DialogResult.No)
                    {
                        //MessageBox.Show("check");
                        isJoin = true;
                    }
                }

                // 회원가입을 누른 경우
                if (isJoin)
                {
                    this.Close();
                    JoinForm joinForm = new JoinForm();
                    joinForm.Show();
                }

            }
            // 그렇지 않고 이미 인증을 한 경우
            else
            {
                isLogin = true;
            }
            // 로긘에 성공한 경우
            if (isLogin)
            {
                SeatsForm seatsForm = new SeatsForm(finalDatas);
                //MessageBox.Show(finalDatas[4]);
                seatsForm.Show();
            }
        }

        private void btn_myCGV_Click(object sender, EventArgs e)
        {
            MyCGVForm myCGVForm = new MyCGVForm();
            myCGVForm.Show();
            this.Close();
        }
    }
}
