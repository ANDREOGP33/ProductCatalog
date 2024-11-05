using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product {
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(Guid id, string name, decimal price) {
        Id = id;
        Name = name;
        Price = price;
    }

    public void Update(string name, decimal price) {
        Name = name;
        Price = price;
    }
}
