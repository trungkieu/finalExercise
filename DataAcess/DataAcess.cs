using System;
using System.Data.SqlClient;

namespace DataAcess
{
    public class ServerSQL
    {
        private SqlConnection sqlConnection = new SqlConnection();
        public ServerSQL() { }

        public ServerSQL(String address)
        {
            sqlConnection.ConnectionString = address;
        }

        public void connect(String address)
        {
            sqlConnection.ConnectionString = address;
            try
            {
                sqlConnection.Open();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public SqlDataAdapter ExecuteQueryAdapter(String cmd, String address)
        {
            sqlConnection.ConnectionString = address;
            return ExecuteQueryAdapter(cmd);
        }

        public SqlDataAdapter ExecuteQueryAdapter(String cmd)
        {
            
            try
            {
                sqlConnection.Open();
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, sqlConnection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                return adapter;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public SqlDataReader ExecuteQuery(String cmd, String address)
        {
            sqlConnection.ConnectionString = address;
            return ExecuteQuery(cmd);
        }

        public SqlDataReader ExecuteQuery(String cmd)
        {

            try
            {
                sqlConnection.Open();

                SqlCommand builder = new SqlCommand(cmd, sqlConnection);
                SqlDataReader reader = builder.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int ExecuteScalar(String cmd, String address)
        {
            sqlConnection.ConnectionString = address;
            return executeScalar(cmd);
        }

        public int executeScalar(String cmd)
        {            
            try
            {
                sqlConnection.Open();

                SqlCommand cmdSQL = new SqlCommand(cmd, sqlConnection);
                Object result = cmdSQL.ExecuteScalar();

                return (int) result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public int ExecuteNonQuery(String cmd, String address)
        {
            sqlConnection.ConnectionString = address;
            return ExecuteNonQuery(cmd);
        }

        public int ExecuteNonQuery(String cmd)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmdSQL = new SqlCommand(cmd, sqlConnection);
                int result = cmdSQL.ExecuteNonQuery();

                return (int)result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int DeleteRow(String cmd, String address)
        {
            sqlConnection.ConnectionString = address;
            return DeleteRow(cmd);
        }

        public int DeleteRow(String cmd)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand cmdSQL = new SqlCommand(cmd, sqlConnection);
                int result = cmdSQL.ExecuteNonQuery();

                return (int)result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
