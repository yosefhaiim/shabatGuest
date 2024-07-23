using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shabatGuest
{
    public partial class frmMain : Form
    {
        SqlConnection Connection;

        private readonly string ConectionString = ""
            + "server=DESKTOP-Q2PJJ02\\SQLEXPRESS ;"
            + "Initial Catalog =shabat ;"
            + "user id=sa ;"
            + "password=1234 ;"
            + "TrustServerCertificate=Yes";

        public List<FrmCategory> categoryList = new List<FrmCategory>();

        public frmMain()
        {
            InitializeComponent();
            ShowAllGuests();
        }
        private bool Connect()
        {
            try
            {
                // נסיון לחבר למסד הנתונים
                Connection = new SqlConnection(ConectionString);
                // פתיחת חיבור
                Connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        // סגירת החיבור
        private void Disconect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                // סגירת חיבור
                Connection.Close();
            }

        }
        private void ShowAllGuests(string name = "")
        {

            // יצירת השאילתה כסטרינג
            string query = "SELECT name FROM guest WHERE name LIKE '%' + @name + '%'";

            // פתיחת חיבור
            if (Connect())
            {
                // יצירת אובייקט פקודה והכנסת פרמטרים
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@name", name);

                // ביצוע שלילתה ובדיקת תוצאות
                SqlDataReader reader = cmd.ExecuteReader();
                lstNamsOfGuests.Items.Clear();

                // בדיקה אם יש שורות בטבלה
                if (reader.HasRows)
                {
                    // ריצה על כל השורות במידה וקיימות
                    while (reader.Read())
                    {
                        // הוספת השמות לאובייקט הליסטבוקס שבעמוד העיצוב
                        string categoryName = reader[0].ToString();
                        lstNamsOfGuests.Items.Add(categoryName);
                    }
                }

                // סגירת חיבור
                Disconect();
            }
        }

        private void ShowAllCategories(string name )
        {
            if(name == "")
            {
                return;
            }
            // יצירת השאילתה כסטרינג
            string query = "SELECT name FROM category";

            // פתיחת חיבור
            if (Connect())
            {
                // יצירת אובייקט פקודה
                SqlCommand cmd = new SqlCommand(query, Connection);
               
                // ביצוע שאילתה ובדיקת תוצאות
                SqlDataReader reader = cmd.ExecuteReader();


                int index = 0;
               
                // בדיקה אם יש שורות בטבלה
                if (reader.HasRows)
                {
                    // ריצה על כל השורות במידה וקיימות
                    while (reader.Read())
                    {
                        string categoryName = reader[0].ToString();

                        categoryList.Add(new FrmCategory(this, categoryName,name, index++));          
                    }
                    categoryList.First().Show();
                }

                // סגירת חיבור
                Disconect();
            }
        }


        private void btnOk_Click_1(object sender, EventArgs e)
        {
            // שאילתת הוספה, בדיקה אם הקטגוריות אינן ריקות ואם הקטגוריה לא קיימת כבר
            string queryInsert = @"
                                  IF (@name_guest != '')
                                  BEGIN
                                        IF NOT EXISTS (SELECT name FROM guest WHERE name = @name_guest)
                                            BEGIN
                                                INSERT INTO guest (name) VALUES (@name_guest)
                                            END
                                  END
                                  ";

            if (Connect())
            {
                // יצירת אובייקט פקודה והוספת פרמטרים
                SqlCommand cmd = new SqlCommand(queryInsert, Connection);
                cmd.Parameters.AddWithValue("@name_guest", txtName.Text);

                // לבצע פקודה ולהחזיר כמה שורות נוספו
                int updateRows = cmd.ExecuteNonQuery();
                if (updateRows > 0)
                {
                    ShowAllGuests();
                }

               ShowAllCategories(txtName.Text);
                txtName.Text = "";

            }
            Disconect();
        }

        private void lstNamsOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = lstNamsOfGuests.SelectedItems[0].ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

