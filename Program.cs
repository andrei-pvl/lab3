using System;
using comp;

namespace lb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComp computer = SingelComputer.Initialize();
            Console.WriteLine(computer.ComputerName());
            Console.WriteLine();

            FacadeComp facadecomp = new FacadeComp();
            Console.WriteLine(facadecomp.ComputerName());
            facadecomp.TurnOn();
            facadecomp.ProgramWork();
            facadecomp.TurnOff();

            Console.ReadLine();
        }
    }
}
