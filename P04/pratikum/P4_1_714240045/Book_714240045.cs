using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240045
{
    public class Book_714240045 : Product_714240045
    {
        protected string PageCount;

        public Book_714240045(string type, string title , string pageaccount) : base(type, title)
        {
            this.PageCount = pageaccount;
        }

        public string pagecount
        {
            get { return PageCount; }
            set { PageCount = value; }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount);
        }
    }
}
