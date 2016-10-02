using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.DA;

namespace WindowsFormsApplication.BL
{
    class StudentBL
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String surname;

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        String category;

        public String Category
        {
            get { return category; }
            set { category = value; }
        }

        //get all users
        public DataTable GetUsers()
        {
            try
            {
                StudentDA objdal = new StudentDA();
                return objdal.GetAll();
            }
            catch
            {
                throw;
            }
        }

        //get specific user
        public DataTable GetUser(int ID)
        {
            try
            {
                StudentDA objdal = new StudentDA();
                return objdal.Get(ID);
            }
            catch
            {
                throw;
            }
        }

        //create user
        public bool CreateUser(StudentBL student)
        {
            try
            {
                StudentDA objdal = new StudentDA();
                return objdal.Create(student);
            }
            catch
            {
                throw;
            }

        }

        //update user
            public bool UpdateUser(StudentBL student)
        {
            try
            {
                StudentDA objdal = new StudentDA();
                return objdal.Update(student);
            }
            catch
            {
                throw;
            }
        }

            //delete user
            public bool DeleteUser(int id)
            {
                try
                {
                    StudentDA objdal = new StudentDA();
                    return objdal.Delete(id);
                }
                catch
                {
                    throw;
                }
            }
      
    }
}
