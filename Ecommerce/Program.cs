using Ecommerce;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//Funcionalidade - Requisições


// Métodos HTTP:
// GET      - Recupera dados do servidor
// POST     - Envia dados para criar um recurso
// PUT      - Atualiza um recurso existente
// DELETE   - Remove um recurso    
// PATCH    - Atualiza parcialmente um recurso

List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Camiseta Básica", Quantidade = 100, Preco = 29.90 },
            new Produto { Nome = "Calça Jeans", Quantidade = 50, Preco = 99.90 },
            new Produto { Nome = "Tênis Esportivo", Quantidade = 30, Preco = 199.90 },
            new Produto { Nome = "Jaqueta de Couro", Quantidade = 20, Preco = 249.90 },
            new Produto { Nome = "Boné Estilizado", Quantidade = 75, Preco = 39.90 },
            new Produto { Nome = "Relógio Digital", Quantidade = 40, Preco = 149.90},
            new Produto { Nome = "Mochila Escolar", Quantidade = 60, Preco = 89.90 },
            new Produto { Nome = "Óculos de Sol", Quantidade = 35, Preco = 59.90 },
            new Produto { Nome = "Pulseira Fitness", Quantidade = 45, Preco = 79.90 },
            new Produto { Nome = "Fone de Ouvido Bluetooth", Quantidade = 25, Preco = 129.90 }
        };

app.MapGet("/", () => "API de produtos");

if (produtos.Any())
{
    return Results.OK("Deu certo!!!");
}
return false;

//GET: /api/produto/buscar/nome_do_produto

app.MapGet("/api/produto/buscar/{nome}", (String nome) =>
{
    foreach (Produto produtoCadastrado in produtos)
{
    if (produtoCadastrado.Nome == Nome)
    {
        return Results.OK(produtoCadastrado);   
    }
    }
return Results.Notfound("", produto);
});

//POST:

app.MapPost("/api/produto/cadastrar",

     (Produto produto) =>

    {
        return produtos;
    });


foreach (Produto produtoCadastrado in produtos)
{
    if (produtoCadastrado.Nome == produtoCadastrado.Nome)
    {
        return Results.Conflict("Produto já cadastrado");   
    }
    }
    
return Results.Created("", produto);

app.Run();