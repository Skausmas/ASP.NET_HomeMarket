namespace MainHomeApplication
{
    public interface IGetHomeIndex
    {
        public int Index();
       
    }
    class HomeIndexGenerator : IGetHomeIndex
    {
        private static int _index = 0;
        private int index;
        public HomeIndexGenerator()
        {
            this.index = _index;
            _index++;
        }
        public int Index()
        {
            return this.index;
        }
    }


}
