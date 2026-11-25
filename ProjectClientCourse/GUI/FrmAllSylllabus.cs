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
    public partial class FrmAllSylllabus : Form
    {
        Connect con;
        public FrmAllSylllabus()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllSylllabus_Load(object sender, EventArgs e)
        {
            dgvAllSylllabus.DataSource = await con.GetAllSylllabus();
        }

        private void FrmAllCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
