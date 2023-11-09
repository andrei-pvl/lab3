
namespace comp
{
    class Switcher
    {
        private bool isOn = false;
        public string On()
        {
            isOn = true;
            return "Комп'ютер ввiмкнуто";
        }
        public string Off()
        {
            isOn = false;
            return "Комп'ютер вимкнуто";
        }
    }
}
