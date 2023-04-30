using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    internal class Program
    {
        class Person
        {
            public string FamilyName { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }

            public Contacts Contacts { get; set; }

            //метод для формирования записи о человеке для передачи в листбокс
            public string GetFullName()
            {
                return $"Фамилия: {FamilyName} | Имя: {Name} | Отчество: {Patronymic ?? "нет отчества"}";
            }
            
        }//end of class Person

        public class Contacts
        {
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

        }      

        static Person GetPerson()
        {
            //Person person = new Person() { Contacts = new Contacts() { PhoneNumber = null} }; 
            Person person = null;
            return person;
        }

        static void Main(string[] args)
        {
            Person person = GetPerson();
            string phoneNumber = person?.Contacts?.PhoneNumber ?? "Нет данных";
            Console.WriteLine(phoneNumber);
        }
    }  
}
