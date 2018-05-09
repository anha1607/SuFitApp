using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SuFitApp.Droid.DBClasses;
using Npgsql;

namespace SuFitApp.Droid.DBOperation
{
    public class DBconn
    {
        private NpgsqlConnection conn = new NpgsqlConnection("Server=horton.elephantsql.com; Port=5432; User Id=amnszqbm; Password=-G_Di_7kaJdyfHf4-KL9BPvDmLZ6r55d; Database=amnszqbm");
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;



        public List<Person> DBCall(List<Person> list)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM person";
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Person(dr["firstname"].ToString(), dr["lastname"].ToString()));
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}