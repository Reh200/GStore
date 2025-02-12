namespace GStore.Models;


public class Produto
{
    public int Id { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

}