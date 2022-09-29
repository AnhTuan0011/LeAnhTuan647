using System;
namespace LeAnhTuanBTH.Models.Process
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            string strResult = "";
            // viet code xu ly xoa cacs ky tu trang con thua
            //xoa o dau va cuoi
            strInput = strInput.Trim();
            //xoa  bo cac ky tu trang con thua o giua
            int index = strInput.IndexOf("  ");
            while(strInput.IndexOf("  ")>0)
            {
                strInput = strInput.Replace("  "," ");
            }
            strResult = strInput;
            return strResult;
        }
    }
    public class StringProcess1
    {
        public string LowerToUpper(string strInput )
        {
            string strResult = "";
            strInput = strInput.ToUpper();
            strResult = strInput;
            return strResult;
        }
    }
    public class StringProcess2
    {
        public string UpperToLower(string strInput )
        {
            string strResult = "";
            strInput = strInput.ToLower();
            strResult = strInput;
            return strResult;
        }
    }        

     public class StringProcess3
    {
        public string CapitalizeOneFirstCharacter(string strInput )
        {
            string strResult = "";
            strInput = strInput.ToUpper();
            strResult = strInput;
            return strResult;
        }
    }        
}