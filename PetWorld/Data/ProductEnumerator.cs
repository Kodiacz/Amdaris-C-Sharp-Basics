using System.Collections;

namespace Data
{
    public class ProductEnumerator : IEnumerator<Product>
    {
        private StoreStorage storeStorage;
        private int index;

        public ProductEnumerator(StoreStorage storeStorage)
        {
            this.storeStorage = storeStorage;

            // its -1 because the logic starts with MoveNext()
            this.index = 0;
        }

        public Product Current => this.storeStorage[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return ++index > storeStorage.ProductsCount;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
