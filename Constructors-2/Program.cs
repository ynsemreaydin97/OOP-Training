namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Emre", LastName = "Aydin", City = "Bayburt" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mahmut";
            customer3.LastName = "Kelekci";                                                          //customer1 ve customer3 deki kullanımlar aynınıdır.
            customer3.City = "Nigde";


            Customer customer2 = new Customer (2, "Sero", "Sahin", "Tokat");
            Console.WriteLine(customer2.FirstName);                                                  //ctorda set ettiğimiz için yazdırabildik (32.satıra bak)
                                                                                                     //burada new Customer yazdığımda public Customer Constructor u çalışır.
                                                                                                     //default Constructor = parametresi olmayan ctor.
        }                  
    }
    class Customer
    {
        public Customer()                                                                            //customer1 ve 3 deki gibi kullanım için default ctor yeterli.                                                                      
        {

        }

        public Customer(int id,string firstName,string lastName,string city)                        //customer2 deki kullanım için   ctor da parantez içini tanımlamalısın.                                                                                  
        {
            Id = id;    
            FirstName = firstName;                                                                  //ctor da değerlerimizi set ederiz.(tanımlarız Id=id; gibi)
            LastName = lastName;
            City = city;                                                                            //Constructors <<<<<<<<<<< (bir metod gibi çalışır)
        } 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string City { get; set; }

    }
}