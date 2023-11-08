namespace comp
{
    public class SingelComputer : IComp
    {
        public static SingelComputer comp { get; set; } = null;
        protected SingelComputer()
        {
        }
        public static SingelComputer Initialize()
        {
            if (comp == null)
            {
                comp = new SingelComputer();
            }
            return comp;
        }
        public virtual string ComputerName()
        {
            return "Невiдомий комп'ютер";
        }
    }
}
