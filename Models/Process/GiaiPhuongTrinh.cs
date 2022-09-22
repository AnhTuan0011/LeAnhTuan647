namespace LeAnhTuanBTH.Models.Process
{

    public class GiaiPhuongTrinh
    {
        //xay dựng các pthuc
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            //khai báo 1 biến đe chứa dữ liệu muốn trả về
            string thongBao = "";
            //khai báo 1 biến để chứa giá trị nghiệm của ptrinh
            double x;
            //giai ptrinh
             if(heSoA == 0){
                if(heSoB == 0){
                    thongBao = "Phương trình có vô số nghiệm.";
                }
                else{
                    thongBao = "Phương trình vô nghiệm";
                }
            } else{
                //tính nghiệm của phương tình bậc nhất
                x = -heSoB/heSoA;
                thongBao = "Phương trình có nghiệm X = " + x;
            }
           //trả về dữ liệu
           return thongBao;

        }
 public string GiaiPhuongTrinhBacHai(double heSoA, double heSoB,double heSoC)
    {
         //khai bao 1 bien  de chua du lieu
        string thongBao = "";
        //khai bao 1 bien so de chua gia tri
        double x;
        double x1;
        double x2;
        double delta;
        delta = heSoB * heSoB - 4 * heSoA * heSoC ;
        if(heSoA==0)
        {
            //Giai pt bac 1
            if(heSoB ==0)
            {
                //Neu b= 0 vaf c=0 thif phuowng trinh vo so nghiem
                if(heSoC==0)
            {
                thongBao ="Phuong trinh co vo so nghiem";
            }
            //neu b=0 va c!=0 thif vo nghiem
            else{
                thongBao = "phuong trinh vo nghiem";
            }
            }
            else 
            {
                x1=(double)-heSoC/heSoB;
                thongBao ="Phuong trinh co nghiem duy nhat: x={0}";
            }
            return thongBao;
         }
        //Neu a!=0 thif bat dau bac 2
        else
        {
            // tinh delta
               delta = Math.Pow(heSoB, 2) - 4 * heSoA * heSoC;
               //Kiem tra xem <0 thif pt vo nghiem
               if(delta < 0)
               {
                thongBao = "Phuong trinh vo nghiem.";
               }
               //neu delta = 0 thif cos nghiem kep
               else if(delta ==0)
               {
                x1=x2=-heSoB/(2*heSoA);
                thongBao = "Phuong trinh co nghiem kep x= ";
               }
               //neu >0 thif cos nghiem phan biet
               else{
                    x1 = (-heSoB + Math.Sqrt(delta)) / (2 * heSoA);
                    x2 = (-heSoB - Math.Sqrt(delta)) / (2 * heSoA);
                    thongBao = "Phuong trinh co 2 nghiem phan biet:";
                    thongBao = " Nghiem x1=" +x1;
                    thongBao = " Nghiem x2=" +x2;
               }
        }

        return thongBao;
    }
  }
}