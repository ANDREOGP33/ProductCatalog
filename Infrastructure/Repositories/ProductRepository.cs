using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

public class ProductRepository : IProductRepository {
    private readonly List<Product> _products = new();

    public void Add(Product product) => _products.Add(product);

    public Product GetById(Guid id) => _products.FirstOrDefault(p => p.Id == id);

    public IEnumerable<Product> GetAll() => _products;

    public void Update(Product product) {
        var existingProduct = GetById(product.Id);
        if (existingProduct != null) {
            _products.Remove(existingProduct);
            _products.Add(product);
        }
    }

    public void Remove(Guid id) => _products.RemoveAll(p => p.Id == id);
}
