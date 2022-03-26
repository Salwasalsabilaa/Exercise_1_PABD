using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercisee
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-2K0H9VP\\SALWA;database=ExerciseKue;User ID=sa;Password=123456");
                con.Open();

                SqlCommand cm = new SqlCommand(
                    //Insert Data Table Kue
                    "insert into Kue (Kode_Kue, Jenis_Kue, Harga, Stock) values('K0011', 'Cheesecake', '45000', '24')" +
                    "insert into Kue(Kode_Kue, Jenis_Kue, Harga, Stock)values('K0012', 'RedVelvet', '55000', '20')" +
                    "insert into Kue (Kode_Kue, Jenis_Kue, Harga, Stock)values('K0013', 'BlackForest', '65000', '20')" +
                    "insert into Kue(Kode_Kue, Jenis_Kue, Harga, Stock)values('K0014', 'OreoCookies', '55000', '10')" +
                    "insert into Kue (Kode_Kue, Jenis_Kue, Harga, Stock)values('K0015', 'Rainbow', '55000', '5')" +
                    "insert into Karyawan(Id_Karyawan, Nama_Karyawan, Email) values('KR1101', 'Tifah', 'Tifah@mail.com')" +
                    "insert into Karyawan(Id_Karyawan, Nama_Karyawan, Email)values('KR1102', 'Riris', 'Riris@mail.com')" +
                    "insert into Karyawan(Id_Karyawan, Nama_Karyawan, Email)values('KR1103', 'Salwa', 'Salwa@mail.com')" +
                    "insert into Karyawan(Id_Karyawan, Nama_Karyawan, Email)values('KR1104', 'Beomgyu', 'Beomgyu@mail.com')" +
                    "insert into Karyawan(Id_Karyawan, Nama_Karyawan, Email)values('KR1105', 'Jake', 'Jake@mail.com')" +
                    "insert into Pembeli(Id_Pembeli, Nama_Pembeli, No_Telp, Alamat) values('P00101','Soobin','0181211111111','Ilsan')" +
                    "insert into Pembeli(Id_Pembeli, Nama_Pembeli, No_Telp, Alamat) values('P00102','Taehyun','0181211111112','Gangnam')" +
                    "insert into Pembeli(Id_Pembeli, Nama_Pembeli, No_Telp, Alamat) values('P00103','Jay','0181211111113','Jogja')" +
                    "insert into Pembeli(Id_Pembeli, Nama_Pembeli, No_Telp, Alamat) values('P00104','Dita','0181211111114','Bantul')" +
                    "insert into Pembeli(Id_Pembeli, Nama_Pembeli, No_Telp, Alamat) values('P00105','Karina','0181211111115','Jogja')" +
                    "insert into Transaksi(Kode_Transaksi, Tanggal_Transaksi, QTY_Pembelian, Total_Harga, Id_Karyawan, Id_Pembeli, Kode_Kue) values('TR1011', '2022-01-15', '2', '95000', 'KR1101', 'P00101', 'K0011')" +
                    "insert into Transaksi(Kode_Transaksi, Tanggal_Transaksi, QTY_Pembelian, Total_Harga, Id_Karyawan, Id_Pembeli, Kode_Kue) values('TR1012', '2022-01-16', '1', '90000', 'KR1102', 'P00102', 'K0012')" +
                    "insert into Transaksi(Kode_Transaksi, Tanggal_Transaksi, QTY_Pembelian, Total_Harga, Id_Karyawan, Id_Pembeli, Kode_Kue) values('TR1013', '2022-01-17', '2', '80000', 'KR1103', 'P00103', 'K0013')" +
                    "insert into Transaksi(Kode_Transaksi, Tanggal_Transaksi, QTY_Pembelian, Total_Harga, Id_Karyawan, Id_Pembeli, Kode_Kue) values('TR1014', '2022-01-18', '1', '85000', 'KR1104', 'P00104', 'K0014')" +
                    "insert into Transaksi(Kode_Transaksi, Tanggal_Transaksi, QTY_Pembelian, Total_Harga, Id_Karyawan, Id_Pembeli, Kode_Kue) values('TR1015', '2022-01-19', '3', '75000', 'KR1105', 'P00105', 'K0015')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
