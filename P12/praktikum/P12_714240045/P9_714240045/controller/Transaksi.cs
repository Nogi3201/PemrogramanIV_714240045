using MySql.Data.MySqlClient;
using P9_714240045.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace P9_714240045.controller
{
    class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        public DataTable Show()
        {
            string query = @"
        SELECT 
            t.id_transaksi,
            b.id_barang,
            b.nama_barang,
            b.harga,
            t.qty,
            t.total
        FROM t_transaksi t
        JOIN t_barang b ON t.id_barang = b.id_barang";

            return (DataTable)koneksi.ShowData(query);
        }


        public void Insert(int idBarang, int qty, int total)
        {
            string query = "INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id, @qty, @total)";
            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@id", idBarang);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.ExecuteNonQuery();
        }

        public void Delete(string id)
        {
            string query = "DELETE FROM t_transaksi WHERE id_transaksi=@id";
            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void Update(int idTransaksi, int idBarang, int qty, int total)
        {
            string query = @"UPDATE t_transaksi 
                     SET id_barang=@barang, qty=@qty, total=@total 
                     WHERE id_transaksi=@id";

            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@barang", idBarang);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@id", idTransaksi);

            cmd.ExecuteNonQuery();
        }

    }
}