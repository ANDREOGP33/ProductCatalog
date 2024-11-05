using System;

class Program {
    static void Main(string[] args) {
        var productRepository = new ProductRepository();
        var productService = new ProductService(productRepository);

        while (true) {
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Atualizar Produto");
            Console.WriteLine("4 - Remover Produto");
            Console.WriteLine("5 - Sair");
            var choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    Console.Write("Nome do Produto: ");
                    var name = Console.ReadLine();
                    Console.Write("Preço: ");
                    var price = decimal.Parse(Console.ReadLine());
                    productService.CreateProduct(name, price);
                    break;

                case "2":
                    foreach (var product in productService.GetAllProducts()) {
                        Console.WriteLine($"ID: {product.Id}, Nome: {product.Name}, Preço: {product.Price}");
                    }
                    break;

                case "3":
                    Console.Write("ID do Produto: ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Novo Nome: ");
                    var newName = Console.ReadLine();
                    Console.Write("Novo Preço: ");
                    var newPrice = decimal.Parse(Console.ReadLine());
                    productService.UpdateProduct(id, newName, newPrice);
                    break;

                case "4":
                    Console.Write("ID do Produto: ");
                    id = Guid.Parse(Console.ReadLine());
                    productService.DeleteProduct(id);
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
