namespace Machine
{
    internal class Products
    {
        
        private int _prise;
        private int _amount;

        public string Name { get; set; }

        public int Prise
        {
            get => _prise;
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("Цена не может быть отрицательной");

                _prise = value;
            }
        }

        public int Amount
        {
            get => _amount;
            set => _amount = value;
            
        }

        public Products( string name, int prise, int amount)
        {
            Name = name;
            Prise = prise;
            Amount = amount;
        }
    }
}
