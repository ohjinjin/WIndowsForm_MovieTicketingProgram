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
    public partial class MyCGVForm : Form
    {
        string pathUser = @"..\..\" + pubvar.user + "Info.txt";

        public MyCGVForm()
        {
            InitializeComponent();
            label1.Text = System.IO.File.ReadAllText(pathUser, Encoding.Default);
            if (!(pubvar.user.Equals("")))
            {
                btn_myCGV.Visible = true;
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_movie_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
            this.Close();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.Show();
            this.Close();
        }
    }
}
