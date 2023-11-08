using System;

namespace comp
{
    public class FacadeComp : SingelComputer
    {

        private Switcher switcher { get; set; }
        private Launcher launcher { get; set; }
        private FileWork filework { get; set; }
        
        
        public FacadeComp()
        {
            switcher = new Switcher();
            launcher = new Launcher();
            filework = new FileWork();
        }
        public override string ComputerName()
        {
            return "Iм'я комп'ютеру: Computer: Acer cc5532hk63";
        }
        public void TurnOn()
        {
            switcher.On();
            launcher.LaunchOS();
        }
        public void ProgramWork()
        {
            Console.WriteLine(launcher.LaunchProgram());
            
            Console.WriteLine("Введiть назву файлу/програми");
            filework.ScanFile();
            Console.WriteLine("Введений файл/програма з назвою:");
            Console.WriteLine(filework.PrintFile());
           
        }
        public void TurnOff()
        {
            Console.WriteLine(launcher.OffProgram());
            Console.WriteLine(launcher.OffOS());
            Console.WriteLine(switcher.Off());
        }

    }
}
