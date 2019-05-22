namespace LittleChefs
{
    public static class Resources
    {
        public static LC littleChefs = new LC();
        public static int refrenceNumber = 2;
        public static long idStarter = 10001;
        public static decimal TAX = .0675m;

        public static long getNextIdValue()
        {
            return ++idStarter;
        }
    }
}
