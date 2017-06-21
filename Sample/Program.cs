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
            string appid = "";
            string secretId = "";
            string secretKey = "";
            string userid = "";



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
            //path = System.IO.Directory.GetCurrentDirectory() + "\\icon_ocr_common01.png";
            //result = Youtu.generalocr(path);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //// 行驶证OCR
            //path = System.IO.Directory.GetCurrentDirectory() + "\\ocr_xsz_01.jpg";
            //result = Youtu.driverlicenseocr(path, 0);
            //Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}
