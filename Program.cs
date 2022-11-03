using System;
using static System.Console;

namespace DatabaseFirstVendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBaseFirstVendaEntities2();

            var clienteAdd = new Cliente()
            {
                Nome = "Raul Dibai"
            };
            db.Cliente.Add(clienteAdd);
            db.SaveChanges();

            var produtoAdd = new Produto()
            {
                Nome = "Chocolate",
                Valor = 6.00M,
                Estoque = 20
            };

            db.Produto.Add(produtoAdd);
            db.SaveChanges();

            var produto = db.Produto.Find(1);
            var cliente = db.Cliente.Find(1);

            var venda = new Venda()
            {
                ClienteId = 1,
                ProdutoId = 1,
                ValorTotal = Convert.ToDouble(produto.Valor),
                DataVenda = DateTime.Now         
            };

            db.Venda.Add(venda);
            db.SaveChanges();


            WriteLine($"Produto vendido: {produto.Nome}");
            WriteLine($"Cliente: {cliente.Nome}");
            WriteLine($"Data de venda: {venda.DataVenda}");
            WriteLine($"Valor toral da compra: {venda.ValorTotal}");




        }
    }
}
