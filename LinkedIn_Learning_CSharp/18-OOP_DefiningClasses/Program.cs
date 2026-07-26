using System;

namespace Defining
{
    class Program
    {
        static void Main (string[] args)
        {
            //* Create new object instances using the "new" operator
            // Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            // Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);
            //* Call a method on the object
            // Console.WriteLine(b1.GetDescription());
            // Console.WriteLine(b2.GetDescription());

            //* Try to set one of the properties, this will result in an error
            // b1._name = "Aldous Huxley"; //* inaccessible variable


            //! Game Challenge

            // Player player = new Player("Darian",5,120,true);
            // Console.WriteLine(player.GetDescription());

            //! Business Challenge

            // Employee employee = new Employee("Ahmet","Finance",55000m,0);
            // Console.WriteLine(employee.GetDescription());

            //! Bonus Challenge
            
            // Character character = new Character("Darian", "Knight", 18, 140, 0);
            // Console.WriteLine(character.GetDescription());
        }
    }
}