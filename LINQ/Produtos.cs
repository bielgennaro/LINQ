namespace LINQ;

public class Produtos
{
    public Produtos(int id, string nome, decimal preco, int categoriaId, bool status)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        CategoriaId = categoriaId;
        Status = status;
    }
    
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int CategoriaId { get; set; }
    public bool Status { get; set; }
}