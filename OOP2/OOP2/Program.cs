using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class içinde tanımlanmış class sınıf elemanı mıdır ?
            Myclass m1 = new Myclass();
            Myclass.Myclass2 m2 = new Myclass.Myclass2();

            #endregion
            #region Class elemanlarına açıklama satırı ekleme
            // orneğin random sınıfı deikten sonra Randomun ustune mouse ile gidince açıklama gözükür bunu yapmak için


            #endregion

            #region This Keywordu 

            #region Sınıfın nensnesini temsil eder
            
            // this ile tüm membelara erişebilir

            Ornek ornek = new Ornek();

            ornek.X(5); // ornek nesnesini temsil eder

            #endregion
            #region Aynı isim de field ile metot parametrelerini ayırmak için kullanılır
            // this keywordu ilgili class yapılanmasını o anki nesnesine karşılık verir .


            #endregion

            #endregion
            ornek.X();
            Console.WriteLine(ornek.X(25));
        }

        
    }
     
    class Ornek
    {
        int a;
        public int X(int a)
        {
            //this.a;    this ile X içinde ki parametreye değil fieldaki değere erişiriz.
            //eğer ki  sadece a yazarsak parametreye erişirz 
            a = this.a;
            return a;
        }
     public void X()
        {
            a = 5;
            Console.WriteLine(a);
        }
    }

    public class Myclass
    {

        int a;
        /// <summary>
        /// Bu bir propertydir
        /// </summary>
        public int MyProperty { get; set; }
        
        /// <summary>
        /// Bu bir örnek metot overloadıdır. 
        /// </summary>
        /// <param name="a"> a parametresi eklenmesi gerekir</param>
        public void X(int a ) { }
        
        public class Myclass2
        {

        }
    }
}
