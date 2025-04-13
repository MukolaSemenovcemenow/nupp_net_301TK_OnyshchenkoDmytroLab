using Lab1_0110Dplus.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab1_0110Dplus.Services
{
    public class PersonService
    {
        private List<Person> people = new List<Person>();

  
        public void Add(Person person)
        {
            people.Add(person);
        }

   
        public List<Person> GetAll()
        {
            return people;
        }

        public Person GetById(int id)
        {
            return people.FirstOrDefault(p => p.Id == id);
        }


        public void Update(Person updatedPerson)
        {
            var existing = GetById(updatedPerson.Id);
            if (existing != null)
            {
                existing.Name = updatedPerson.Name;
                existing.Age = updatedPerson.Age;
            }
        }

  
        public void Delete(int id)
        {
            var person = GetById(id);
            if (person != null)
            {
                people.Remove(person);
            }
        }

 
        public void Save(string filePath)
        {
            try
            {
                var json = JsonConvert.SerializeObject(people, Formatting.Indented);
                File.WriteAllText(filePath, json);
                Console.WriteLine("Дані збережено.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка збереження: " + ex.Message);
            }
        }

 
        public void Load(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    people = JsonConvert.DeserializeObject<List<Person>>(json);
                    Console.WriteLine("Дані завантажено.");
                }
                else
                {
                    Console.WriteLine("Файл не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка завантаження: " + ex.Message);
            }
        }
    }
}
