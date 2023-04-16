using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamesOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Person
        {
            public string FamilyName { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }

            //метод для формирования записи о человеке для передачи в листбокс
            public string GetFullName()
            {
                return $"Фамилия: {FamilyName} | Имя: {Name} | Отчество: {Patronymic?? "нет отчества"}";
            }
        }
        //method GetPersons() returns a List of Person objects
        private List<Person> GetPersons()
        {
            //The returned List is initialized with three Person objects:
            return new List<Person>()
            {
                new Person() { Name="Martin", FamilyName="Dugin", Patronymic="Igorevitch"},
                new Person() { Name="Kay", FamilyName="Altos"},
                new Person() { Name="Mag", FamilyName="Ranche"} 
            };
        }
                       
        
        private void runButton_Click(object sender, EventArgs e)
        {
            //очистка списка если там уже были какие-то записи
            listBox1.Items.Clear();

            //вызываем метод и передаем переменной список
            var persons = GetPersons();

            // в цикле каждый элемент добавляется в список и у него
            // вызывается метод класса Person (возвращает строку)
            foreach (var person in persons)
            {
                listBox1.Items.Add(person.GetFullName());
            }            
        }
    }
}
