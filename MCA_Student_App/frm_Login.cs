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
using System.Data.SqlClient;

namespace MCA_Student_App
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Student_Login_DB;Integrated Security=True");
        
        void Con_Open()
        {
            if (Con.State!=ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State!=ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //if(tb_Username.Text == "A" && tb_Password.Text == "A")
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Count(*) From Student_User_And_pass_Db Where Username = @unm And Password = @Pwd", Con);

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
            int cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if (cnt>0)
            {
                MessageBox.Show("Login Successful","Welcome");

                frm_add_student_detail sd = new frm_add_student_detail();
                sd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed Enter Correct Username/Password.", "failure");
            }
            tb_Password.Clear();
            tb_Username.Clear();

            tb_Username.Focus();

        }
    }
}
