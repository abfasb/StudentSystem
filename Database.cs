using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Information_System
{
    internal class Database
    {
        private const string V = "Password";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDa;
        DataTable dt;
        string constr;

        public Database()
        {
            constr = @"Data Source=JAMAICA16;Integrated Security=True";
            sqlCon = new SqlConnection(constr);
            sqlCon.Open();

        }
        public void sqlCommand ()
        {
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = 50;
            command.CommandType = CommandType.Text;
        }
        public string generatedId()
        {
            int currentYear = DateTime.Now.Year;
            string sql = "Select Count (*) FROM tblStudent";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);

            int latestStudentId = Convert.ToInt32(cmd.ExecuteScalar());

            string generatedID = $"MCC{currentYear}-{(latestStudentId + 1).ToString("D3")}";

            return generatedID;
        }
        public string getHashedPassword(string username)
        {
            string hashedPassword = null;

            string query = $"SELECT Password FROM tblAdmin WHERE Username = '{username}'";
            sqlCom = new SqlCommand(query, sqlCon);

            SqlDataReader reader = sqlCom.ExecuteReader();
            if (reader.Read())
            {
                hashedPassword = reader[V].ToString();
            }

            reader.Close();
            sqlCom.Dispose();

            return hashedPassword;
        }
        public void insertEnrollment(string course)
        {

        }
        public void insertCollege(string Course)
        {
            string college, displayCollegeByCourse;
            college = Course.ToUpper();
            if (Course == "BSIT")
            {
                college = "CCS";
            }
            else if (Course == "AB PSYCH" || Course == "AB ENGLISH")
            {
                college = "CAS";
            }
            else if (Course == "BSCRIM")
            {
                college = "CCJE";
            }
            else if (Course == "BTVTED")
            {
                college = "BTVTED";
            }
            else if (Course == "BSTM" || Course == "BSHM")
            {
                college = "CBM";
            }
            else if (Course == "BSED")
            {
                college = "CTE";
            }
            displayCollegeByCourse = college;

            string sql = $"INSERT INTO tblCollege (CollegeName) VALUES ('{displayCollegeByCourse}')";
            getData(sql);
        }
        public string insertCourseString(string Course)
        {
            string college, displayCollegeByCourse;
            college = Course.ToUpper();
            if (Course == "BSIT")
            {
                college = "CCS";
            }
            else if (Course == "AB PSYCH" || Course == "AB ENGLISH")
            {
                college = "CAS";
            }
            else if (Course == "BSCRIM")
            {
                college = "CCJE";
            }
            else if (Course == "BTVTED")
            {
                college = "BTVTED";
            }
            else if (Course == "BSTM" || Course == "BSHM")
            {
                college = "CBM";
            }
            else if (Course == "BSED")
            {
                college = "BTE";
            }
            displayCollegeByCourse = college;

            return displayCollegeByCourse;
        }
        public bool CheckUserExists(string username)
        {
            bool usernameExists = false;

            string query = "SELECT COUNT(*) FROM tblAdmin WHERE Username = @Username";
            sqlCom = new SqlCommand(query, sqlCon);
            sqlCom.Parameters.AddWithValue("@Username", username);

            int userCount = Convert.ToInt32(sqlCom.ExecuteScalar());

            if (userCount > 0)
            {
                usernameExists = true;
            }

            return usernameExists;
        }
        public bool hasStudents()
        {
            string sql = "Select Count(*) FROM tblStudent";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            int count = (int)cmd.ExecuteScalar();

            return count > 0;
        }
        public int countStudents()
        {
            string sql = "Select Count(*) FROM tblStudent";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            int counts = (int)cmd.ExecuteScalar();

            return counts;
        }
        public bool VerifyPassword(string inputPassword, string username)
        {
            string hashedInput = HashPassword(inputPassword);
            string hashedPasswordFromDatabase = getHashedPassword(username);

            return hashedInput.Equals(hashedPasswordFromDatabase);
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hashBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public int getData(string sql)
        {
            try
            {
                sqlCom = new SqlCommand(sql, sqlCon);
                return sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;

        }

        public DataTable selectTable(string sql)
        {
            dt = new DataTable();
            sqlDa = new SqlDataAdapter(sql, constr);
            sqlDa.Fill(dt);
            sqlDa.Dispose();
            return dt;
        }
        public Image GetStudentImage(int studentId)
        {
            string sql = $"SELECT ImageData FROM tblStudent WHERE StudentId = {studentId}";

            DataTable result = selectTable(sql);

            if (result.Rows.Count > 0)
            {
                string hexImage = result.Rows[0]["ImageData"].ToString();
                byte[] imageBytes = Enumerable.Range(0, hexImage.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(hexImage.Substring(x, 2), 16))
                    .ToArray();
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }

            return null;
        }
        public object executeScalar(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

            object result = sqlCommand.ExecuteScalar();
            return result;
        }
        public int executeInsertWithOutput(string query, string outputColumnName)
        {
            int insertedId = 0;

            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            object result = reader[outputColumnName];
                            if (result != null && result != DBNull.Value)
                            {
                                insertedId = Convert.ToInt32(result);
                            }
                        }
                    }
                }
            }

            return insertedId;
        }
        public int getTotalRecord(string tableName)
        {
            int totalRecord = 0;
            string sql = $"SELECT COUNT (*) FROM {tableName}";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            totalRecord = Convert.ToInt32(cmd.ExecuteScalar());
            return totalRecord;
        }
        public int getTotalRecordGender(string genderName)
        {
            int totalCount = 0;
            string sql = $"Select COUNT (*) FROM tblStudent WHERE Gender = '{genderName}'";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            totalCount = Convert.ToInt32(cmd.ExecuteScalar());
            return totalCount;
        }
        public string displayCollege(string tblName)
        {
            string storeTableNamee = "";
            if (tblName == "CCS")
            {
                storeTableNamee = "Colllege of Computer Studies";
            }
            else if (tblName == "CBM")
            {
                storeTableNamee = "College of Business Management";
            }
            else if (tblName == "CAS")
            {
                storeTableNamee = "College of Arts and Sciences";
            }
            else if (tblName == "CCJE")
            {
                storeTableNamee = "College of Criminal Justice Education";
            }
            else if (tblName == "BTVTED")
            {
                storeTableNamee = "Bachelor of Technical Vocational Education";
            }
            else if (tblName == "CTE")
            {
                storeTableNamee = "College of Teacher Education";
            }
            return storeTableNamee;
        }
        public List<string> displayCollegeByPopulation(int topRankings)
        {
            List<string> colleges = new List<string>();

            string sql = $"SELECT TOP {topRankings} CollegeName, COUNT(*) AS StudentPopulation FROM tblCollege GROUP BY CollegeName ORDER BY StudentPopulation DESC";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string collegeName = reader["CollegeName"].ToString();
                string displayRankings = displayCollege(collegeName);
                colleges.Add(displayRankings);
            }

            reader.Close();
            return colleges;
        }

        public DataTable GetMonthlyEnrollmentData()
        {
            DataTable dataTable = new DataTable();

             string query = "SELECT MONTH(EnrollmentDate) AS EnrollmentMonth, COUNT(*) AS StudentsEnrolled " +
                                   "FROM tblEnrollment " +
                                  "GROUP BY MONTH(EnrollmentDate)";
             SqlCommand command = new SqlCommand(query, sqlCon);
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             adapter.Fill(dataTable);
            return dataTable;
        }
        public void PopulateChartFromData(Chart chart)
        {
            DataTable enrollmentData = GetMonthlyEnrollmentData();

            if (enrollmentData.Rows.Count > 0)
            {
                chart.Series["Enrolled"].Points.Clear();

                foreach (DataRow row in enrollmentData.Rows)
                {
                    int enrollmentMonth = Convert.ToInt32(row["EnrollmentMonth"]);
                    int studentsEnrolled = Convert.ToInt32(row["StudentsEnrolled"]);

                    string monthName = new DateTime(2000, enrollmentMonth, 1).ToString("MMMM");

                    chart.Series["Enrolled"].Points.AddXY(monthName, studentsEnrolled);
                }
            }
        }
        public int getStudentCount (string collegeName)
        {
            int totalCount = 0;
            string sql = $"SELECT COUNT(*) FROM tblCollege WHERE CollegeName = '{collegeName}'";

            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                totalCount = (int)cmd.ExecuteScalar();
            }

            return totalCount;
        }
        public void populatePieChartData(Chart chartPiee)
        {
            string query = "SELECT DISTINCT CollegeName FROM tblCollege";
            SqlCommand command = new SqlCommand(query, sqlCon);
            SqlDataReader reader = command.ExecuteReader();
            chartPiee.Series["StudentsByCollege"].Points.Clear();

            int totalCount = 0;
            while (reader.Read())
            {
                totalCount++;
            }
            reader.Close();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string collegeName = reader["CollegeName"].ToString();
                int count = getStudentCount(collegeName);
                double percentage = (double)count / totalCount * 100;
                DataPoint dp = chartPiee.Series["StudentsByCollege"].Points.Add(count);
                dp.LegendText = collegeName;
                dp.Label = string.Format("{0:F2}%", percentage); 
                dp.LabelForeColor = Color.White;
                dp.IsValueShownAsLabel = true;
            }

            reader.Close();
        }
        public byte[] SelectBytes(string sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
            SqlDataReader reader = command.ExecuteReader();
              if (reader.Read())
              {
                 return (byte[])reader[0];
              }
            return null;
        }
        public int countAdmin (string deptType)
        {
            int totalCount = 0;
            string sql = $"Select Count (*) FROM tblAdmin WHERE Department = '{deptType}'";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            totalCount = (int)cmd.ExecuteScalar();
            return totalCount;
        }
        public byte[] executeRealScalar (string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return (byte[])result;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Try again.");
            }
            return null;

        }

    }

}
