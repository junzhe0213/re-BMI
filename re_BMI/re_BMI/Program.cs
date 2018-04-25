using System;

namespace re_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //顯示標題
            Console.WriteLine("決勝時刻:BMI");
            //設bang數
            double m;
            double kg;
            double bmi;
           
            //使整個計算可以一直重複使用
            while(true)
            {
                //輸入數值
                Console.WriteLine("請輸入身高(m):");
                m = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入體重(kg):");
                kg = Convert.ToDouble(Console.ReadLine());
                //計算並顯示結果
                bmi = kg / (m * m);
                Console.WriteLine("你的BMI是:" + bmi);
                //數值輸入後顯示
                if (m == 0 | kg == 0)
                {
                    Console.WriteLine("不填數字是要怎麼決戰啦!");
                }
                if (bmi < 16.5)
                {
                    Console.WriteLine("兄弟免疫囉");
                }
                if (bmi < 18.5)
                {
                    Console.WriteLine("你個竹竿");
                }
                if (bmi >= 18.5 && bmi < 24)
                {
                    Console.WriteLine("你只是個凡人");
                }
                if (bmi >= 24 && bmi < 27)
                {
                    Console.WriteLine("資質過人喔");
                }
                if (bmi >= 27 && bmi < 30)
                {
                    Console.WriteLine("挖 高手");
                }
                if (bmi >= 30 && bmi < 35)
                {
                    Console.WriteLine("牛B 牛B");
                }
                if (bmi > 31.5)
                {
                    Console.WriteLine("兄弟免疫囉");
                }
                if (bmi >= 35)
                {
                    Console.WriteLine("太神啦");
                }
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
