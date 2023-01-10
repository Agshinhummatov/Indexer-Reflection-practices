using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_practices.Models
{
    public class Librarey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private Book[] _books;
        public Librarey(int size = 100)
        {

            _books = new Book[100];
        }   

        public Book this[int index]
        {

            get { 
                return _books[index];
            }
            set {

                _books[index] = value;

            }

        }
    }
}
