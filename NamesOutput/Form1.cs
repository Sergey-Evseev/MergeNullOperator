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
                return $"Фамилия: {FamilyName} | Имя: {Name} | Отчество: {Patronymic}";
            }
        }

        private List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person() { Name="Martin", FamilyName="Dugin", Patronymic="Igorevitch"},
                new Person() { Name="Kay", FamilyName="Altos"}
            };
        }
                       
        
        private void runButton_Click(object sender, EventArgs e)
        {
            // Create a new List<string> object and add the names
            List<string> names = new List<string>();
            names.Add("Family Name: Дугин | Name: Martin | Отчество: Игоревич");
            names.Add("Family Name: Altos | Name: Kay | Отчество:");
            names.Add("Family Name: Ranche | Name: Mag | Отчество:");

            // Loop through the names and add each one to the listBox1 control
            foreach (string name in names)
            {
                listBox1.Items.Add(name);
            }

            // Set the DisplayMember property of the listBox1 control
            //determines which property or method of the objects in the Items
            //collection of the ListBox control is used to display the items in the control
            //здесь не обязательно, только если с листе были бы объекты класса
            listBox1.DisplayMember = "ToString";
        }
    }
}
