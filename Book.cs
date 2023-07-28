using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLap03._2Cshap
{
    internal class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        private int curentpage;

        public Book()
        {
            author = "";
            pages = 0;
            isbn = "";
            title = "";
            curentpage = 1;
        }
        public Book(string author,int page,string isbn,string title,string curentpage)
        {   
            this.author = author;
            this.pages = page;
            this.isbn = isbn;
            this.title = title;

        }
        public void Display()
        {
            Console.WriteLine("tác giả"+author);
            Console.WriteLine("trang:" +pages);
            Console.WriteLine("isbn:" + isbn);
            Console.WriteLine("Tiêu đề:" + title);
            Console.WriteLine("Trang hiện tại:" + curentpage);
        }
        public void flipPageForWard()
        {
            Console.WriteLine("Lật sang trang trước!");
        }
        public void flipPageBackward()
        {
            Console.WriteLine("Lật sang trang sau");
        }


    }
}
