namespace Data
{
    using Data.Intervaces;

    public class Product : IProduct
    {
        private string name;
        private int quantity;

        public Product(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidDataException("Invalid name");
                }

                name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new InvalidDataException("Invalid quantity");
                }

                quantity = value;
            }
        }
    }
}