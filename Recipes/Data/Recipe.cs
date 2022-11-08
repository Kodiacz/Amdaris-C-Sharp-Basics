namespace Data
{
    public class Recipe
    {
        private readonly List<Product> products;

        public Recipe(List<Product> products)
        {
            this.products = products;
        }

        public List<Product> Products 
        {
            get { return products; }
        }

    }
}