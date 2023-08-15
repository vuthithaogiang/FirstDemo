using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.demo1
{
    public class CodeTeacher : Teacher, ITeacher
    {
        private int age;

        public CodeTeacher()
        {

        }

        public CodeTeacher(string name, int age) : base(name)
        {
            this.age = age;
        }

        public override void Teach()
        {
            
            Console.WriteLine("Teach code");
        }

        public new void Lunch()
        {
            base.Lunch();
        }

        public void Eat()
        {

        }
    }
}
