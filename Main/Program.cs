using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcreteCreator;
using Creator;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreator squareCreator = new SquareCreator();
            ICreator parallelogramCreator = new ParallelogramCreator();
            ICreator diamondCreator = new DiamondCreator();
            ICreator quadrangleCreator = new QuadrangleCreator();


            IFigure quadrangle = quadrangleCreator.FactoryMethod();
            IFigure parallelogram = parallelogramCreator.FactoryMethod();
            IFigure diamond = diamondCreator.FactoryMethod();
            IFigure square = squareCreator.FactoryMethod();
        }

    }
}
