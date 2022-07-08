using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CapasitacionSesionDos
{

    public class Program
    {
        static void Main(string[] args)
        {
            Action<string> title = TitleNew;
            Func<string, bool> word = WordNew;
            Func<IEnumerable<char>, string> q = Lyrics;
            Action<Func<IEnumerable<char>, string>> w = b;
            Action<string, int> something = (val1, val2) =>
            {

            };
            Func<string, bool> something4 = (string value) =>
            {
                return true;
            };
            Func<Func<string, bool>> someting5 = () =>
            {
                return something4;
            };


            title("Hola mundo");
            //something("Steven");
            //something2("Wendy");


            List<Person> people = new List<Person>()
            {
                new Person() { Name = "Juan", Age = 31 },
                new Person() { Name = "Jhonatan", Age = 26 },
                new Person() { Name = "Steven", Age = 23 },
                new Person() { Name = "Wendy", Age = 25 }
            };
           
            var consult3 = people
                .Where(person => person.Age > 23)
                .OrderByDescending(person => person.Age);

            foreach (var person in consult3)
            {
                Console.WriteLine(person);
            }

            #region
            //var consult = (from Person in people
            //               where Person.Age > 23
            //               orderby Person.Age descending
            //               select Person.Name).ToList();
            //var consult2 = people.Where(person =>
            //{
            //    return true;
            //});
            //Expresiones
            //Expression<Func<string>> something2 = () => string.Empty;
            //Expression<Func<Func<string, bool>>> something3 = () => something4;
            #endregion
        }



        private static void TitleNew(string menssage)
        {
            Console.WriteLine(menssage);
        }

        public static bool WordNew(string Name)
        {
            return true;
        }

        public static string Lyrics(IEnumerable<char> a)
        {
            return "a";
        }

        public static void b(Func<IEnumerable<char>, string> c)
        {

        }


    }
}
