using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240045.model
{
    class Barang
    {
        Koneksi koneksi = new Koneksi();

        // INSERT
        public void Insert(M_barang m)
        {
            string query = "INSERT INTO t_barang (nama_barang, harga) VALUES (@nama, @harga)";
            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@nama", m.NamaBarang);
            cmd.Parameters.AddWithValue("@harga", m.Harga);
            cmd.ExecuteNonQuery();
        }

        // UPDATE
        public void Update(M_barang m, string id)
        {
            string query = "UPDATE t_barang SET nama_barang=@nama, harga=@harga WHERE id_barang=@id";
            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@nama", m.NamaBarang);
            cmd.Parameters.AddWithValue("@harga", m.Harga);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void Delete(string id)
        {
            string query = "DELETE FROM t_barang WHERE id_barang=@id";
            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public DataTable Show()
        {
            string query = "SELECT * FROM t_barang";
            return (DataTable)koneksi.ShowData(query);
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT * FROM t_barang WHERE nama_barang LIKE @param";
            return (DataTable)koneksi.ShowDataParam(
                query,
                new MySqlParameter("@param", "%" + keyword + "%")
            );
        }

    }
}

