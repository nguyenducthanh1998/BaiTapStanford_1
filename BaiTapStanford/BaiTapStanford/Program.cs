using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapStanford
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------//
            //Bài tập 2: Viết câu lệnh nhập vào 4 giá trị 
            //lần lượt là số thực, nguyên, nguyên dài và kí
            //tự.In ra màn hình các giá trị này để kiểm tra.
            //float soThuc = 1.5f;
            //int soNguyen = 10;
            //long soNguyenDai = 219212912992929;
            //char kyTu = 'T';
            //Console.WriteLine(soThuc);
            //Console.WriteLine(soNguyen);
            //Console.WriteLine(soNguyenDai);
            //Console.WriteLine(kyTu);
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 3: Viết câu lệnh in ra màn hình các dòng sau(không kể các số thứ tự và dấu: ở
            //đầu mỗi dòng) 
            //1: Bộ Giáo dục
            //2: Đào tạo Cộng hoà xã hội chủ nghĩa Việt Nam
            //3: Sở Giáo dục Hà Nội Độc lập - Tự do -Hạnh phúc
            //Console.OutputEncoding = Encoding.UTF8;
            //string chuoi1 = "Bộ Giáo dục";
            //string chuoi2 = "Đào tạo Cộng hoà xã hội chủ nghĩa Việt Nam";
            //string chuoi3 = "Sở Giáo dục Hà Nội Độc lập - Tự do -Hạnh phúc";
            //Console.WriteLine(chuoi1);
            //Console.WriteLine(chuoi2);
            //Console.WriteLine(chuoi3);
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 4: Viết chương trình nhập vào một kí tự. 
            //In ra kí tự đó và mã ascii của nó.
            //char kyTu;
            //Console.Write("Nhap ky tu: ");
            //kyTu = Char.Parse(Console.ReadLine());
            //Console.WriteLine(kyTu);
            //Console.WriteLine(Convert.ToInt32(kyTu));
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 5: Viết chương trình nhập vào hai số thực. 
            //In ra hai số thực đó với 2 số lẻ và cách nhau 5 cột.
            //float a, b;
            //Console.Write("Nhap so a: ");
            //a = float.Parse(Console.ReadLine());
            //Console.Write("Nhap so b: ");
            //b = float.Parse(Console.ReadLine());
            //Console.WriteLine("{0}\t\t\t\t\t{1}", Math.Round(a,2), Math.Round(b,2));
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 6: Viết chương trình tính và in ra giá trị các biểu thức sau với 2 số lẻ: 

            //double result1, result2;

            //result1 = Math.Sqrt(3 + Math.Sqrt(3 + Math.Sqrt(3)));

            //result2 = 1 / (2 + (1 / (2 + (1 / 2))));
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 7: Nhập a, b, c là các số thực. 
            //In ra giá trị của các biểu thức sau với 3 số lẻ:
            //double a, b, c, result1, result2, result3, result4;
            //Console.Write("Nhap a: ");
            //a = Double.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = Double.Parse(Console.ReadLine());
            //Console.Write("Nhap c: ");
            //c = Double.Parse(Console.ReadLine());
            //result1 = a * a - 2 * b + (a * b) / c;
            //result2 = 3 * a - b * b * b - 2 * Math.Sqrt(c);
            //result3 = (b * b - 4 * a * c) / (2 * a);
            //result4 = Math.Sqrt((a * a) / (b - 4 * a) / (b * c + 1));
            //Console.WriteLine(Math.Round(result1, 3));
            //Console.WriteLine(Math.Round(result2, 3));
            //Console.WriteLine(Math.Round(result3, 3));
            //Console.WriteLine(Math.Round(result4, 3));
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 8: In ra tổng, tích, hiệu và thương
            //của 2 số được nhập vào từ bàn phím.
            //int a, b;
            //Console.Write("Nhap a: ");
            //a = Int32.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            //Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            //Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 9: In ra trung bình cộng, trung bình nhân
            //    của 3 số được nhập vào từ bàn phím
            //int a, b, c;
            //double trungBinhCong, trungBinhNhan;
            //Console.Write("Nhap a: ");
            //a = Int32.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = Int32.Parse(Console.ReadLine());
            //Console.Write("Nhap c: ");
            //c = Int32.Parse(Console.ReadLine());
            //trungBinhCong = (a + b + c) / 3;
            //trungBinhNhan = Math.Pow((a*b*c),1/3);
            //Console.WriteLine(trungBinhCong);
            //Console.WriteLine(trungBinhNhan);
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 10: Viết chương trình nhập cạnh, bán kính và in ra diện tích, chu vi của các hình:
            //hình vuông, hình chữ nhật, hình tròn.

            //Console.OutputEncoding = Encoding.UTF8;
            //double chieuDai, chieuRong, banKinh, dienTichHV, dienTichHCN, dienTichHT, chuViHV, chuViHCN, chuViHT;
            //double pi = 3.14;
            //Console.WriteLine("Mời chọn: ");
            //Console.WriteLine("1. Tính Chu vi, Diện tích hình chữ nhật!");
            //Console.WriteLine("2. Tính Chu vi, Diện tích hình vuông!");
            //Console.WriteLine("3. Tính Chu vi, Diện tích hình tròn!");
            //int n = Int32.Parse(Console.ReadLine());
            //if (n == 1)
            //{
            //    Console.Write("Nhập chiều dài HCN: ");
            //    chieuDai = Double.Parse(Console.ReadLine());
            //    Console.Write("Nhập chiều rộng HCN: ");
            //    chieuRong = Double.Parse(Console.ReadLine());
            //    chuViHCN = (chieuDai + chieuRong) * 2;
            //    dienTichHCN = chieuDai * chieuRong;
            //    Console.WriteLine("Chu vi Hình chữ nhật là: {0}",chuViHCN);
            //    Console.WriteLine("Diện tích Hình chữ nhật là: {0}", dienTichHCN);
            //}
            //else if (n == 2)
            //{
            //    Console.Write("Nhập chiều dài cạnh Hình vuông: ");
            //    chieuDai = Double.Parse(Console.ReadLine());
            //    chuViHV = chieuDai*4;
            //    dienTichHV = chieuDai * chieuDai;
            //    Console.WriteLine("Chu vi Hình vuông là: {0}", chuViHV);
            //    Console.WriteLine("Diện tích Hình vuông là: {0}", dienTichHV);
            //}
            //else if (n == 3)
            //{
            //    Console.Write("Nhập bán kính Hình tròn: ");
            //    banKinh = Double.Parse(Console.ReadLine());
            //    chuViHT = 2*pi*banKinh;
            //    dienTichHT = banKinh*banKinh*pi;
            //    Console.WriteLine("Chu vi Hình tròn là: {0}", chuViHT);
            //    Console.WriteLine("Diện tích Hình tròn là: {0}", dienTichHT);
            //}
            //else
            //{
            //    Console.WriteLine("xin mời chọn lại");
            //}
            //Console.ReadKey();

            //------------------------------------//
            //Bài tập 11: Nhập a, b, c là độ dài 3 cạnh của tam giác
            //(chú ý đảm bảo tổng 2 cạnh phải lớn hơn cạnh còn lại). 
            //Tính chu vi, diện tích, độ dài 3 đường cao, 3 đường trung tuyến, 
            //3 đường phân giác, bán kính đường tròn nội tiếp, 
            //    ngoại tiếp lần lượt theo các công thức sau: 
        }
    }
}
