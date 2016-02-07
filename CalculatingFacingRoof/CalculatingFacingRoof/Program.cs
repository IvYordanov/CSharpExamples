using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingFacingRoof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          Изчисление на триъгална страна на покрив!\n\n");
            Console.Write("   Въведете ширината на покрива в метри: ");
            float w = float.Parse(Console.ReadLine());
            Console.Write("   Въведете височина на покрива в метри: ");
           float h = float.Parse(Console.ReadLine());
               float s =( w * h) / 2; //Лице на покрива
            Console.WriteLine("   Лицето на страната е {0} квадратни метра.\n ",s);
            Console.Write("   Въедете ширината на циглата в метри: ");
            float w1 = float.Parse(Console.ReadLine());
            Console.Write("   Въведете дължината на циглата в метри: ");
            float h1 = float.Parse(Console.ReadLine());

           float s1 = w1 * h1;//Лице на циглата
           Console.WriteLine("  \n Лицето на едната цигла е {0}\n",s1);
          float sm =1/s1 ;// Цигли на кв.м
            Console.WriteLine("  {0} Цигли влизат на квадратен метър.\n",sm);
        float sumC = s*sm;//Брой цигли на страната на покрива
            Console.WriteLine("  Общо цигли{0}:\n",sumC);





        }
    }
}
