using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces {
    public interface IProductRepository {
        void Add(Product product);
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
        void Update(Product product);
        void Remove(Guid id);
    }
}
