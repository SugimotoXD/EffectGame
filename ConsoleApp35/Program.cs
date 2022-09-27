using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Effect effect1 = new MagicHeal();
            effect1 = new AutoSpell(effect1); //Автоматическое исцеление
            Console.WriteLine("Name: {0}", effect1.Name);
            Console.WriteLine("Effect: {0}", effect1.GetEffect());

            Effect effect2 = new MagicalBurning();
            effect2 = new AutoCast(effect2); //Автоматическое исцеление
            Console.WriteLine("Name: {0}", effect2.Name);
            Console.WriteLine("Effect: {0}", effect2.GetEffect());

          

            Console.ReadLine();
        }
    }
    
}

