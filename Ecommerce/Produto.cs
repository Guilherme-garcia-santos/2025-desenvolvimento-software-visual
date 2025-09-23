using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ecommerce;

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


    public string Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Quantidade { get; set; }

    public double Preco { get; set; }
    
    public DateTime CriadoEm { get; set; }
}
