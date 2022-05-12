using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class PersonBO
    {
        public List<PersonModel> People { get; set; }
        public PersonBO() => People = new List<PersonModel> 
        {
            new PersonModel{Id=1001,PName="Kiran",Gender="Male",Age=35},
            new PersonModel{Id=1002,PName="Devi",Gender="Female",Age=6 }
        };
        public List<PersonModel> GetAllPeople() => People;
        public PersonModel GetPersonById(int id) => People.FirstOrDefault(x => x.Id == id);
        public void AddPerson(PersonModel p) => People.Add(p);
        public void EditPerson(int id, PersonModel p) => People[People.FindIndex(x => x.Id == id)] = p;
        public void DeletePerson(int id) => People.RemoveAt(People.FindIndex(x => x.Id == id));
    }
}