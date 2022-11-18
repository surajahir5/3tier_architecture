using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userschema
{
    public class Class1
    {
        private string id;
        private string name;
        private string email;
        private string password;
        private string mobile;
        private string gender;

        public string Id { get { return id; } set { id = value; } }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value;  }
        }
        public string Mobile
        {
            get { return mobile; }
            set{ mobile = value; }
        }
        public String Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }
        //public string usertype
        //{
        //    get { return usertype; }  
        //    set
        //    {
        //        usertype = value;
        //    }
        //}
        //public string image
        //{
        //    get { return image; }
        //    set { image = value; }
        //}
    }
}

