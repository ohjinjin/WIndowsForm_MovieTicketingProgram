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
    public partial class LoginForm : Form
    {
        string path = @"..\..\users.txt";

        public string ReturnValue { get; set; }
        string[][] userLists;

        public LoginForm()
        {
            string rawTexts = System.IO.File.ReadAllText(path, Encoding.Default);
            string[] tmpLists = rawTexts.Split('$');
            userLists = new string[tmpLists.Length][];

            for (int i = 0; i < tmpLists.Length; i++)
            {
                userLists[i] = tmpLists[i].Split('%');
            }
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userLists.Length; i++)
            {
                if (userLists[i][1].Equals(tbox_id.Text) && userLists[i][2].Equals(tbox_pw.Text))
                {
                    this.ReturnValue = tbox_id.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("아이디와 비밀번호를 확인바랍니다.");
            return;
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            this.ReturnValue = tbox_id.Text;
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        //private void btnOk
    }
}
