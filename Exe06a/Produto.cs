
namespace Exe06a;

public class Produto
{
    //Construtor
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    //Atributos/ Propriedades / Caracteristicas
    //private string Nome;


    public String Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public double Preco { get; set; }
    
    public DateTime CriadoEm { get; set; }
}
