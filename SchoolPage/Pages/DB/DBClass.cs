using SchoolPage.Pages.DBClasses;
using System.Data.SqlClient;

namespace SchoolPage.Pages.DB
{
    public class DBClass
    {
        // SQL Connection OBject Added to the class level
        public static SqlConnection SchoolDBConnection = new SqlConnection();

        // Connection String
        private static readonly String SchoolDBConnString = "Server = LOCALHOST; Database=Lab 3; Trusted_Connection=True";

        // Database Interaction Method(s)

        int result = 0;
        public static SqlDataReader StudentReader()
        {
            SqlCommand cmdStudentRead = new SqlCommand();
            cmdStudentRead.Connection = SchoolDBConnection;
            cmdStudentRead.Connection.ConnectionString = SchoolDBConnString;
            cmdStudentRead.CommandText = "SELECT * FROM Student";

            cmdStudentRead.Connection.Open();

            SqlDataReader tempReader = cmdStudentRead.ExecuteReader();

            return tempReader;


        }
        
    

        public static SqlDataReader InstructorReader()
        {
            SqlCommand cmdInstructorRead = new SqlCommand();
            cmdInstructorRead.Connection = SchoolDBConnection;
            cmdInstructorRead.Connection.ConnectionString = SchoolDBConnString;
            cmdInstructorRead.CommandText = "SELECT * FROM Instructor";

            cmdInstructorRead.Connection.Open();

            SqlDataReader tempReader = cmdInstructorRead.ExecuteReader();

            return tempReader;


        }
        public static SqlDataReader SingleInstructorReader(int instructorID)
        {
            SqlCommand cmdInstructorRead = new SqlCommand();
            cmdInstructorRead.Connection = SchoolDBConnection;
            cmdInstructorRead.Connection.ConnectionString = SchoolDBConnString;
            cmdInstructorRead.CommandText = "SELECT * FROM Instructor WHERE instructorID = " + instructorID;

            cmdInstructorRead.Connection.Open();

            SqlDataReader tempReader = cmdInstructorRead.ExecuteReader();


            return tempReader;


        }
        public static SqlDataReader SingleCredentialReader()
        {
            
           SqlCommand cmdCredRead = new SqlCommand();
            cmdCredRead.Connection = SchoolDBConnection;
            cmdCredRead.Connection.ConnectionString = SchoolDBConnString;
            cmdCredRead.CommandText = "SELECT Max(credentialsID) FROM Credentials;";
            

            cmdCredRead.Connection.Open();
            SqlDataReader tempReader = cmdCredRead.ExecuteReader();

            cmdCredRead.Connection.Close();
            return tempReader;




        }

        // You might have added this one already . . .check!
        // Can run and return results for any query, if results exist.
        // Query is passed from the invoking code.
        public static SqlDataReader GeneralReaderQuery(string sqlQuery)
        {

            SqlCommand cmdProductRead = new SqlCommand();
            cmdProductRead.Connection = SchoolDBConnection;
            cmdProductRead.Connection.ConnectionString = SchoolDBConnString;
            cmdProductRead.CommandText = sqlQuery;
            cmdProductRead.Connection.Open();
            SqlDataReader tempReader = cmdProductRead.ExecuteReader();

            return tempReader;

        }

        // Can run and return results for any query, if results exist.
        // Query is passed from the invoking code.
        public static void InsertQuery(string sqlQuery)
        {

            SqlCommand cmdProductRead = new SqlCommand();
            cmdProductRead.Connection = SchoolDBConnection;
            cmdProductRead.Connection.ConnectionString = SchoolDBConnString;
            cmdProductRead.CommandText = sqlQuery;
            cmdProductRead.Connection.Open();
            cmdProductRead.ExecuteNonQuery();

        }

        public static SqlDataReader SingleStudentReader(int studentID)
        {
            SqlCommand cmdStudentRead = new SqlCommand();
            cmdStudentRead.Connection = SchoolDBConnection;
            cmdStudentRead.Connection.ConnectionString = SchoolDBConnString;
            cmdStudentRead.CommandText = "SELECT * FROM Instructor WHERE instructorID = " + studentID;

            cmdStudentRead.Connection.Open();

            SqlDataReader tempReader = cmdStudentRead.ExecuteReader();

            return tempReader;


        }

        public static void UpdateInstructor(Instructor i)
        {
            String sqlQuery = "UPDATE Instructor SET ";
               
            sqlQuery += "instructorFirstName='" + i.instructorFirstName + "','";
            sqlQuery += "instructorLastName='" + i.instructorLastName + "','";
            sqlQuery += "instructorEmail='" + i.instructorEmail + "','";
            sqlQuery += "instructorSubject='" + i.instructorSubject + 
                "'WHERE instructorID=" + i.instructorID;
     

            SqlCommand cmdInstructorRead = new SqlCommand();
           cmdInstructorRead.Connection = new SqlConnection();
            cmdInstructorRead.Connection = SchoolDBConnection;
            cmdInstructorRead.Connection.ConnectionString = SchoolDBConnString;
            cmdInstructorRead.CommandText = sqlQuery;

            cmdInstructorRead.Connection.Open();

            cmdInstructorRead.ExecuteNonQuery();
        }

