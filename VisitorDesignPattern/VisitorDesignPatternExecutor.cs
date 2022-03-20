using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.ConcreteVisitable;
using VisitorDesignPattern.ConcreteVisitor;

namespace VisitorDesignPattern
{
    public class VisitorDesignPatternExecutor
    {
        static void Main(string[] args)
        {
            TaxVisitor taxCalc = new TaxVisitor();
            TaxHolidayVisitor taxHolidayCalc = new TaxHolidayVisitor();
            Necessity milk = new Necessity(3.47); 
            Liquor vodka = new Liquor(11.99);
            Tobacco cigars = new Tobacco(19.99);
            Console.WriteLine("Taxing all items on normal day");
            Console.WriteLine(milk.accept(taxCalc));
            Console.WriteLine(vodka.accept(taxCalc));
            Console.WriteLine(cigars.accept(taxCalc));
            Console.WriteLine("Taxing all items on tax holiday");
            Console.WriteLine(milk.accept(taxHolidayCalc));
            Console.WriteLine(vodka.accept(taxHolidayCalc));
            Console.WriteLine(cigars.accept(taxHolidayCalc));
            Console.ReadKey();


        }
    }
}
