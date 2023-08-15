using System;

namespace FirstDemo.demo1
{
    public class Teacher : AbstractClass
    {

        private List<string> tels;
        private string name;

       

        public Teacher()
        {
            tels = new List<string>();
        }


        public Teacher(string name)
        {
            this.name = name;
        }

        public List<string> Tels
        {
            get => tels;
            set => tels = value;
        }

        //indexer
        public string this[int index]
        {
            get => tels[index];
            set => tels[index] = value;
        }

        public virtual void Teach()
        {
            Console.WriteLine("Teach.");
        }

        public void Lunch()
        {

        }

        
        public override void Run()
        {
            
        }
    }
}