        public static SqlDataReader OfficeHoursReader()
        {
            SqlCommand cmdOHRead = new SqlCommand();
            cmdOHRead.Connection = SchoolDBConnection;
            cmdOHRead.Connection.ConnectionString = SchoolDBConnString;
            cmdOHRead.CommandText = "SELECT * FROM OfficeHours";

            cmdOHRead.Connection.Open();

            SqlDataReader tempReader = cmdOHRead.ExecuteReader();

            return tempReader;


        }

        public static SqlDataReader SingleOfficeHoursReader(int instructorID)
        {
            SqlCommand cmdOHRead = new SqlCommand();
            cmdOHRead.Connection= SchoolDBConnection;
            cmdOHRead.Connection.ConnectionString = SchoolDBConnString;
            cmdOHRead.CommandText = "SELECT * FROM OfficeHours WHERE instructorID = " + instructorID;
            cmdOHRead.Connection.Open();

            SqlDataReader tempReader = cmdOHRead.ExecuteReader();

            return tempReader;
        }

        public static SqlDataReader OfficeHoursInstructorReader()
        {
            SqlCommand cmdOHRead = new SqlCommand();
            cmdOHRead.Connection = SchoolDBConnection;
            cmdOHRead.Connection.ConnectionString = SchoolDBConnString;
            cmdOHRead.CommandText = "SELECT oh.ohDate, oh.ohTimes, oh.ohLocation, oh.ohWaitLocation FROM OfficeHours oh," +
                " Instructor i WHERE oh.instructorID = i.instructorID";

            cmdOHRead.Connection.Open();

            SqlDataReader tempReader = cmdOHRead.ExecuteReader();

            return tempReader;


        }



        public static SqlDataReader CredentialsReader()
        {
            SqlCommand cmdCredRead = new SqlCommand();
            cmdCredRead.Connection = SchoolDBConnection;
            cmdCredRead.Connection.ConnectionString = SchoolDBConnString;
            cmdCredRead.CommandText = "SELECT * FROM Credentials";

            cmdCredRead.Connection.Open();

            SqlDataReader tempReader = cmdCredRead.ExecuteReader();

            return tempReader;


        }
        public static SqlDataReader meetingReader()
        {
            SqlCommand cmdmRead = new SqlCommand();
            cmdmRead.Connection = SchoolDBConnection;
            cmdmRead.Connection.ConnectionString = SchoolDBConnString;
            cmdmRead.CommandText = "SELECT * FROM Meeting";

            cmdmRead.Connection.Open();

            SqlDataReader tempReader = cmdmRead.ExecuteReader();

            return tempReader;


        }
       
        public static SqlDataReader ClassReader()
        {
            SqlCommand cmdClassRead = new SqlCommand();
            cmdClassRead.Connection = SchoolDBConnection;
            cmdClassRead.Connection.ConnectionString = SchoolDBConnString;
            cmdClassRead.CommandText = "SELECT * FROM Class";

            cmdClassRead.Connection.Open();

            SqlDataReader tempReader = cmdClassRead.ExecuteReader();

            return tempReader;


        }

        public static void InsertInstructor(Instructor i)
        {
            String sqlQuery = "Insert INTO Instructor (instructorFirstName, instructorLastName, instructorEmail, personType, instructorSubject, credentialsID) VALUES (" + "'";
            sqlQuery += i.instructorFirstName + "','";
            sqlQuery += i.instructorLastName + "','";
            sqlQuery += i.instructorEmail + "','";
            sqlQuery += "I" + "','";
            sqlQuery += i.instructorSubject + "',";
            sqlQuery += SingleCredentialReader() + ")";

            SqlCommand cmdInstructorRead = new SqlCommand();
            cmdInstructorRead.Connection = SchoolDBConnection;
            cmdInstructorRead.Connection.ConnectionString = SchoolDBConnString;
            cmdInstructorRead.CommandText = sqlQuery;

            cmdInstructorRead.Connection.Open();
            
            cmdInstructorRead.ExecuteNonQuery();
        }

        public static void InsertOfficeHours(OfficeHours OH)
        {
            String sqlQuery = "Insert INTO OfficeHours (ohDate, ohTimes, ohLocation, ohWaitLocation, instructorID) VALUES (" + "'";
            sqlQuery += OH.ohDate + "','";    
            sqlQuery += OH.ohTimes + "','";
            sqlQuery += OH.ohLocation + "','";
            sqlQuery += OH.ohWaitLocation + "','";
            sqlQuery += OH.instructorID + "')";

            SqlCommand cmdOHRead = new SqlCommand();
            cmdOHRead.Connection = SchoolDBConnection;
            cmdOHRead.Connection.ConnectionString = SchoolDBConnString;
            cmdOHRead.CommandText = sqlQuery;

            cmdOHRead.Connection.Open();
            
            cmdOHRead.ExecuteNonQuery();
            
        }     
        public static void InsertMeeting(Meeting m)
        {
            String sqlQuery = "Insert INTO Meeting (meetingName, scheduleMeetingDate, scheduledMeetingTime, meetingPurpose, instructorID, studentID) VALUES (" + "'";
            sqlQuery += m.meetingName + "','";    
            sqlQuery += m.scheduleMeetingDate + "','";
            sqlQuery += m.scheduledMeetingTime + "','";
            sqlQuery += m.meetingPurpose + "','";
            sqlQuery += m.instructorID + "','";
            sqlQuery += m.studentID + "')";

            SqlCommand cmdmRead = new SqlCommand();
            cmdmRead.Connection = SchoolDBConnection;
            cmdmRead.Connection.ConnectionString = SchoolDBConnString;
            cmdmRead.CommandText = sqlQuery;

            cmdmRead.Connection.Open();
            cmdmRead.ExecuteNonQuery();
            
        }
        
