using Exe06a;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//app.MapGet("/", () => "Minha segunda API em C#");

//app.MapGet("/endereço", () => "Endereço");

//Produto produto = new Produto();
//produto.Nome = "Mouse";
//Console.WriteLine("Nome: " + produto.Nome + "Id:" + produto.Id + " Criado em:" + produto.CriadoEm);

//lista de produtos

//var produos = new List<Produto>
List<Produto> produtos = new List<Produto>

//Produto produto = new Produto();
//Produto.Nome = "Mouse";
//produtos.Add(produto);

{
        new Produto { Nome = "Mouse", Quantidade = 50, Preco = 49.99 },
        new Produto { Nome = "Teclado", Quantidade = 30, Preco = 120.00 },
        new Produto { Nome = "Monitor", Quantidade = 20, Preco = 799.99 },
        new Produto { Nome = "Headset", Quantidade = 15, Preco = 150.00 },
        new Produto { Nome = "Cabo HDMI", Quantidade = 100, Preco = 25.00 },
        new Produto { Nome = "Webcam", Quantidade = 10, Preco = 250.00 },
        new Produto { Nome = "Placa de Vídeo", Quantidade = 5, Preco = 1500.00 },
        new Produto { Nome = "Mochila para Notebook", Quantidade = 40, Preco = 89.99 },
        new Produto { Nome = "Microfone", Quantidade = 8, Preco = 180.00 },
        new Produto { Nome = "Notebook", Quantidade = 12, Preco = 3500.00 }

};



app.MapGet("/", () => "API de Produtos");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    return produtos;
});

//POST: /api/produto/cadastrar
app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    produtos.Add(produto);
});

app.Run();
