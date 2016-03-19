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
    class DB_Sql
    {
        public SqlConnection conn;
        

        public SqlCommand GetSql(string sqlString, int caseSwitch2, object[,] array, bool i)
        {
            conn = DB_Connection.GetConnection();

            //object[,] k = array;
                        

            using (SqlCommand cmd = conn.CreateCommand())  // SqlCommand cmd = new SqlCommand("stored_procedure", conn)
            {
                if (conn.State.ToString() == "Closed")    
                {
                    conn.Open();
                }

                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    

                    cmd.Connection = conn;
                    cmd.Transaction = tr;
                    
                    cmd.CommandType = CommandType.Text;                        
                    
                    
                    cmd.CommandText = sqlString;

                    if (i)
                    {
                        //cmd.Parameters.AddWithValue(array[0, 0].ToString(), array[0, 1]);

                        //cmd.Parameters.AddWithValue(array[1, 0].ToString(), array[1, 1]);

                        //cmd.Parameters.AddWithValue(array[2, 0].ToString(), array[2, 1]);

                        for (int x = 0; x < array.GetLength(0); x += 1)
                        {
                            cmd.Parameters.AddWithValue(array[x, 0].ToString(), array[x, 1]);
                        }
                    }

                    

                    //foreach(a in b)
                    //{
                    //  cmd.Parameters.AddWithValue("@" + value, atribute);
                    //}                
             
                    //for (int x = 0; x < array.GetLength(0); x += 1)
                    //{
                    //    for (int y = 0; y < array.GetLength(1); y += 1)
                    //    {
                    //        Console.Write(array[x, y]);
                    //    }
                    //}

                    

                    switch (caseSwitch2)
                    {
                        case 1:
                            cmd.ExecuteNonQuery();
                            break;
                        case 2:
                            var count = (int)cmd.ExecuteScalar();                           
                            break;
                        case 3:
                            var count2 = (bool)cmd.ExecuteScalar();
                            break;

                    }

                    //some code
                    tr.Commit();

                    //tr.Dispose();
                }


                return cmd;

            }


            
        }
    }
}
