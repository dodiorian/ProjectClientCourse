using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClientCourse.Model
{
    internal class Connect
    {
        HttpClient Client;//אוביקט שתפקידו לתקשר עם השרת
        HttpResponseMessage response;//אוביקט שמקבל את התגובה מהשרת
        List<Students> lstStudents; //רשימה שתכיל את כל מאגר הלקוחות
        List<Schedule> lstSchedule; //רשימה שתכיל את כל מאגר הלוחות זמנים
        List<Proffesors> lstProffesors; //רשימה שתכיל את כל מאגר הפרופסורים
        List<Course> lstCourse; //רשימה שתכיל את כל מאגר הקורסים
        List<Topics> lstTopics; //רשימה שתכיל את כל מאגר הנושאים
        List<Syllabus> lstSyllabus; //רשימה שתכיל את כל מאגר הסילאבוסים
        List<Registation> lstRegistation; //רשימה שתכיל את כל מאגר ההרשמה
        public Connect()
        {
            Client = new HttpClient();
            response = new HttpResponseMessage();
        }

        public async Task<List<Students>> GetAllStudents()
        {

            response = await Client.GetAsync("https://localhost:7180/api/Students\r\n");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstStudents = JsonConvert.DeserializeObject<List<Students>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstStudents;
        }

        public async Task<List<Schedule>> GetAllSchedule()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Schedule");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                var lstSchedule = JsonConvert.DeserializeObject<List<Schedule>>(data);
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.

            return lstSchedule;
        }
        public async Task<List<Course>> GetAllCourse()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Course");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstCourse = JsonConvert.DeserializeObject<List<Course>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstCourse;
        }
        public async Task<List<Registation>> GetAllRegistation()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Registation");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstRegistation = JsonConvert.DeserializeObject<List<Registation>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstRegistation;
        }
        public async Task<List<Syllabus>> GetAllSyllabus()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Syllabus");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstSyllabus = JsonConvert.DeserializeObject<List<Syllabus>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstSyllabus;
        }
        public async Task<List<Topics>> GetAllTopics()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Topics");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstTopics = JsonConvert.DeserializeObject<List<Topics>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstTopics;
        }
        public async Task<List<Proffesors>> GetAllProffesors()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Proffesors");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstProffesors = JsonConvert.DeserializeObject<List<Proffesors>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstProffesors;
        }
    }
}






