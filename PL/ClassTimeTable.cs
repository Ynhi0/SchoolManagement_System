using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace PL
{
    public partial class ClassTimeTable : Form
    {
        public ClassTimeTable()
        {
            InitializeComponent();

        }

        private void dataGridViewTimeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeClassSchedule()
        {
            // Thêm các cột cho ca học
            dataGridViewTimeTable.Columns.Add("Ca", "Ca Học");
            dataGridViewTimeTable.Columns.Add("Monday", "Thứ 2");
            dataGridViewTimeTable.Columns.Add("Tuesday", "Thứ 3");
            dataGridViewTimeTable.Columns.Add("Wednesday", "Thứ 4");
            dataGridViewTimeTable.Columns.Add("Thursday", "Thứ 5");
            dataGridViewTimeTable.Columns.Add("Friday", "Thứ 6");
            dataGridViewTimeTable.Columns.Add("Saturday", "Thứ 7");

            // Thêm các hàng cho các ca học
            for (int i = 1; i <= 4; i++)
            {
                dataGridViewTimeTable.Rows.Add(i);
            }
            foreach (DataGridViewColumn column in dataGridViewTimeTable.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dataGridViewTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void LoadSchedule()
        {
            ClassBL classBL = new ClassBL();
            DataTable classData = classBL.GetAllClass();

            dataGridViewTimeTable.Rows.Clear();

            var scheduleDict = new Dictionary<int, ScheduleItem>();

            foreach (DataRow row in classData.Rows)
            {
                TeacherBL teacherBL = new TeacherBL();
                int caHoc = Convert.ToInt32(row["CAHOC"]);
                string className = row["CLASSNAME"].ToString() ?? string.Empty;
                string timetable = row["TIMETABLE"].ToString() ?? string.Empty;
                string idClass = row["IDCLASS"].ToString() ?? string.Empty;
                string teacherID = row["IDTEACHER"].ToString() ?? string.Empty;
                int room = Convert.ToInt32(row["ROOM"]);
                string teacherName = teacherBL.GetTeacherNameByID(teacherID);

                if (!scheduleDict.ContainsKey(caHoc))
                {
                    scheduleDict[caHoc] = new ScheduleItem
                    {
                        CaHoc = caHoc,
                        Monday = "",
                        Tuesday = "",
                        Wednesday = "",
                        Thursday = "",
                        Friday = "",
                        Saturday = ""
                    };

                }
                string displayInfor = $"Class's ID: {idClass}\n Class: {className}\n Teacher: {teacherName}\nRoom:{room}";
                string[] days = timetable.Split('-'); //Tách chuỗi theo dấu

                foreach (string day in days)
                {
                    int dayNumber = int.Parse(day);

                    switch (dayNumber)
                    {
                        case 2:
                            scheduleDict[caHoc].Monday = displayInfor; // Thứ 2
                            break;
                        case 3:
                            scheduleDict[caHoc].Tuesday = displayInfor; // Thứ 3
                            break;
                        case 4:
                            scheduleDict[caHoc].Wednesday = displayInfor;
                            break;
                        case 5:
                            scheduleDict[caHoc].Thursday = displayInfor; // Thứ 5
                            break;
                        case 6:
                            scheduleDict[caHoc].Friday = displayInfor; // Thứ 6
                            break;
                        case 7:
                            scheduleDict[caHoc].Saturday = displayInfor; // Thứ 7
                            break;
                    }
                }
            }
            foreach (var item in scheduleDict.Values)
            {
                dataGridViewTimeTable.Rows.Add(item.CaHoc, item.Monday, item.Tuesday, item.Wednesday, item.Thursday,
                                               item.Friday,
                                               item.Saturday);
            }
        }
        private void ClassTimeTable_Load(object sender, EventArgs e)
        {
            InitializeClassSchedule();
            LoadSchedule();
        }
        private void dataGridViewSchedule_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewTimeTable.Rows)
            {
                row.Height = 150;
                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void btnEnrollClass_Click(object sender, EventArgs e)
        {
            this.Close();
            EnrollClassManagement enrollClassManagement = new EnrollClassManagement();
            enrollClassManagement.ShowDialog();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassManagement classManagement = new ClassManagement();
            classManagement.ShowDialog();
        }

        private void btnExamSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
            ClassExamSchedule classExamSchedule = new ClassExamSchedule();
            classExamSchedule.ShowDialog();
        }
    }
}
