using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            Model3 context = new Model3();
            List<Student> liststudents = context.Students.ToList();
            dataGridView1.Rows.Clear();
            foreach(var item in liststudents)
            {
                int index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells["MaSV"].Value = item.StudentID;
                dataGridView1.Rows[index].Cells["HoTen"].Value = item.FullName;
                dataGridView1.Rows[index].Cells["Khoa"].Value = item.FacultyID;
                dataGridView1.Rows[index].Cells["DiemTB"].Value = item.AverageScore;
            }
        }
    }
}
