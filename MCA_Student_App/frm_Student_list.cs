using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCA_Student_App
{
    public partial class frm_Student_list : Form
    {
        public frm_Student_list()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure Do You Want To Logout??", "Logging Out", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)   
            {
                Frm_Login obj = new Frm_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_add_student_detail obj = new frm_add_student_detail();  
            obj.Show();
            this.Hide();
        }

        private void frm_Student_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.dataSet3.Student_Details);

        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Detail obj = new frm_Search_Student_Detail();
            obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_add_student_detail obj = new frm_add_student_detail();
            obj.Show();
            this.Hide();
        }
    }
}
