using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogicLayer;
using DataAccessLayer;

namespace Conapp01
{
    class Program75
    {
        static void Main(string[] args)
        {
            PersonBO context = new PersonBO();
            List<PersonModel> people = context.GetAllPeople();
            foreach (var p in people)
                Console.WriteLine($"{p.Id} {p.PName} {p.Gender} {p.Age}");
        }
    }

}
