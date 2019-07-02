using System;
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

    public partial class Form1 : Form
    {
        string path = @"..\..\movieInfo.txt";
        int selectedNum = -1;
        //string user = "";
        string[][] movieLists;

        public Form1()
        {
            InitializeComponent();
            //no1.Image = WindowsFormsApp4.Properties.Resources.no1알라딘;
            // 예매율 표시하기
            string rawTexts = System.IO.File.ReadAllText(path, Encoding.Default);
            string[] tmpLists = rawTexts.Split('$');
            movieLists = new string[tmpLists.Length][];

            for (int i = 0; i < tmpLists.Length; i++)
            {
                movieLists[i] = tmpLists[i].Split('%');
            }

            double tmpdouble = 0.0;
            for (int i = 0; i < movieLists.Length; i++)
            {
                //MessageBox.Show(rawTexts+" " +movieLists[i].Length + "");
                tmpdouble += double.Parse(movieLists[i][2]);
            }

            lb_no1.Text += (double.Parse(movieLists[0][2]) / tmpdouble) + "%";
            lb_no2.Text += (double.Parse(movieLists[1][2]) / tmpdouble) + "%";
            lb_no3.Text += (double.Parse(movieLists[2][2]) / tmpdouble) + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void no1_Click(object sender, EventArgs e)
        {
            selectedNum = 0;
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
            info.Text = "감독 : 가이 리치 / 배우 : 메나 마수드, 윌스미스, 나오미 스콧\n장르 : 가족, 환타지, 어드벤처 / 기본 : 전체, 128분, 미국\n개봉 : 2019.05.23";
            summary.BackColor = Color.Transparent;
            summary.Text = "머나먼 사막 속 신비의 아그라바 왕국의 시대.\n좀도둑 ‘알라딘’은 마법사 ‘자파’의 의뢰로 마법 램프를 찾아 나섰다가\n주인에게 세 가지 소원을 들어주는 지니를 만나게 되고,\n자스민 공주의 마음을 얻으려다 생각도 못했던 모험에 휘말리게 되는데…";
        }

        private void no2_Click(object sender, EventArgs e)
        {
            selectedNum = 1;
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Black;
            info.Text = "감독 : 봉준호 / 프로듀서 : 장영환 / 배우 : 송강호, 이선균, 조여정, 최우식, 박소담, 장혜진\n장르 : 드라마 / 기본 : 15세 이상, 131분, 한국\n개봉 : 2019.05.20";
            summary.BackColor = Color.Transparent;
            summary.Text = "\"폐 끼치고 싶진 않았어요\"\n전원백수로 살 길 막막하지만 사이는 좋은 기택(송강호) 가족.\n장남 기우(최우식)에게 명문대생 친구가 연결시켜 준 고액 과외 자리는 \n모처럼 싹튼 고정수입의 희망이다.\n온 가족의 도움과 기대 속에 박사장(이선균) 집으로 향하는 기우.\n글로벌 IT기업 CEO인 박사장의 저택에 도착하자\n젊고 아름다운 사모님 연교(조여정)가 기우를 맞이한다.\n그러나 이렇게 시작된 두 가족의 만남 뒤로, 걷잡을 수 없는 사건이 기다리고 있었으니…";
        }

        private void no3_Click(object sender, EventArgs e)
        {
            selectedNum = 2;
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Red;
            info.Text = "감독 : F. 게리 그레이 / 배우 : 크리스 헴스워스, 테사 톰슨, 리암 니슨\n장르 : 액션, SF, 코미디 / 기본 : 12세 이상, 115분, 미국\n개봉 : 2019.06.12";
            summary.BackColor = Color.Transparent;
            summary.Text = "이제부터 새로운 시작이야!R U READY?\n자신의 모습을 감추고 오랜 시간 지구를 위협해 온 외계인을 감시하는 MIB 본부.\nMIB 본부에도 변화가 요구되면서 신입요원 에이전트 M(테사 톰슨)이 영입되고\nMIB 에이스 요원 에이전트 H(크리스 헴스워스)가 듀오로 결성 된다!\n그들에겐 MIB 내부의 스파이를 찾아야 하는 전대미문의 미션이 주어지는데…";
        }

        private void ticketing_Click(object sender, EventArgs e)
        {
            //this.Close();
            TicketForm ticketForm = new TicketForm(selectedNum);
            ticketForm.Show();
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void btn_movie_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
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
                btn_login.Visible = false;
                label_userid.Text = pubvar.user;
                label_userid.Visible = true;
                btn_logout.Visible = true;
                btn_myCGV.Visible = true;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            pubvar.user = "";
            label_userid.Visible = false;
            btn_logout.Visible = false;
            btn_login.Visible = true;
            btn_myCGV.Visible = false;
        }

        private void btn_myCGV_Click(object sender, EventArgs e)
        {
            MyCGVForm myCGVForm = new MyCGVForm();
            myCGVForm.Show();
        }
    }
    class pubvar
    {
        public static string user = "";    // 정적필드에 대한 참조시 전역변수로 호출시 #1
    }
}
