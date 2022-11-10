using System.Collections;

namespace Data
{
    public class ProductEnumerator : IEnumerator<Product>
    {
        private readonly List<Product> products;
        private int index;

        public ProductEnumerator(List<Product> products)
        {
            this.products = products;

            // its -1 because the logic starts with MoveNext()
            this.index = 0;
        }

        public Product Current => this.products[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return ++index < products.Count;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
