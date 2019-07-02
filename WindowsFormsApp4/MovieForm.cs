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
    public partial class MovieForm : Form
    {
        int selectedNum = -1;
        //string user = "";

        public MovieForm()
        {
            //this.user = user;
            InitializeComponent();
            if (!(pubvar.user.Equals("")))
            {
                btn_myCGV.Visible = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                selectedNum = item.Index;
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                MessageBox.Show(subItem[0].Text + "\n\n" + subItem[1].Text + "\n" + subItem[2].Text + "\n" + subItem[3].Text + "\n\n" + subItem[4].Text);
            }
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            this.Close();
            TicketForm ticketForm = new TicketForm();
            ticketForm.Show();
        }

        private void btn_ticketing_Click(object sender, EventArgs e)
        {
            //ListView lv = sender as ListView;
            //lv.FullRowSelect = true;
            //SelectRow = lv.SelectedItems[0].Index;
            this.Close();
            TicketForm ticketForm = new TicketForm(selectedNum);
            ticketForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 mainForm = new Form1();
            //mainForm.Show();
        }

        private void btn_myCGV_Click(object sender, EventArgs e)
        {
            MyCGVForm myCGVForm = new MyCGVForm();
            myCGVForm.Show();
            this.Close();
        }
    }
}
