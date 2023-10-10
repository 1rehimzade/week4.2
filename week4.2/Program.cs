
// TASK 1 HEM CLASSLA HEMDE RECORDLA YAZILMISI
//using System;

//public class Person
//{
//    public string Gender { get; }
//    public DateTime BirthDate { get; }

//    public Person(string gender)
//    {
//        Gender = gender;
//        BirthDate = DateTime.Now; 
//    }
//}

//public class Animal
//{
//    public string Name { get; }
//    public string Breed { get; }

//    public Animal(string name, string breed)
//    {
//        Name = name;
//        Breed = breed;
//    }
//}

//public class Dog : Animal
//{
//    public Dog(string name, string breed) : base(name, breed)
//    {
//    }
//}

//using System;

//public record Person(string Gender, DateTime BirthDate)
//{
//    public Person(string gender) : this(gender, DateTime.Now)
//    {
//    }
//}

//public record Animal(string Name, string Breed);

//public record Dog(string Name, string Breed) : Animal(Name, Breed);

// Task 2
////using System;
//using System.Collections.Generic;

//public class Person
//{
//    public string Name { get; }
//    public string Surname { get; }
//    public int Age { get; }

//    public Person(string name, string surname, int age)
//    {
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }
//}

//public class Student : Person
//{
//    public bool IsOnline { get; }

//    public Student(string name, string surname, int age, bool isOnline) : base(name, surname, age)
//    {
//        IsOnline = isOnline;
//    }
//}

//public class Group
//{
//    public string GroupName { get; }
//    private List<Student> Students { get; }

//    public Group(string groupName, List<Student> students)
//    {
//        GroupName = groupName;
//        Students = students;
//    }

//    public void GetAllStudents()
//    {
//        Console.WriteLine($"Students in {GroupName} group:");
//        foreach (Student student in Students)
//        {
//            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
//        }
//    }

//    public void GetOnlineStudents()
//    {
//        Console.WriteLine($"Online students in {GroupName} group:");
//        foreach (Student student in Students)
//        {
//            if (student.IsOnline)
//            {
//                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
//            }
//        }
//    }

//    public void GetOfflineStudents()
//    {
//        Console.WriteLine($"Offline students in {GroupName} group:");
//        foreach (Student student in Students)
//        {
//            if (!student.IsOnline)
//            {
//                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Tələbə obyektləri yaradırıq
//        Student student1 = new Student("Ilham", "Aliyev", 20, true);
//        Student student2 = new Student("Nihat", "Rehimzade", 22, false);
//        Student student3 = new Student("Sabir", "quliyev", 21, true);

//        // Tələbələri qrupa əlavə edirik
//        List<Student> studentsList = new List<Student> { student1, student2, student3 };
//        Group group = new Group("Group A", studentsList);

//        // Gələn metodlarla tələbələri çıxarırıq
//        group.GetAllStudents();
//        Console.WriteLine();
//        group.GetOnlineStudents();
//        Console.WriteLine();
//        group.GetOfflineStudents();
//    }
//}
