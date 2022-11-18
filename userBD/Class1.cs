using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userDB;

namespace userBD
{
    public class Class1
    {
        public int Insert(userschema.Class1 objSchema)
        {
            try
            {
                userDB.Class1 objdb = new userDB.Class1();
                return objdb.InserData(objSchema);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(int id,string name,string email,string mobile,string gender)
            {
                userDB.Class1 objdb =new userDB.Class1();
                return objdb.UpdateData(id,name,email,mobile,gender);
            }
        public int adminup(int id,string name,string mobile,string gender,string usertype,string image)
        {
            userDB.Class1 iddb =new userDB.Class1();
            return iddb.adminupdate(id,name,mobile,gender,usertype,image);
        }
        public DataSet show(int id)
        {
            userDB.Class1 objshow = new userDB.Class1();
            return objshow.FindRecord(id);
        }
      public int Change(int id,string password)
        {
            userDB.Class1 objchange = new userDB.Class1();
            return objchange.changepass(id,password);
        }   
       public int pic(int id,string image)
        {
            userDB.Class1 objpic = new userDB.Class1();
            return objpic.uppic(id,image);
        }
        public DataSet uppicture(int id)
        {
            userDB.Class1 objpic = new userDB.Class1();
            return objpic.profilepic(id);
        }
   public DataSet login(string name,string password)
        {
            userBD.Class1 objdb = new userBD.Class1();
            return objdb.login(name, password);
        }
        public DataTable BindGrid(int id)
        {
            try
            {
                userDB.Class1 objDal = new userDB.Class1();
                return objDal.BindGrid(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet BindGrid1(int id)
        {
            try
            {
                userDB.Class1 objdal = new userDB.Class1();
                return objdal.BindGrid1(id);
            }
            catch(Exception ex)
            {
                throw ex ;
            }
        }
    }
}
