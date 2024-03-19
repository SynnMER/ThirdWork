using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creator;
namespace ConcreteCreator
{
    class Diamond : Parallelogram
    {
    }
    class Parallelogram : Quadrangle
    {
    }
    class Quadrangle : IFigure
    {
    }
    class Square : Diamond
    {
    }
    public class DiamondCreator : ICreator
    {
        public IFigure FactoryMethod()
        {
            return new Diamond();
        }
    }
    public class ParallelogramCreator : ICreator
    {
        public IFigure FactoryMethod()
        {
            return new Parallelogram();
        }
    }
    public class QuadrangleCreator : ICreator
    {
        public IFigure FactoryMethod()
        {
            return new Quadrangle();
        }
    }
    public class SquareCreator : ICreator
    {
        public IFigure FactoryMethod()
        {
            return new Square();
        }
    }
}
