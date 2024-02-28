using Encapsulation_Polymorphism_Abstraction_Homework.Models;

User user = new("Kamran", "Muradov", 24);

user.SetPassword("kamran1234");

Console.WriteLine(user.GetPassword());
