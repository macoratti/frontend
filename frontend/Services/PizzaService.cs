using frontend.Models;

namespace frontend.Services;

public class PizzaService : IPizzaService
{
    public IEnumerable<PizzaInfo> GetPizzas()
    {
        var pizzas = new List<PizzaInfo>
        {
            new PizzaInfo { PizzaNome = "Almondegas recheadas", Ingredientes = "Almondegas,muzzarela e tomate", PizzaPreco = 45.90M, EmEstoque = "sim"},
            new PizzaInfo { PizzaNome = "Frutos do Mar", Ingredientes = "Frutos do mar com recheio e tomate", PizzaPreco = 75.50M, EmEstoque = "não"},
            new PizzaInfo { PizzaNome = "Cogumelos com rúcula ", Ingredientes = "Cogumelos, rúcula e tomate seco", PizzaPreco = 32.45M, EmEstoque = "sim"},
            new PizzaInfo { PizzaNome = "Serrana", Ingredientes = "Acabaxi, bacon, pimenta, mussarela", PizzaPreco = 45.50M, EmEstoque = "sim"},
            new PizzaInfo { PizzaNome = "Calabreza da Casa", Ingredientes = "Calabreza, mussarela, tomate", PizzaPreco = 35.99M, EmEstoque = "não"},
            new PizzaInfo { PizzaNome = "Muzzarela Especial", Ingredientes = "Mussarela, tomate, orégano, queijo", PizzaPreco = 40.75M, EmEstoque = "sim"},
            new PizzaInfo { PizzaNome = "Portuguesa Especial", Ingredientes = "Mussarela, Presunto, ovos, ervila e palmito", PizzaPreco = 51.50M, EmEstoque = "sim"}
        };
        return pizzas;
    }
}
