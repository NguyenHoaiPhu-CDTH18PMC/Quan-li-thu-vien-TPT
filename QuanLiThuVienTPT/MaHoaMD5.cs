using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiThuVienTPT
{
    public static class MaHoaMD5
    {

        public static string ConvertMD5(this string mahoa)
        {
            string convertMD5 = "";
            byte[] A = Encoding.UTF8.GetBytes(mahoa);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            A = md5.ComputeHash(A);
            for (int i = 0; i < A.Length; i++)
            {
                convertMD5 = convertMD5 + A[i].ToString("x2");
            }
            return convertMD5;
        }
    }
    /*ALTER TABLE NHANVIEN
    ALTER COLUMN MK varchar(200)*/
}
