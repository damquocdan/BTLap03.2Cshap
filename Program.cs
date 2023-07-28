using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLap03._2Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book b1= new Book();
            Book b2 = new Book("Đàm Quốc Dân",10,"VN","Đắc nhân Tâm","50");
            b1.Display();
            b2.Display();

            b1.flipPageForWard();   
            b1.flipPageBackward();
            Console.ReadKey();
        }
    }
}
