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
    public partial class FrmAllSchedule : Form
    {
        Connect con;
        public FrmAllSchedule()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllCustomer_Load(object sender, EventArgs e)
        {
            dgvAllSchedule.DataSource = await con.GetAllCourse();
        }

        
    }
}
