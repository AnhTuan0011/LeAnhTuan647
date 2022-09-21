using Microsoft.AspNetCore.Mvc;
using LeAnhTuanBTH.Models.Process;


namespace LeAnhTuanBTH.Controllers

{
    public class DemoController : Controller
    {
        //khai báo class theo tên của đối tựng
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        //tạo các action
        public IActionResult Index()
        {
            return View();
        }
        //action để nhận dữ liệu từ view gửi lên
        [HttpPost]
        public IActionResult Index(string heSoA, string heSoB)
        {
            //ép kiểu dữ liệu của tham số
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string mess = gpt.GiaiPhuongTrinhBacNhat(a, b);
            ViewBag.abc = mess;
            return View();
        }
    }
}