using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TencentYoutuYun.SDK.Csharp;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 设置为你自己的密钥对
            string appid = "10105350";
            string secretId = "AKIDdA0iGoRUjx0ru6R5rSH2c1KpNm0WuWyG";
            string secretKey = "FTWQONCtSWZXN2axAufGhx228JYfeS41";
            string userid = "993801914";



            Conf.Instance().setAppInfo(appid, secretId, secretKey, userid, Conf.Instance().YOUTU_END_POINT);

            string path = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string path2 = System.IO.Directory.GetCurrentDirectory() + "\\test.jpg";
            string result = string.Empty;

            //result = Youtu.facecompare(path,path2);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //// 人脸定位 调用demo
            //result = Youtu.faceshape(path);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //result = Youtu.getpersonids("group");
            //Console.WriteLine(result);
            //Console.ReadKey();

            //// 名片OCR
            //path = System.IO.Directory.GetCurrentDirectory() + "\\ocr_card_01.jpg";
            //result = Youtu.bcocr(path);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //// 通用OCR
            //result = Youtu.generalocrurl("http://open.youtu.qq.com/app/img/experience/char_general/ocr_common01.jpg");
            //Console.WriteLine(result);
            //Console.ReadKey();

            //// 行驶证OCR
            //path = System.IO.Directory.GetCurrentDirectory() + "\\ocr_xsz_01.jpg";
            //result = Youtu.driverlicenseocr(path, 0);
            //Console.WriteLine(result);
            //Console.ReadKey();

            List<String> group_ids = new List<string>();
            result = Youtu.multifaceidentifyurl("http://open.youtu.qq.com/app/img/experience/face_img/face_05.jpg?v=1.0", "test", group_ids, 5, 40);
            Console.WriteLine(result);
            //Console.ReadKey();

            result = Youtu.imageterrorismurl("http://open.youtu.qq.com/app/img/experience/terror/img_terror01.jpg");
            Console.WriteLine(result);

            result = Youtu.carcalssifyurl("http://open.youtu.qq.com/app/img/experience/car/car_01.jpg");
            Console.WriteLine(result);

            result = Youtu.creditcardocrurl("http://open.youtu.qq.com/app/img/experience/char_general/ocr_card_1.jpg");
            Console.WriteLine(result);

            result = Youtu.bizlicenseocrurl("http://open.youtu.qq.com/app/img/experience/char_general/ocr_yyzz_01.jpg");
            Console.WriteLine(result);

            result = Youtu.plateocrurl("http://open.youtu.qq.com/app/img/experience/char_general/ocr_license_1.jpg");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
