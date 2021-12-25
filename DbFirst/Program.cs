using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities context = new NorthwindEntities())
            {
                var name = context.Categories.Find(9);
                context.Categories.RemoveRange(name);
                context.SaveChanges();
                Console.WriteLine("change were sucessfully made");
            }
        }
    }
}