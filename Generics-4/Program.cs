namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();                              //buradaki turkuaz renkli Listler aslında birer classtır.
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);                                       //count bir property ve sadece get; (read only)
                                                    
                                                                                     //List<> tanımlamasında içeriye ne yazarsam add lediğim kısmın yapısı o oluyor.

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
                                                                                     //aşağıda kendi classımı oluşturup yazdığımda böyle yazabilirim.
            
                                                                                     //Generic class yaptığımızda <> içerisini doldurmamız gerekiyor. (string vb.)
        }
    }
    class MyList<T>                                                                  //class ismi yanına <T> yazdığımızda artık Generic Class olmuş oluyor.
    {
        T[] _array; 
        T[] _tempArray;                                                              //referansları tutması için geçici array oluşturduk.
        public MyList()                                                              //My listi yukarıda ki gibi new lediğimiz an bu satır çalışıyor.
        {
            _array = new T[0];
        }
        public void Add(T item)                                                      //yukarıdaki kullanımda hangi türü belirlersek <T> o görevi görür.
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)                              // tutulan temp değerlerini yeni heap e taşımak için for döngüsü kullanıyoruz.
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;                                       
        }
        private int _count;                                                         //MyList in countunu çağırırsak aslında array.lengthi verir (eleman sayısını)

        public int Count
        {
            get { return _array.Length; }                                           //count bir property ve sadece get; (read only)

        }

    }

}