using System;
namespace Conapp01
{
    class Program61
    {
        static void Main(string[] args)
        {
            //Data source
            int[] items = new int[] { 10, 20, 30, 40, 50 };

            //Create linq query
            //var query = from item in items select item;
            //var query = from item in items orderby items select items;
            //var query = from item in items orderby item descending select item;
            var query = from item in items where item%2==0 select item;

            
            //fetch data via linq query
            foreach (var x in query)
                Console.WriteLine(x);
        }
    }
}
/*
Linq:  Language Integrated Query
This is a feature, which enable program to perform interaction on access any datasource with similar syntax
Linq to specially designed to querying data

Datasource: Refers to a place where data gets stored like array, collection, datatable, database, etc.,

Linq provides two way to access data
a) Sql like queries
        Looks like sql statements
    Syntax:
    var query = from item in items select item;
    var query = from fruit in fruits select fruit;
    var query = from student in students select student;
    var query = from e in employees select e;

b) Linq like queries
        Uses extension methods

 */