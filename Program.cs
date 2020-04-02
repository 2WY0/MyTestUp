using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.编写一个能够读出指定字符串的 Speaker 类，并提供两个方法，可以以不同的方式来读出字符串内容。
            Speaker.Speak("间歇性踌躇满志 持续性混吃等死");
            Console.WriteLine("请输入要读的内容:");
            string sp = Console.ReadLine();
            Console.WriteLine("请输入朗读速度:");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入朗读音量:");
            int vol = int.Parse(Console.ReadLine());
            Speaker.Speak(sp, rate, vol);

            //2.为 Employee 类添加两个做自我介绍的 SayHi 方法，每个方法可以做不同的自我介绍。
            Employee emp = new Employee { Name = "程序员", Department = "快速秃头开发部" };
            emp.SayHi();
            emp.SayHi("各位秃头程序员们，大家好");

            //3.定义类的简化写法
            User u = new User();
            u.Id = 1;
            u.Name = "程序";
            u.Title = "程序开发";
        }
    }

    //3.定义类的简化写法
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
