// See https://aka.ms/new-console-template for more information

// int decimal float enum booleanlar ---> value types.(değer tipler) //değer tipler stack kısımda çalışır.
//int sayi1 = 10;
//int sayi2 = 20;
//sayi1 = sayi2;

//sayi2 = 100;
//Console.WriteLine("Sayi 1:" + sayi1);


//// arrays,classes,interfaces ---> reference types (referans tipler) // referans tipler heap kısmında çalışır.

//int[] sayilar1 = new int[] { 1, 2, 3 };
//int[] sayilar2 = new int[] { 10, 20, 30 };

//sayilar1 = sayilar2;
//sayilar2[0] = 1000;
//Console.WriteLine("Sayilar1[0]= " + sayilar1[0]);





Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "yurda";
person2 = person1;
person1.FirstName = "rafet";
//Console.WriteLine(person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "YAZGI";
customer.CreditCardNumber = "114231";
Employee employee = new Employee();
employee.FirstName = "Veli";

Person person3 = customer;
person3.FirstName = "furkan";

//Console.WriteLine(((Customer)person3).CreditCardNumber);  //boxing uygulaması (Customer)person3) şeklinde yapılırsa person3.CreditCardNumber görünür olur.

PersonMenager personMenager = new PersonMenager();
personMenager.Add(customer);


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
//base class = Person
class Customer : Person         // inheritence kalıtım metodu.
{
    public string CreditCardNumber { get; set; }
}
class Employee : Person        // inheritence kalıtım metodu.
{
    public int EmployeeNumber { get; set; }
}

class PersonMenager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    
    }
}
