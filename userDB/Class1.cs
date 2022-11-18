using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using userDB;
using userschema;
using System.Data;

namespace userDB
{
    public class Class1
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["intrn"].ToString());
       
        public int InserData(userschema.Class1 objschema)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand("threetier", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@name", objschema.Name);
                    cmd.Parameters.AddWithValue("@email", objschema.Email);
                    cmd.Parameters.AddWithValue("@password", objschema.Password);
                    cmd.Parameters.AddWithValue("@mobile", objschema.Mobile);
                    cmd.Parameters.AddWithValue("@gender", objschema.Gender);
                    cmd.Parameters.AddWithValue("@usertype", "user");
                    cmd.Parameters.AddWithValue("@image", "/image/HD-wallpaper-virat-kohli-king-kohli-virat.jpg");
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int results = cmd.ExecuteNonQuery();
                    con.Close();
                    return results;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int UpdateData(int id,string name,string email,string mobile,string gender)
              {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("threetier", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Userupdate");
                    cmd.Parameters.AddWithValue("@Id",Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
        public int adminupdate(int id,string name,string mobile,string gender,string usertype,string image)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("threetier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "admupdate");
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mobile",mobile);
            cmd.Parameters.AddWithValue("@gender",gender);
            cmd.Parameters.AddWithValue("@usertype",usertype);
            cmd.Parameters.AddWithValue("@image",image);
            if (con.State.Equals(ConnectionState.Closed)) con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int uppic(int id,string image)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("threetier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "imageup");
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@image", image);
            if (con.State.Equals(ConnectionState.Closed)) con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public DataSet FindRecord(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("threetier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "show");
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
                dt.Fill(ds);
                return ds;
            }
   
        public int changepass(int id,string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("threetier", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "change");
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@password", password);
            if (con.State.Equals(ConnectionState.Closed)) con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }  
          
        public DataSet profilepic(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("threetier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@Action", "image");  
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            return ds;
        }
        

        public DataSet log(string name, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("threetier", con);
            cmd.CommandType =CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "login");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds;
        }
        public DataTable BindGrid(int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("threetier", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "get_user");
                    cmd.Parameters.AddWithValue("@id",Convert.ToInt32(id));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet BindGrid1(int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("threetier", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "admin");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }

}
