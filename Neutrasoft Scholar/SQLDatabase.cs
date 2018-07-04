using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Neutrasoft_Scholar
{
    //This class provides all the methods for manipulating and reading from the SQL Server Database.
    class SQLDatabase
    {
        //Gives any SQLDatabase Method a SQLConnection.
        private static SqlConnection GetSQLConnectionString()
        {
            //Creates connection string.
            SqlConnection sqlConnection = new SqlConnection("user id=NeutrasoftScholarAccess;" + "password=gNJ2EoncGpR;" + "server=madaffri.com\\BASE;" + "Integrated Security=false;" + "Database=Neutrasoft Scholar;");
            return sqlConnection;
        }
        public static void WriteToSQLServer(string query)
        {
            SqlConnection sqlConnection = GetSQLConnectionString();
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(query, sqlConnection);

            //Executes query.
            command.ExecuteNonQuery();

            sqlConnection.Close();

        }
        public static Dictionary<string, List<string>> ReadFromSQLServer(string query, List<string> columns)
        {
            SqlConnection sqlConnection = GetSQLConnectionString();
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader dataReader = null;

            //Reads Data.
            dataReader = command.ExecuteReader();

            //Creates a Dictionary that holds a List of Strings(all the data) for one column.
            Dictionary<string, List<string>> dataRead = new Dictionary<string, List<string>>();

            foreach (string column in columns)
            {
                //Adds a key in the dictionary for each column
                dataRead.Add(column, new List<string>());
            }

            //Reads until all rows are read
            while (dataReader.Read())
            {
                //Reads through every key in the dictionary
                foreach (KeyValuePair<string, List<string>> item in dataRead)
                {
                    //Adds data from every column in this row and adds it to the list corresponding to the column.
                    dataRead[item.Key].Add(dataReader[item.Key].ToString());
                }

            }

            return dataRead;

        }
    }
}
