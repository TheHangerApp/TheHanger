using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;


public class UserDataAccess
{

    string connectionString = System.Configuration.ConfigurationManager.AppSettings["connString"];
    SqlConnection connection;
    public UserDataAccess()
    {
        OpenConnection(connectionString);
    }

    private bool OpenConnection(string pConnString)
    {
        connection = new SqlConnection(pConnString);
        connection.Open();
        if (connection.State == ConnectionState.Open)
            return true;
        else return false;
    }

    private void CloseConnection()
    {
        if (connection.State != ConnectionState.Closed)
            connection.Close();
    }

   


}