using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    //2.为 Employee 类添加两个做自我介绍的 SayHi 方法，每个方法可以做不同的自我介绍。
    class Employee
    {
        public string EmpId;
        public string Name;
        public string PassWord;
        public string Department;
        public DateTime Birthday;

        public void SayHi()
        {
            Console.WriteLine("大家好,我是:{0}", this.Name);
        }

        public void SayHi(string kcb)
        {
            Console.WriteLine("{0},我是:{1},即将加入{2}部门", kcb, this.Name, this.Department);
        }

    }
}
