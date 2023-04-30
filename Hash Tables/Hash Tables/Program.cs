using System;


namespace Hash_Tables
{
    public class Program
    {
        public static void Main()
        {
            ListClas lst = new ListClas();
            lst.Add("kamal", "bästa shuno");
            lst.Add("hani", "bästa grabben");
            lst.Add("h22", "bästa 5");
            lst.Add("h23", "bästa");
            Console.WriteLine(lst.Get("kamal"));
            lst.Remove("h22");
            Console.WriteLine(lst.view());

        }
    }
}