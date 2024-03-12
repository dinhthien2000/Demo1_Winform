using Demo1.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.DAO 
{
    public class LopDAO : AbstractDAO<Lop>
    {

        //public static string SELECT = "Select * from SinhVien";
        //public static string CREATE = "INSERT INTO SinhVien (Masv ,HoTen ,Lop ,DiaChi ,NgaySinh ,Email ,NienKhoa ,Khoa ,GioiTinh)"+
        //                               "VALUES (N'' ,N'' ,N'' ,N'' ,N'' ,N'' ,N'' ,N'' ,N'')";
        //public static string UPDATE = "update SinhVien set "+
        //                                "Masv = @Masv,HoTen = @HoTen, Lop = @Lop, DiaChi = @DiaChi, NgaySinh = @NgaySinh, Email = @Email, NienKhoa = @NienKhoa, Khoa = @Khoa, GioiTinh = @GioiTinh";
        //public static string DELETE = "delete from SinhVien where Masv =@Masv";

        public static string SELECT = "Select * from Lop";
        public static string CREATE = "insert into Lop(MaLop,TenLop) values (@MaLop,@TenLop)";
        public static string UPDATE = "update Lop set TenLop = @TenLop where MaLop =@MaLop";
        public static string DELETE = "delete from Lop where MaLop =@MaLop";

        SqlConnection conn;

        public LopDAO()
        {
            conn = Connection.Connect.getConnection();
        }

        public List<Lop> getAll()
        {
            
            List<Lop> list = new List<Lop>();
            Lop lop = null;
            try { 
                conn.Open();

                Debug.WriteLine("Connected successful");

                SqlCommand command = new SqlCommand(SELECT, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lop = new Lop(
                        reader.GetString("MaLop"),
                        reader.GetString("TenLop")
                        );

                    list.Add(lop);
                }

            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public Lop insert(Lop t)
        {
            Lop recieve = null;
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand(CREATE, conn);

                command.Parameters.AddWithValue("MaLop", t.MaLop);
                command.Parameters.AddWithValue("TenLop", t.TenLop);

                int reader = command.ExecuteNonQuery();

                if (reader != 0)
                {
                    recieve = t;
                }
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return recieve;
        }

        public Lop upadte(Lop t)
        {
            Lop recieve = null;
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand(UPDATE, conn);

                command.Parameters.AddWithValue("MaLop", t.MaLop);
                command.Parameters.AddWithValue("TenLop", t.TenLop);

                int reader = command.ExecuteNonQuery();

                Debug.WriteLine(reader);
                if (reader > 0)
                {
                    recieve = t;
                }
                return recieve;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return recieve;
            }
            finally
            {
                
                conn.Close();
            }
        }



        public Lop remove(Lop t)
        {
            Lop remove = null;
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand(DELETE, conn);

                command.Parameters.AddWithValue("MaLop", t.MaLop);

                int reader = command.ExecuteNonQuery();

                if (reader > 1)
                {
                    remove = t;
                }
                return remove;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return remove;
            }
            finally
            {
                conn.Close();
            }
           
        }

        public Lop findById(String ma_lop)
        {
            List<Lop> list = new List<Lop>();
            Lop t = null;
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand($"Select * from Lop where MaLop = '{ma_lop}'",conn);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // t = (Lop)reader[0];
                        t = new Lop(reader.GetString("MaLop"), reader.GetString("TenLop"));
                        Debug.WriteLine("[]: "+reader["MaLop"] + " " + reader["TenLop"]);
                        Debug.WriteLine("(): "+reader.GetString(0)+ " "+ reader.GetString(1));
                    }
                    list.Add(t);
                    Debug.WriteLine(list[0]);
                }
                  

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return t;
        }

    }
}
