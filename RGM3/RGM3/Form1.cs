using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace RGM3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("hu-HU");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linqxmlDataContext context = new linqxmlDataContext();
            var customers = from c in context.customers
                            where c.ExpDate != null
                            select new
                            {
                                Név = c.Name,
                                Lejárat = c.ExpDate
                            };
            foreach (var customer in customers)
            {
                listBox1.Text += customer.Név + "\r\n";
                listBox1.Items.Add(customer.Név);
            }
            dataGridView1.DataSource = customers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();
            //if (Application.OpenForms[log.Name] == null)
            //{
            //    log.Show();
            //}
            //else
            //{
            //    Application.OpenForms[log.Name].Activate();
            //}
        }
    }
}
