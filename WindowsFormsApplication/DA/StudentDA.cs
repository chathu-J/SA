using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.BL;

namespace WindowsFormsApplication.DA
{
    class StudentDA
    {
        public string ConString = "Data Source=DC;Initial Catalog=test;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        DataTable dt = new DataTable();

        //get all users
        public DataTable GetAll()
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        //get specific user
        public DataTable Get(int Id)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where ID= " + Id + "", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        //create user
        public bool Create(StudentBL student)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Users(name,surname,age,address,username,password,category) values('" + student.Name + "','" + student.Surname + "','" + student.Age + "','" + student.Address + "','" + student.Username + "','" + student.Password + "','user')", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd != null)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }

            }
            catch
            {
                throw;
            }
        }

        //update user
        public bool Update(StudentBL student)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("update dbo.Users set name='" + student.Name + "' ,surname='" + student.Surname + "',age='" + student.Age + "',address='" + student.Address + "',username='" + student.Username + "',password='" + student.Password + "' where ID='"+student.Id+"'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                throw;
            }
        }

        //delete user
        public bool Delete(int id)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("delete from dbo.Users where ID='" + id + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                throw;
            }
        }
    }
}
