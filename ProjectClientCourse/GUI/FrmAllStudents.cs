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
    public partial class FrmAllStudents : Form
    {
        Connect con;
        public FrmAllStudents()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllCustomer_Load(object sender, EventArgs e)
        {
            dgvAllStudents.DataSource = await con.GetAllStudents();
        }

        private void FrmAllStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
