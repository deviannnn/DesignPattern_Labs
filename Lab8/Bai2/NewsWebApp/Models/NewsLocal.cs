using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace NewsWebApp.Models
{
    public class NewsLocal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
    }

    public class NewsLocalDAO
    {
        private string ConnectionString;
        public NewsLocalDAO(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<NewsLocal> GetAll(int categoryId = 0, int count = 6)
        {
            var list = new List<NewsLocal>();
            var conn = new SqlConnection(ConnectionString);
            conn.Open();

            var sql = "SELECT * FROM NewsLocal ";
            if (count > 0)
            {
                sql = $"SELECT TOP {count} * FROM NewsLocal ";
            }
            if (categoryId > 0)
            {
                sql += $"WHERE category_id = {categoryId}";
            }

            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(new NewsLocal
                {
                    Id = (int)table.Rows[i]["id"],
                    Title = (string)table.Rows[i]["title"],
                    Content = (string)table.Rows[i]["content"],
                    CategoryId = (int)table.Rows[i]["category_id"],
                });
            }
            conn.Close();

            return list;
        }

        public NewsLocal GetById(int id)
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            var cmd = new SqlCommand($"SELECT * FROM NewsLocal WHERE id = {id}", conn);
            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return new NewsLocal
                {
                    Id = (int)table.Rows[0]["id"],
                    Title = (string)table.Rows[0]["title"],
                    Content = (string)table.Rows[0]["content"],
                };
            }
            conn.Close();

            return null;
        }
    }

}