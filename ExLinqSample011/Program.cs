using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample011
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill" , Age = 47 },
                new MyData { Name = "John" , Age = 37 },
                new MyData { Name = "Tom" , Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill" , Age = 35 },
            };
        }

    }
}
