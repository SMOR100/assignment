using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    class DatabaseConnection
    {
        //Attributes
        private static DatabaseConnection _instance;

        private static string _connectionToStr;

        private SqlConnection _connectionToDB;

        private SqlDataAdapter _dataAdapter;



        public static string ConnectionToString
        {
            set
            {
                _connectionToStr = value;
            }
        }

        //Methods
        public static DatabaseConnection getInstance()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();

            return _instance;
        } 

        //Open connection to DB
        public void openConnection()
        {
            _connectionToDB = new SqlConnection(_connectionToStr);
            _connectionToDB.Open();
        }

        //Close connection
        public void closeConnection()
        {
            _connectionToDB.Close();
        }

        public DataSet getDataSet (String sqlStatement)
        {
            DataSet dataSet = new DataSet();
            openConnection();
            _dataAdapter = new SqlDataAdapter(sqlStatement, _connectionToDB);
            _dataAdapter.Fill(dataSet);
            closeConnection();
            return dataSet;
        }

        public int insert(string sqlQuery )
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //command.Parameters.Add(new SqlParameter("Name", name));
            //command.Parameters.Add(new SqlParameter("Age", age));

            openConnection();
            command.Connection = _connectionToDB;

            int noRows = command.ExecuteNonQuery();

            closeConnection();
           
            return noRows;
           
        }


    }
}
