using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NewsWebApp.Models
{
    public class NewsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class NewsCategoryDAO
    {
        private string ConnectionString;
        public NewsCategoryDAO(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<NewsCategory> GetAll()
        {
            var list = new List<NewsCategory>();
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM NewsCategory", conn);
            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(new NewsCategory
                {
                    Id = (int)table.Rows[i]["id"],
                    Name = (string)table.Rows[i]["name"]
                });
            }
            conn.Close();

            return list;
        }

        public NewsCategory GetById(int id)
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            var cmd = new SqlCommand($"SELECT * FROM NewsCategory WHERE id = {id}", conn);
            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                return new NewsCategory
                {
                    Id = (int)table.Rows[0]["id"],
                    Name = (string)table.Rows[0]["name"]
                };
            }
            conn.Close();

            return null;
        }
    }
}