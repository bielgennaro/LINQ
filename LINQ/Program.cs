namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        var listaProdutos = new List<Produtos>()
        {
            new Produtos(1, "Mouse", 10.00m, 1, false),
            new Produtos(2, "Teclado", 20.00m, 1, true),
            new Produtos(3, "Monitor", 30.00m, 1, true),
            new Produtos(4, "Impressora", 40.00m, 1, true),
            new Produtos(5, "Jordan 4", 50.00m, 6, true),
            new Produtos(6, "SSD", 60.00m, 1, true),
            new Produtos(7, "Tênis", 70.00m, 9, true),
            new Produtos(8, "Placa de Vídeo", 80.00m, 1, true),
            new Produtos(9, "Processador", 90.00m, 1, true),
            new Produtos(10, "Boneco", 100.00m, 10, true),
            new Produtos(11, "Microondas", 40.00m, 3, false),
            new Produtos(12, "Geladeira", 50.00m, 3, false),
            new Produtos(13, "Fogão", 60.00m, 3, true),
            new Produtos(14, "Casaco", 60.00m, 9, true ),
            new Produtos(15, "Pato de borracha", 10.00m, 10, true )
            
        };
        
        var listaCategoria = new List<Categoria>()
        {
            new Categoria(1, "Informática", true),
            new Categoria(2, "Eletrônicos", true),
            new Categoria(3, "Eletrodomésticos", true),
            new Categoria(4, "Móveis", true),
            new Categoria(5, "Roupas", true),
            new Categoria(6, "Calçados", true),
            new Categoria(7, "Perfumes", true),
            new Categoria(8, "Automotivo", true),
            new Categoria(9, "Esportes", true),
            new Categoria(10, "Brinquedos", true),
        };
        
        
        //Lista produtos com o Id de categoria 3
        var produtosCategoria3 = listaProdutos.Where(x => x.CategoriaId == 3).ToList();

        Console.WriteLine("Produtos com ID de Categoria 3:");

        foreach (var produto in produtosCategoria3)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, CategoriaID: {produto.CategoriaId}");
        }
        
        //Lista produtos com o preço maior que 50
        var produtosCategoria3PrecoMaior50 = listaProdutos.Where(x => x.Preco > 50).ToList();
        
        Console.WriteLine("\nProdutos com ID de Categoria 3 e preço maior que 50:");
        
        foreach (var produto in produtosCategoria3PrecoMaior50)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, CategoriaID: {produto.CategoriaId}, Preço: {produto.Preco}");
        }
        
        //Lista produtos com o Id de categoria 3 e preço maior que 50 e nome que começa com a letra M
        var produtosCategoria3PrecoMaior50NomeComecaM = listaProdutos.Where(x => x.Preco > 50 && x.Nome.StartsWith("M")).ToList();
        
        Console.WriteLine("\nProdutos com ID de Categoria 3 e preço maior que 50 e nome que começa com a letra M:");
        
        foreach (var produto in produtosCategoria3PrecoMaior50NomeComecaM)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, CategoriaID: {produto.CategoriaId}, Preço: {produto.Preco}");
        }
        
        //Agrupando produtos com a inicial P
        var produtosIniciandoComP = listaProdutos.Where(x => x.Nome.StartsWith("P")).ToList();

        Console.WriteLine("\nProdutos que iniciam com a Letra P:");

        foreach (var produto in produtosIniciandoComP)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, CategoriaID: {produto.CategoriaId}, Preço: {produto.Preco}");
        }
        
        //Agrupando produtos com a letra P e preço maior que 10
        var produtosIniciandoComPMaisCarosQue10 = listaProdutos.Where(x => x.Nome.StartsWith("P") && x.Preco > 10);
        
        //Agrupando produtos com Id par e status false 
        var produtosComIdParComStatusFalse = listaProdutos
            .Where(x => x.Id % 2 == 0 && x.Status == false)
            .OrderBy(x => x.Id)
            .ToList();

        Console.WriteLine("\nProdutos com Id par e Status false: ");

        foreach (var produto in produtosComIdParComStatusFalse)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, CategoriaID: {produto.CategoriaId}, Preço: {produto.Preco}, Status: {produto.Status}");
        }
    }
}