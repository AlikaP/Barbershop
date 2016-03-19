using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace Barbershop
{
    class DB_Access
    {
        //int point = 0;

        public SqlConnection conn;

        public DB_Access()
        {
            conn = DB_Connection.GetConnection();
        }

        public DataSet ViewCustomers()
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Id, Name AS Ime, Surname AS Prezime, Phone AS Kontakt, Points AS Bodovi, Status AS 'Gratis šišanje' FROM Customer";
            //cmd.ExecuteNonQuery();

            DB_Sql h = new DB_Sql();
            var cmd = h.GetSql("SELECT Id, Name AS Ime, Surname AS Prezime, Phone AS Kontakt, Points AS Bodovi, Status AS 'Gratis šišanje' FROM Customer", 1, null, false);

            //popunjavanje dataseta podacima (za datagridview)
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Customer");

            //conn.Close();

            return ds;

        }

        public void AddNewCustomer(string name, string surname, string phone)
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "INSERT INTO Customer (Name, Surname, Phone, Points, Status) VALUES(@name, @surname, @phone, 0, 0)";
            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Parameters.AddWithValue("@surname", surname);
            //cmd.Parameters.AddWithValue("@phone", phone);
            //cmd.ExecuteNonQuery();

            //conn.Close();

            object[,] array = new object[3, 2];
            array[0, 0] = "@name";
            array[0, 1] = name;

            array[1, 0] = "@surname";
            array[1, 1] = surname;

            array[2, 0] = "@phone";
            array[2, 1] = phone;

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql("INSERT INTO Customer (Name, Surname, Phone, Points, Status) VALUES(@name, @surname, @phone, 0, 0)", 1, array, true);

                        
        }


        public void UpdateCustomer(string name, string surname, string phone, int id)
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "UPDATE Customer SET Name=@name, Surname=@surname, Phone=@phone WHERE Id=@id";
            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Parameters.AddWithValue("@surname", surname);
            //cmd.Parameters.AddWithValue("@phone", phone);
            ////cmd.Parameters.AddWithValue("@points", 0);
            ////cmd.Parameters.AddWithValue("@status", 0);
            //cmd.Parameters.AddWithValue("@id", id);
            //cmd.ExecuteNonQuery();

            object[,] array = new object[4, 2];
            array[0, 0] = "@name";
            array[0, 1] = name;

            array[1, 0] = "@surname";
            array[1, 1] = surname;

            array[2, 0] = "@phone";
            array[2, 1] = phone;

            array[3, 0] = "@id";
            array[3, 1] = id;

            //array[3, 0] = "@points";
            //array[3, 1] = 0;

            //array[4, 0] = "@status";
            //array[4, 1] = 0;

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql("UPDATE Customer SET Name=@name, Surname=@surname, Phone=@phone WHERE Id=@id", 1, array, true);


            conn.Close();
        }

        public void DeleteCustomer(int id)
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "DELETE FROM Service WHERE CustomerId=@id; DELETE FROM Customer WHERE Id=@id;";
            //cmd.Parameters.AddWithValue("@id", id);
            //cmd.ExecuteNonQuery();

            object[,] array = new object[1, 2];
            array[0, 0] = "@id";
            array[0, 1] = id;

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql("DELETE FROM Service WHERE CustomerId=@id; DELETE FROM Customer WHERE Id=@id;", 1, array, true);

            conn.Close();
        }

        

        public int GetPoint()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "SELECT NumPoints FROM Settings;";
            var numPoints = (int)cmd1.ExecuteScalar();

            cmd1.Dispose();

            //conn.Close();

            return numPoints;
        }



        public void GivePoint(int id, int point, DateTime date)
        {

            //int active = 1;
            int status = 0;
            int numPoints = 1;


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            //DateTime date;

            

            //upis novog retka za pripadnu mušteriju u Service
            cmd.CommandText = "INSERT INTO Service (CustomerId, Active, Date) VALUES (@customerId, '1', @date);";
            cmd.Parameters.AddWithValue("@customerId", id);
            cmd.Parameters.AddWithValue("@date", date);

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.Connection = conn;
            cmd2.CommandType = CommandType.Text;

            //br. redaka 
            cmd2.CommandText = "SELECT COUNT(*) FROM Service WHERE (Active LIKE '1') AND (CustomerId = @id);";
            cmd2.Parameters.AddWithValue("@id", id);
            var count = (int)cmd2.ExecuteScalar();

            //stvori se red u Services, dodaje se bod mušteriji
            //za sedmi redak se points postavlja na 0
            //SqlCommand cmd1 = conn.CreateCommand();
            //cmd1.Connection = conn;
            //cmd1.CommandType = CommandType.Text;

            //cmd1.CommandText = "SELECT NumPoints FROM Settings;";
            //numPoints = (int)cmd1.ExecuteScalar();

            numPoints = this.GetPoint();

            //conn.Open();

            if (count < (numPoints))
            {
                point++;
            }
            else if (count == (numPoints)) //ako je sedam aktivnih redaka, sve ih postaviti kao neaktivne
            {
                //active = 0;
                status = 1;
                point = 0;

                cmd2.CommandText = "UPDATE Service SET Active='0'";
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                this.GetFreeServiceSound();
                
                MessageBox.Show("Mušterija ima pravo na gratis šišanje!");
                
                    
                
            }

            

            SqlCommand cmd3 = conn.CreateCommand();
            cmd3.Connection = conn;
            cmd3.CommandType = CommandType.Text;

            //upis boda mušteriji
            cmd3.CommandText = "UPDATE Customer SET Points = @points, Status = @status WHERE @Id=id";
            cmd3.Parameters.AddWithValue("@id", id);
            cmd3.Parameters.AddWithValue("@points", point);
            cmd3.Parameters.AddWithValue("@status", status);
            cmd3.ExecuteNonQuery();
            cmd3.Dispose();

            //conn.Close();
        }

        public DataSet SearchCustomer(string name, string surname)
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;

            string sqlString;

            if (String.IsNullOrEmpty(name))
            {
                sqlString = "SELECT * FROM Customer WHERE (Surame=@surname)";

            }
            else if(String.IsNullOrEmpty(surname))
            {
                sqlString = "SELECT * FROM Customer WHERE (Name=@name)";
            }
            else
            {
                sqlString = "SELECT * FROM Customer WHERE (Name=@name) AND (Surname=@surname)";
                
            }


            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Parameters.AddWithValue("@surname", surname);

            //cmd.ExecuteNonQuery();

            object[,] array = new object[2, 2] { { "@name", name }, { "@surname", surname } };
            

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql(sqlString, 1, array, true);

            //popunjavanje dataseta podacima (za datagridview)
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Customer");

            conn.Close();

            return ds;
            
        }

        public void SetNumPoints(int numPoints, int sound)
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "UPDATE Settings SET NumPoints=@numPoints, SoundCheck=@sound WHERE Id=1";          
            //cmd.Parameters.AddWithValue("@numPoints", numPoints);
            //cmd.Parameters.AddWithValue("@sound", sound);
            //cmd.ExecuteNonQuery();

            object[,] array = new object[2, 2];
            array[0, 0] = "@numPoints";
            array[0, 1] = numPoints;

            array[1, 0] = "@sound";
            array[1, 1] = sound;

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql("UPDATE Settings SET NumPoints=@numPoints, SoundCheck=@sound WHERE Id=1", 1, array, true);

            conn.Close();
        }

        public string[] GetOwnerData()
        {

            string[] owner = new string[7];

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand cmd = conn.CreateCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Owner WHERE Id=1";  //mora biti id

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
                
            owner[0] = reader["Company"].ToString();
            owner[1] = reader["OwnerName"].ToString();
            owner[2] = reader["OwnerSurname"].ToString();
            owner[3] = reader["City"].ToString();
            owner[4] = reader["Adress"].ToString();
            owner[5] = reader["HomeNum"].ToString();
            owner[6] = reader["PostCode"].ToString();

            //kada se šalje reader, ne radi

            conn.Close();

            return owner;
        }



        public void UpdateOwnerData(string company,
            string ownerName,
            string ownerSurname,
            string city,
            string address,
            string postCode,
            string homeNum)
        {


            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "UPDATE Owner SET Company=@company, OwnerName=@ownerName, OwnerSurname=@ownerSurname, City=@city, Adress=@address, PostCode=@postCode, HomeNum=@homeNum WHERE Id=1";
            //cmd.Parameters.AddWithValue("@company", company);
            //cmd.Parameters.AddWithValue("@ownerName", ownerName);
            //cmd.Parameters.AddWithValue("@ownerSurname", ownerSurname);
            //cmd.Parameters.AddWithValue("@city", city);
            //cmd.Parameters.AddWithValue("@address", address);
            //cmd.Parameters.AddWithValue("@postCode", postCode);
            //cmd.Parameters.AddWithValue("@homeNum", homeNum);
            //cmd.ExecuteNonQuery();

            object[,] array = new object[7, 2];
            array[0, 0] = "@company";
            array[0, 1] = company;

            array[1, 0] = "@ownerName";
            array[1, 1] = ownerName;

            array[2, 0] = "@ownerSurname";
            array[2, 1] = ownerSurname;

            array[3, 0] = "@city";
            array[3, 1] = city;

            array[4, 0] = "@address";
            array[4, 1] = address;

            array[5, 0] = "@postCode";
            array[5, 1] = postCode;

            array[6, 0] = "@homeNum";
            array[6, 1] = homeNum;

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql("UPDATE Owner SET Company=@company, OwnerName=@ownerName, OwnerSurname=@ownerSurname, City=@city, Adress=@address, PostCode=@postCode, HomeNum=@homeNum WHERE Id=1", 1, array, true);

            conn.Close();
        }

        public DataSet ViewDates(int id)
        {
            //if (conn.State.ToString() == "Closed")
            //{
            //    conn.Open();
            //}

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT Date AS 'Datum pružene usluge' FROM Service WHERE CustomerId=@id AND Active='1'";
            //cmd.Parameters.AddWithValue("@id", id);
            //cmd.ExecuteNonQuery();

            //popunjavanje dataseta podacima (za datagridview)

            object[,] array = new object[1, 2];
            array[0, 0] = "@id";
            array[0, 1] = id;           

            DB_Sql sql = new DB_Sql();
            var cmd = sql.GetSql("SELECT Date AS 'Datum pružene usluge' FROM Service WHERE CustomerId=@id AND Active='1'", 1, array, true);


            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Service");

            conn.Close();

            return ds;

        }



        public bool SoundStatus()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand cmd = conn.CreateCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SoundCheck FROM Settings";
            var soundStatus = (bool)cmd.ExecuteScalar();

            //conn.Close();

            return soundStatus;
                        
        }


        public void GetSound()
        {
            if (SoundStatus())
            {
                var sound = "C:\\Users\\Alen\\Documents\\Visual Studio 2015\\Projects\\Barbershop\\Tiny.wav";
                SoundPlayer player = new SoundPlayer(sound);

                player.Play();
            }
        }
      

        public void GetHoverSound()
        {
            if (SoundStatus())
            {
                var sound = "C:\\Users\\Alen\\Documents\\Visual Studio 2015\\Projects\\Barbershop\\button20.wav";
                SoundPlayer player = new SoundPlayer(sound);

                player.Play();
            }
        }

        public void GetFreeServiceSound()
        {
            if (SoundStatus())
            {
                var sound = "C:\\Users\\Alen\\Documents\\Visual Studio 2015\\Projects\\Barbershop\\magic-chime-01.wav";
                SoundPlayer player = new SoundPlayer(sound);

                player.Play();
            }
        }

    }
        
}
