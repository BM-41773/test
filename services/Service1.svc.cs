using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string save(string id, string X_nme, string Prop,string  Mail ,string M,  string Add, string Location,string R)
        {
            int N_loginid = Convert.ToInt32(id);
            SqlConnection con=new SqlConnection("Data Source=DESKTOP-46KB8VH\\SQLEXPRESS;Initial Catalog=facebooklogin;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "select loginid,Name,propic,gender,Email,location,hoby,Passworde from Biodata  where Email= '" + Mail + "'";
            SqlDataReader rdr =cmd.ExecuteReader();


            while (rdr.Read())
            {
                id = rdr["loginid"].ToString();
                X_nme = rdr["Name"].ToString();
                Prop = rdr["propic"].ToString();
                M = rdr["gender"].ToString();
                Add = rdr["location"].ToString();
                R = rdr["hoby"].ToString();




            }
            con.Close();
            con.Open();
            cmd.CommandText = "insert into Biodata(loginid,Name,propic,gender,Email,location,hoby,Passworde from Biodata) values('" + id + "','" + X_nme + "','" + Prop + "','" + M + "','" + Add + "','" + R + "'";
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            string str = JsonConvert.SerializeObject(dt);

            return str;

           
        }

        //private string datatabletojson(DataTable dt)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
