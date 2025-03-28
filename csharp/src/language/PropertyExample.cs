namespace Language.Properties
{
    class PropertyExample
    {
        // Private backing data/field
        private static int _num;
        // Property
        public int num {
            get => _num;
            set => _num = value;
        }
        public String msg;
    }
}