using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RGM3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            linqxmlDataContext asd = new linqxmlDataContext();
            //bool contains = tbl.AsEnumerable()
            //   .Any(row => searchAuthor == row.Field<String>("Author"));
            var pass=(from c in asd.User
                      where c.Name ==tbName.Text
                      select c.Password
                      ).firstordefault
        }
    }
}
