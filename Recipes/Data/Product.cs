namespace Data
{
    public class Product
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid Name");
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
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Quantity");
                }

                quantity = value;
            }
        }

    }
}
