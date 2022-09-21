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
    }
}