using System.Collections;

namespace Data
{
    public class StoreStorage : IEnumerable<Product>
    {
        //Question: if this reference type what is the way of safely give access to this variable (List)
        private List<Product> products;

        public StoreStorage()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return new ProductEnumerator(this.products);
            //return products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Product this[int index] => this.products[index];
        public int ProductsCount => this.products.Count;
    }
}
