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
    public partial class FrmAllCourse : Form
    {
        Connect con;
        List<Course> lstcourses;
        public FrmAllCourse()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllCourse_Load(object sender, EventArgs e)
        {
            dgvAllCourse.DataSource = await con.GetAllCourse();
            lstcourses = await con.GetAllCourse();
            dgvAllCourse.DataSource = lstcourses.Select(c => new
            {
                c.CourseId,
                c.CourseName,
                c.ProfessorsId,
                c.CourseCode,
                c.Credits,
            }).ToList();

        }
    
        
    }
}
