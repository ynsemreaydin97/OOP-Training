namespace Interfaces
{
    internal class Program
    {
        //interfaces new lenemez. (base classtan base clasa newleme yapılamaz alt classları new leyebiliriz.)
        static void Main(string[] args)
        {
            //classlarda erişilebilir üyeleri kullanırız içlerini doldurabiliriz lakin interfacelerde üyelerin içini boş bırakırız dolduramayız.
            //IPersonManager customerManager = new CustomerManager();
            
            //IPersonManager employeeManager = new EmployeeManager();
           
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());

        }
    }

    interface IPersonManager
    {

        void Add();         //<<<<<<<<<<unIMPLEMENTED OPERATİON        <<<<*İMZA(void ADD();)
        void Update();

    }
    //inheritence --> class ---- implement ---> interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)               //interface parametre <<<<<<<<<<
        {
            
            personManager.Add();
            
        }
        public void Update(IPersonManager personManager) 
        {
            personManager.Update();
        
        }
        

    }

}