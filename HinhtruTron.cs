using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HinhtruTron
    {
        static void Main(string[] args)
        {HinhTron hinhTron = new HinhTron(2.5,"blue");
            Console.WriteLine(hinhTron);
            Hinhtru hinhtru = new Hinhtru(2.5, 4.0, "red");
            Console.WriteLine(hinhtru);

           

        }
    }
    public class HinhTron
    {
        private double BanKinh;
        private string MauSac;
        
        public HinhTron(double BanKinh, string MauSac)
        {
            this.BanKinh = BanKinh;
            this.MauSac = MauSac;
        }

        public string GetMauSac() { return MauSac; }
        public void SetMauSac(string MauSac)
        {
            this.MauSac = MauSac;
        }
        public double GetBanKinh() {  return BanKinh; }
        public void SetBanKinh(double BanKinh)
        {
            this.BanKinh = BanKinh;
        }
        public double GetChuVi()
        {
            return 2 * BanKinh * Math.PI;
        }
        public double GetDienTich()
        {
            return BanKinh*BanKinh*Math.PI;
        }
        public override string ToString()
        {
            return "Hinh TRON co ban kinh: "+GetBanKinh()+" va mau: "+GetMauSac()
                +" co DIEN TICH la: "+GetDienTich()
                +" va CHU VI: "+GetChuVi();
        }
    }
    public class Hinhtru : HinhTron
    {
        private double ChieuCao;
        public Hinhtru(double ChieuCao, double BanKinh, string MauSac):base(BanKinh, MauSac) { this.ChieuCao = ChieuCao; }
        public double GetChieuCao() {  return ChieuCao; }
        public void SetChieuCao(double ChieuCao)
        {
            this.ChieuCao=ChieuCao;
        }
        public double GetDienTichToanPhan()
        {
            return GetDienTich()+ChieuCao*GetChuVi();
        }
        public double GetTheTich()
        {
            return ChieuCao*GetDienTich();
        }

        public override string ToString()
        {
            return  "Hinh TRU co ban kinh: " + GetBanKinh() +" Chieu Cao: "+GetChieuCao()+ " va mau: " + GetMauSac()
                + " co DIEN TICH la: " + GetDienTichToanPhan()
                + " va THE TICH: " + GetTheTich();
        }

    }
    
    
}