        public static void InsertClass(Class c)
        {
            String sqlQuery = "Insert INTO Class (className, classDescription, classLocation, instructorID) VALUES ("+ "'";
            sqlQuery += c.className + "','";
            sqlQuery += c.classDescription + "','";
            sqlQuery += c.classLocation + "','";
          //   sqlQuery += i.instructorID + "')";

            SqlCommand cmdClassRead = new SqlCommand();
            cmdClassRead.Connection = SchoolDBConnection;
            cmdClassRead.Connection.ConnectionString = SchoolDBConnString;
            cmdClassRead.CommandText = sqlQuery;

            cmdClassRead.Connection.Open();
            cmdClassRead.ExecuteNonQuery();
        }

        public static void InsertStudent(Student s)
        {

            String sqlQuery = "Insert INTO Student (studentFirstName,studentLastName,studentEmail, personType, studentPhone, studentPartnerID) VALUES (" + "'";
            sqlQuery += s.studentFirstName + "','";
            sqlQuery += s.studentLastName + "','";
            sqlQuery += s.studentEmail + "','";
            sqlQuery += "S" + "','";
            sqlQuery += s.studentPhone + "',";
            sqlQuery += s.studentPartnerID + ")";

            SqlCommand cmdStudentRead = new SqlCommand();
            cmdStudentRead.Connection = SchoolDBConnection;
            cmdStudentRead.Connection.ConnectionString = SchoolDBConnString;
            cmdStudentRead.CommandText = sqlQuery;

            cmdStudentRead.Connection.Open();
            cmdStudentRead.ExecuteNonQuery();
        }
        public static void InsertCredentials(Credentials c)
        {

            String sqlQuery = "Insert INTO Credentials (Username, Password) VALUES (" + "'";
           
            sqlQuery += c.Username + "','";
            sqlQuery += c.Password + "')";
          

            SqlCommand cmdCredentialRead = new SqlCommand();
            cmdCredentialRead.Connection = SchoolDBConnection;
            cmdCredentialRead.Connection.ConnectionString = SchoolDBConnString;
            cmdCredentialRead.CommandText = sqlQuery;

            cmdCredentialRead.Connection.Open();
            cmdCredentialRead.ExecuteNonQuery();
        }

        public static int LoginQuery(string loginQuery)
        {
            // This method expects to receive an SQL SELECT
            // query that uses the COUNT command.
            SqlCommand cmdLogin = new SqlCommand();
            cmdLogin.Connection = SchoolDBConnection;
            cmdLogin.Connection.ConnectionString = SchoolDBConnString;
            cmdLogin.CommandText = loginQuery;
            cmdLogin.Connection.Open();
            // ExecuteScalar() returns back data type Object
            // Use a typecast to convert this to an int.
            // Method returns first column of first row.
            int rowCount = (int)cmdLogin.ExecuteScalar();
            return rowCount;
        }


        public static int SecureLogin(string Username, string Password)
        {
            String loginQuery = "SELECT COUNT(*) FROM Credentials where Username = @Username and Password = @Password";

            SqlCommand cmdLogin= new SqlCommand();
            cmdLogin.Connection = SchoolDBConnection;
            cmdLogin.Connection.ConnectionString = SchoolDBConnString;
            cmdLogin.CommandText = loginQuery;
            cmdLogin.Parameters.AddWithValue("@Username", Username);
            cmdLogin.Parameters.AddWithValue("@Password", Password);

            cmdLogin.Connection.Open();
            int rowCount = (int)cmdLogin.ExecuteScalar();
            return rowCount;
        }

        public static void ListMeetings(Meeting m)
        {
            String sqlQuery = "Select m.meetingName, m.scheduleMeetingDate, m.scheduledMeetingTime, m.meetingPurpose From Meeting m, Student s Where s.studentID = m.studentID";
            SqlCommand cmdlmRead= new SqlCommand();
            cmdlmRead.Connection = SchoolDBConnection;
            cmdlmRead.Connection.ConnectionString = SchoolDBConnString;
            cmdlmRead.CommandText = sqlQuery;

            cmdlmRead.Connection.Open();
            cmdlmRead.ExecuteNonQuery();

        }
    }
}
