using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.slot5Asignment
{
    public class PhoneBook : Phone
    {
       

        private List<Tuple<string, string>> PhoneList = new List<Tuple<string, string>>();

        public PhoneBook()
        {

        }


        public override void InsertPhone(string name, string phone)
        {
            bool found = false;
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i].Item1 == name)
                {
                    found = true;
                    if (PhoneList[i].Item2 != phone)
                    {
                        PhoneList[i] = new Tuple<string, string>(name, phone);
                    }
                    break;
                }
            }
            if (!found)
            {
                PhoneList.Add(new Tuple<string, string>(name, phone));
            }
           
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(entry => entry.Item1 == name);
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i].Item1 == name)
                {
                    PhoneList[i] = new Tuple<string, string>(name, newPhone);
                    break;
                }
            }
        }

        public override void SearchPhone(string name)
        {
            foreach (var entry in PhoneList)
            {
                if (entry.Item1 == name)
                {
                    Console.WriteLine($"Name: {entry.Item1}, Phone: {entry.Item2}");
                }
            }
        }
        public override void Sort()
        {
            PhoneList.Sort((x, y) => x.Item1.CompareTo(y.Item1));
        }
    }
}
