using Newtonsoft.Json;
using ProjectClientCourse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClientCourse
{
    public partial class Form1 : Form
    {
        HttpClient Students;//אוביקט שתפקידו לתקשר עם השרת
        List<Students> lstStudents;//רשימה שתכיל את כל מאגר הסטודנטים
        HttpResponseMessage response;//אוביקט שמקבל את התגובה מהשרת

        public Form1()
        {

            InitializeComponent();
            Students = new HttpClient();
            response = new HttpResponseMessage();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            response = await Students.GetAsync("https://localhost:7180/api/Students");


            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();
                lstStudents = JsonConvert.DeserializeObject<List<Students>>(data);
            }

            else
                MessageBox.Show("error ");
            dataGridView1.DataSource = lstStudents;
        }

    }
}
