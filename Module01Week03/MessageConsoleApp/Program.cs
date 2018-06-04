using MessageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageLibrary;
using static MessageLibrary.Person;

namespace MessageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User designer = new Person("Rares","Pop",new DateTime(1992,07,18));

            Author author = new Author(5, "Ana", "Rusu", new DateTime(1991,05,1));
        }
    }
}
