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
    public partial class JoinForm : Form
    {
        string path = @"..\..\users.txt";
        // 입력 데이터들을 담을 문자열 배열
        string[] inputDatas;
        string finalDatas = "";

        public JoinForm()
        {
            InitializeComponent();
            inputDatas = new string[5];
            comboBox_for_email.SelectedIndex = 3;
            comboBox_phone.SelectedIndex = 0;
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            // 추가적 예외처리!!!!!!!!!!!!!!!!!!!!!
            // 입력 문자열 검사
            if (name.Text.Equals("") || id.Text.Equals("") || pw.Text.Equals("") || email1.Text.Equals("") || email2.Text.Equals("직접입력") || phone1.Text.Equals("") || phone2.Text.Equals(""))
            {
                MessageBox.Show("입력 사항을 다시 확인하세요");
                return;
            }
            inputDatas[0] = name.Text;
            inputDatas[1] = id.Text;
            // 비밀번호 재확인 검사
            if (verifyPw.Text.Equals(pw.Text))
            {
                inputDatas[2] = pw.Text;
            }
            else
            {
                MessageBox.Show("비밀번호 확인에 오류가 있습니다");
                return;
            }
            inputDatas[3] = email1.Text + "@" + email2.Text;
            inputDatas[4] = comboBox_phone.SelectedItem.ToString() + phone1.Text + phone2.Text;

            // 처음 생성되는게 아니라면 행구분자를 먼저 넣어주고 시작
            string tmpAllTexts = System.IO.File.ReadAllText(path);
            if (!tmpAllTexts.Equals(""))
            {
                finalDatas = "$";
            }

            finalDatas += inputDatas[0];
            for (int i = 1; i < inputDatas.Length; i++)
            {
                finalDatas += "%" + inputDatas[i];
            }

            System.IO.File.AppendAllText(path,finalDatas);
            MessageBox.Show("환영합니다." + inputDatas[0] + "님!\n회원가입이 정상적으로 이루어졌습니다.");
            this.Close();
        }

        private void comboBox_for_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            email2.Text = comboBox_for_email.SelectedItem.ToString();
        }
    }
}
