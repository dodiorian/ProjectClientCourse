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
    public partial class FrmAllProffesors : Form
    {

        Connect con;
        public FrmAllProffesors()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllProffesors_Load(object sender, EventArgs e)
        {
            dgvAllProffesors.DataSource = await con.GetAllProffesors();
        }

        private void FrmAllCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
