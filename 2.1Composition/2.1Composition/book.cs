using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1Composition
{
    class book
    {
        private string Name;
        private Author[] Authors;
        private double Price;
        private int Qty = 1;

        public book(string name, Author[] authors, double price)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
        }

        public book(string name , Author[] authors , double price , int qty)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = qty;
        }
        public String getName()
        {
            return this.Name;
        }
        public Author[] getAuthor ()
        {
            return this.Authors;
        }
        public double getPrice()
        {
            return this.Price;
        }
        public int getQty ()
        {
            return this.Qty;
        }
        public void setPrice( double price)
        {
            this.Price = price;
        }
        public void setQty (int qty)
        {
            this.Qty = qty;
        }
       
        public override string ToString()
        {
            string[] strAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++ )
            {
                strAuthors[i] = this.Authors[i].ToString();
            }
                return string.Format("Book[name = {0} , authors = {{{1}}}, price = {2} , qty = {3}]"
                                      , this.Name, String.Join(",", strAuthors), this.Price, this.Qty);
        }
        public string getAuthorNames()
        {
            string[] strAuthorNames = new string[this.Authors.Length];
            for(int i=0; i<this.Authors.Length; i++)
            {
                strAuthorNames[i] = this.Authors[i].GetName();
            }
            return String.Join(",", strAuthorNames);

        }

       
    }
}
