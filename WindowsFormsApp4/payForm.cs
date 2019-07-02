using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class PayForm : Form
    {
        string selectedMovie = "";
        string selectedTheater = "";
        string selectedAudi = "";
        string selectedTime = "";
        string selectedIdx = "1";
        double totalCosts = 0;
        string[] finalDatas;
        string path = @"..\..\movieInfo.txt";
        string pathSeoul = @"..\..\seoulSeats";
        string pathDaejeon = @"..\..\daejeonSeats";
        string pathDaegu = @"..\..\daeguSeats";
        string[][] movieLists;

        public PayForm(string[] inputDatas)
        {
            InitializeComponent();

            string rawTexts = System.IO.File.ReadAllText(path, Encoding.Default);
            string[] tmpLists = rawTexts.Split('$');
            movieLists = new string[tmpLists.Length][];

            for (int i = 0; i < tmpLists.Length; i++)
            {
                movieLists[i] = tmpLists[i].Split('%');
            }

            /*for (int i =0; i < inputDatas.Length; i++)
            {
                label1.Text += inputDatas[i]+"\n";

            }*/
            finalDatas = new string[11]; // 기존 5개에 금액, 좌석, 인원정보-성인/청소년/우대, 좌석이진정보, 할인적용금액, 결제수단정보
            for (int i = 0; i < inputDatas.Length; i++)
            {
                finalDatas[i] = inputDatas[i];
            }
            selectedMovie = inputDatas[0];
            selectedTheater = inputDatas[1];
            selectedAudi = inputDatas[2];
            selectedTime = inputDatas[3];
            selectedIdx = inputDatas[4];
            totalCosts = int.Parse(inputDatas[5]);
            lb_title.Text = "< " + selectedMovie + " >";
            lb_details.Text = "극장   : " + selectedTheater + "\n상영관   : " + selectedAudi + "\n일시    : " + selectedTime;
            lb_cost1.Text = totalCosts + " 원";

            if (selectedTheater.Equals("서울"))
            {
                pathSeoul += selectedIdx + ".txt";
            }
            else if (selectedTheater.Equals("대전"))
            {
                pathDaejeon += selectedIdx + ".txt";
            }
            else
            {
                pathDaegu += selectedIdx + ".txt";
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            string strBaseName = assembly.GetName().Name + "." + "Properties.Resources";
            ResourceManager rm = new ResourceManager(strBaseName, Assembly.GetExecutingAssembly());
            moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            moviePoster.Image = rm.GetObject(selectedMovie) as Image;
            rm.ReleaseAllResources();
        }

        private void btn_fin_Click(object sender, EventArgs e)
        {
            // 파일에 좌석 이진정보 출력하여 갱신
            if (selectedTheater.Equals("서울"))
            {
                System.IO.File.WriteAllText(pathSeoul, finalDatas[8]);
            }
            else if (selectedTheater.Equals("대전"))
            {
                System.IO.File.WriteAllText(pathDaejeon, finalDatas[8]);
            }
            else
            {
                System.IO.File.WriteAllText(pathDaegu, finalDatas[8]);
            }

            finalDatas[9] = totalCosts+"";

            string check = "";
            for (int i = 0; i < finalDatas.Length; i++)
            {
                check += finalDatas[i] + "\n";
            }

            // 파일에 결제내역 출력
            string pathUser = @"..\..\" + pubvar.user + "Info.txt";
            System.IO.File.WriteAllText(pathUser, check);

            for (int i = 0; i < movieLists.Length; i++)
            {
                if (movieLists[i][0].Equals(selectedMovie))
                {
                    movieLists[i][2] = (int.Parse(movieLists[i][2]) + 1)+"";
                }
            }
            
            // 랭킹 올리기
            string outputTexts = "";
            outputTexts += movieLists[0][0] + "%" + movieLists[0][1] + "%" + movieLists[0][2];
            for (int i = 1; i < movieLists.Length; i++)
            {
                outputTexts += "$" + movieLists[i][0] + "%" + movieLists[i][1] + "%" + movieLists[i][2];
            }
            System.IO.File.WriteAllText(path, outputTexts);

            MessageBox.Show("결제를 성공적으로 완료했습니다!\n"+check);
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                finalDatas[10] = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                finalDatas[10] = radioButton1.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                finalDatas[10] = radioButton1.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                finalDatas[10] = radioButton1.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                totalCosts = totalCosts * 0.9;
                lb_cost2.Text = totalCosts + " 원";
            }
            else
            {
                totalCosts = totalCosts * 10 / 9;
                lb_cost2.Text = totalCosts + " 원";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                totalCosts = totalCosts * 0.8;
                lb_cost2.Text = totalCosts + " 원";
            }
            else
            {
                totalCosts = totalCosts * 10 / 8;
                lb_cost2.Text = totalCosts + " 원";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                totalCosts = totalCosts * 0.5;
                lb_cost2.Text = totalCosts + " 원";
            }
            else
            {
                totalCosts = totalCosts * 10 / 5;
                lb_cost2.Text = totalCosts + " 원";
            }
        }
    }
}
