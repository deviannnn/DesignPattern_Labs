using DatabaseLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebAppQLSV.Models
{
    public class StudentDAO
    {
        public DatabaseFactory DatabaseFactory { get; set; }
        public StudentDAO(DatabaseFactory dbf)
        {
            DatabaseFactory = dbf;
        }

        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();
            var conn = DatabaseFactory.CreateConnection();
            conn.Open();
            var cmd = DatabaseFactory.CreateCommand("select * from Student", conn);
            var adap = DatabaseFactory.CreateDataAdapter(cmd);
            var table = new DataTable();
            adap.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(new Student(table.Rows[i]));
            }
            conn.Close();
            return list;
        }

        public Student GetByCode(string code)
        {
            Student student = null;
            try
            {
                var conn = DatabaseFactory.CreateConnection();
                conn.Open();
                var cmd = DatabaseFactory.CreateCommand("SELECT * FROM Student WHERE Code = @Code", conn);
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Code", code.Trim()));
                var reader = DatabaseFactory.CreateDataReader(cmd);
                if (reader.Read())
                {
                    student = new Student(reader);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return student;
        }

        public bool Create(Student student)
        {
            try
            {
                if (IsCodeExists(student.Code))
                {
                    return false;
                }

                var conn = DatabaseFactory.CreateConnection();
                conn.Open();
                var cmd = DatabaseFactory.CreateCommand("INSERT INTO Student (Code, Name, Birthday, Class) VALUES (@Code, @Name, @Birthday, @Class)", conn);
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Code", student.Code.Trim()));
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Name", student.Name.Trim()));
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Birthday", student.Birthday));
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Class", student.Class.Trim()));
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Update(Student student)
        {
            try
            {
                if (!IsCodeExists(student.Code))
                {
                    return false;
                }

                var conn = DatabaseFactory.CreateConnection();
                conn.Open();
                var cmd = DatabaseFactory.CreateCommand("UPDATE Student SET Name = @Name, Birthday = @Birthday, Class = @Class WHERE Code = @Code", conn);
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Name", student.Name.Trim()));
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Birthday", student.Birthday));
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Class", student.Class.Trim()));
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Code", student.Code.Trim()));
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(string code)
        {
            try
            {
                if (!IsCodeExists(code))
                {
                    return false;
                }

                var conn = DatabaseFactory.CreateConnection();
                conn.Open();
                var cmd = DatabaseFactory.CreateCommand("DELETE FROM Student WHERE Code = @Code", conn);
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Code", code.Trim()));
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool IsCodeExists(string code)
        {
            try
            {
                var conn = DatabaseFactory.CreateConnection();
                conn.Open();
                var cmd = DatabaseFactory.CreateCommand("SELECT COUNT(*) FROM Student WHERE Code = @Code", conn);
                cmd.Parameters.Add(DatabaseFactory.CreateParameter("@Code", code.Trim()));
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }
}