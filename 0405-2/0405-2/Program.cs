using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405_2
{
    class Country
    {
        public string Address = "Korea, Republic of | ";
        public Country()
        {
            Console.WriteLine("Country 부모 클래스 생성");
        }
    }
    class City : Country
    {
        public City(String city)
        {
            this.Address += city;
            Console.WriteLine("City 자식 클래스 생성");
        }
        public void ShowAddress()
        {
            Console.WriteLine(Address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            City c = new City("Busan");
            c.ShowAddress();
        }
    }
}
