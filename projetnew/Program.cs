using System;
using System.Collections.Generic;
using System.Linq;

namespace projetnew
{
    class Program
    {
        static void Main(string[] args)
        {

            Book livre1 = new Book();

            livre1.Price = 1000;
            livre1.Name = "Aladin";
            livre1.Id = 1;

            Book livre2 = new Book();

            livre2.Price = 2000;
            livre2.Name = "NAN";
            livre2.Id = 2;


            Book livre3 = new Book();

            livre3.Price = 3000;
            livre3.Name = "Mathematique";
            livre3.Id = 2;

            Book livre4 = new Book();

            livre4.Price = 4000;
            livre4.Name = "Informatique";
            livre4.Id = 2;


            List<Book> mabiblotheque = new List<Book>() {livre1,livre2,livre3,livre4 };

            //Utilisatrion de LINQ pour faire des requete sur notre collection

            var ami = (from l in mabiblotheque
                       where l.Price == 1000 || l.Price == 2000 || l.Price == 3000 || l.Price == 4000 select l);
            foreach (var roman in ami)
            {
                Console.WriteLine(roman.Id +" " + roman.Price +" " + roman.Name);
                //Console.WriteLine(roman.Name);
              
            }


        }
    }
}
