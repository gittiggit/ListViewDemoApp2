using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> stdList = new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.studentName = "Mahmud";
            student.studentAddress = "Digontho 38 , E.Supply";
            student.studentCity = "Sylhet";
            student.studentGender = "Male";

            stdList.Add(student);


            Student student1 = new Student();
            student1.studentName = "Jamal";
            student1.studentAddress = "kmhbjbj, E.Supply";
            student1.studentCity = "Dhaka";
            student1.studentGender = "Male";
           

            stdList.Add(student1);


            foreach(Student std in stdList)
            {
                ListViewItem lvi = new ListViewItem(std.studentName);
                lvi.SubItems.Add(std.studentAddress);
                lvi.SubItems.Add(std.studentCity);

                listView1.Items.Add(lvi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //You can use this 

            //ListViewItem li = listView1.SelectedItems[0];
            //label1.Text = li.SubItems[1].Text;

            //Or you can use this

            label1.Text = listView1.SelectedItems[0].SubItems[0].Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }
    }
}
