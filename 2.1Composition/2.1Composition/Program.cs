using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author anTeck = new Author("kiet" , "kietnguyen20101010@gmail.com" , 'm');
            //Console.WriteLine(anTeck);
            //anTeck.setEmail("kietdeptrai@gmail.com");
            //Console.WriteLine("name is : " + anTeck.GetName());
            //Console.WriteLine("email is :" + anTeck.GetEmail());
            //Console.WriteLine("Gender is : " + anTeck.GetGender());
            


                        // Declare and allocate an array of Authors
            Author[] authors = new Author[2];
            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            // Declare and allocate a Book instance

            book javaDummy = new book("Java for Dummy", authors, 19.99, 99);
            Console.WriteLine(javaDummy);  // toString()


        }
    }
}
