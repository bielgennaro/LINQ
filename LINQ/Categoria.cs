namespace LINQ;

public class Categoria
{
    public Categoria(int id, string nome, bool status)
    {
        Id = id;
        Nome = nome;
        Status = status;
    }
    
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }
}