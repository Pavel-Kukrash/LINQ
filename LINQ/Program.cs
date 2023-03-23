
using System;

string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

var selectedPeople = new List<string>();
foreach (string person in people)
{
    if (person.ToUpper().StartsWith("T"))
        selectedPeople.Add(person);
}

selectedPeople.Sort();
foreach (string person in selectedPeople)
    Console.WriteLine(person);

Console.WriteLine("_______________");


//var selectedPeopleLinq = from p in people
//                         where p.ToUpper().StartsWith("T")
//                         orderby p
//                         select p;

var selectedPeopleLinq = people.Where(p => p.ToUpper().StartsWith("T")).
                                OrderBy(p => p);

foreach (string person in selectedPeopleLinq)
    Console.WriteLine(person);

Console.WriteLine("_______________");

var people1 = new List<Person>
    {
    new Person ("Tom", 23),
    new Person ("Bob", 27),
    new Person ("Sam", 29),
    new Person ("Alice", 24)
};

var names = people1.Select(p => p.Name);
foreach (string n in names)
    Console.WriteLine(n);

Console.WriteLine("_______________");

var personel = people1.Select(p => new
{
    FirstName = p.Name,
    Year = DateTime.Now.Year - p.Age
});

foreach (var p in personel)
{
    Console.WriteLine($"{p.FirstName} - {p.Year}");
}

Console.WriteLine("_______________");

//var hobby = new List<Hobby> { new Hobby("Racing"), new Hobby("Hiking"),
//                              new Hobby("Reading"), new Hobby("Climbing")};



//var personel1 =
//           from h in hobby
//           from p in people1
//           let name = $"mr. {p.Name}"
//           let year = DateTime.Now.Year - p.Age
//           select new
//           {
//               Name = name,
//               Year = year,
//               Hobby = h.HobbyName
//           };
//foreach (var p in personel1)
//{
//    Console.WriteLine($"{p.Name} - {p.Year} - {p.Hobby}");
//}


//Console.WriteLine("_______________");

var selectedPeople1 = people.Where(p => p.Length == 3);
foreach (string person in selectedPeople1)
    Console.WriteLine(person);

Console.WriteLine("_______________");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
IEnumerable<int> evens = numbers.Where(n => n%2 == 0 && n > 5);

foreach (int e in evens)
    Console.WriteLine(e);

Console.WriteLine("_______________");

var people3 = new List<Person1>
{
    new Person1 ("Tom", 23, "german"),
    new Person1 ("Bob", 27, "english"),
    new Person1 ("Anna", 29, "english"),
    new Person1 ("Alice", 24, "spanish")
};

//var selectedPeople3 = from p in people3
//                      where p.Age1 > 25
//                      select p;

var selectedPeople3 = people3.Where(p => p.Age1 > 23).OrderBy(p => p.Name1);
                             


foreach (Person1 person in selectedPeople3)
    Console.WriteLine($"{person.Name1} - {person.Age1}");

Console.WriteLine("_______________");

//var selectedPeople4 = from p in people3
//                      from lang in p.Languages
//                      where p.Age1 <28
//                      where lang == "english"
//                      select p;

//var selectedPeople4 = people3.SelectMany(p => p.Languages,
//                                         (p, l) => new { Person1 = p, Lang = l })
//                                         .Where(p => p.Lang == "english" && p.Person1.Age1 <28)
//                                         .Select(p => p.Person1);

var selectedPeople4 = people3.Where(p => p.Age1 > 25 && p.Languages
                                                     .Contains("english"))
                                                     .OrderBy(p => p.Name1);

foreach (Person1 p in selectedPeople4)
    Console.WriteLine($"{p.Name1} - {p.Languages}");

Console.WriteLine("_______________");

int[] numbersArr = { 1, 12, 3, 44, 5 };
var orderedNumbersArr = numbersArr.OrderByDescending(o => o);

foreach (int i in orderedNumbersArr)
{
    Console.WriteLine(i);
}




Console.ReadKey();



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name=name;
        Age=age;
    }
}

public class Hobby
{
    public string HobbyName { get; set; }
    public Hobby(string hobbyName)
    {
        HobbyName =hobbyName;
    }
}

public class Person1
{
    public string Name1 { get; set; }
    public int Age1 { get; set; }
    public string Languages { get; set; }

    public Person1(string name1, int age1, string languages)
    {
        Name1=name1;
        Age1=age1;
        Languages=languages;
    }



}