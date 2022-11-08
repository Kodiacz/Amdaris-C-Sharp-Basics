using Data;

Product pedigree = new Product("Pedigree", 2);
Product whiskas = new Product("Whiskas", 5);
Product amiti = new Product("Amity", 4);
Product spectrum = new Product("Spectrum", 4);
Product everland = new Product("Everland", 4);

StoreStorage storeStorage = new StoreStorage();

storeStorage.AddProduct(pedigree);
storeStorage.AddProduct(whiskas);
storeStorage.AddProduct(amiti);
storeStorage.AddProduct(spectrum);
storeStorage.AddProduct(everland);

foreach (var product in storeStorage)
{
    Console.WriteLine($"We have {product.Quantity} {product.Name}");
}