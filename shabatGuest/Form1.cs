using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace shabatGuest
{

    public partial class FrmCategory : Form
    {
        SqlConnection Connection;

        private readonly string ConectionString = ""
            + "server=DESKTOP-Q2PJJ02\\SQLEXPRESS ;"
            + "Initial Catalog =shabat ;"
            + "user id=sa ;"
            + "password=1234 ;"
            + "TrustServerCertificate=Yes";




        frmMain parent;
        int CurrIndex;
        public FrmCategory(frmMain _parent, string _categoryName, string _name, int _index)
        {
            InitializeComponent();
            parent = _parent;
            lblGuestName.Text = _name;
            lblCategoryName.Text = _categoryName;
            CurrIndex = _index;
            gdvAllChoises_CellContentClick();
           
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




       

        private void gdvAllChoises_CellContentClick()
        {
            
            string query = "SELECT name FROM dishes";
            if (Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, ConectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gdvAllChoises.DataSource = dt;
                Disconect();
            }
        }
  
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrIndex < parent.categoryList.Count() - 1)
            {
                this.Visible = false;
                parent.categoryList[CurrIndex + 1].Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {            
            if (CurrIndex > 0)
            {
                this.Visible = false;
                parent.categoryList[CurrIndex - 1].Visible = true;
            }
        }

        private void dgvGuestChoise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCategoryName_Click(object sender, EventArgs e)
        {
            
        }

        private void gdvAllChoises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT name FROM dishes";
            if (Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, ConectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gdvAllChoises.DataSource = dt;
                Disconect();
            }
        }
    }
}
