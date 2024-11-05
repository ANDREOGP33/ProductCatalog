using System;
using System.Collections.Generic;
using Domain.Interfaces;

public class ProductService {
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository) {
        _productRepository = productRepository;
    }

    public void CreateProduct(string name, decimal price) {
        var product = new Product(Guid.NewGuid(), name, price);
        _productRepository.Add(product);
    }

    public Product GetProductById(Guid id) => _productRepository.GetById(id);

    public IEnumerable<Product> GetAllProducts() => _productRepository.GetAll();

    public void UpdateProduct(Guid id, string name, decimal price) {
        var product = _productRepository.GetById(id);
        product?.Update(name, price);
        _productRepository.Update(product);
    }

    public void DeleteProduct(Guid id) => _productRepository.Remove(id);
}
