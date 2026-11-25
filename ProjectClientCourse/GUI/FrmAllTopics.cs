using ProjectClientCourse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClientCourse.GUI
{
    public partial class FrmAllTopics : Form
    {
        Connect con;
        public FrmAllTopics()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllCustomer_Load(object sender, EventArgs e)
        {
            dgvAllTopics.DataSource = await con.GetAllTopics();
        }

        private void FrmAllCourse_Load(object sender, EventArgs e)
        {

        }

    }
}
