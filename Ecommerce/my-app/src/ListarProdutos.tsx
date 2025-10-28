//Componente
//1 - O componente deve ser uma função
//2 - Deve retornar apenas um elemento pai HTML
//3 - Exportar o componente
//4 - O nome da função precisa estar em PascalCasing

import { useEffect } from "react";

function ListarProdutos(){
    //useEffect é o método que permite executar
    //algum código, no momento do carregamento
    // do Componente
    //pegar os dados que chegaram na requisição e mostrar no HTML
    //estado /variavel
    useEffect(() => {
        //Biblioteca AXIOS para requisições

        buscarProdutosAPI();

    }, []);

    async function buscarProdutosAPI(){
        try{
        const resposta = await fetch("http://localhost:5169/api/produto/listar")
        if(!resposta.ok){
            throw new 
            Error("Requisição com problema: " + resposta.statusText )
        }
        const dados = await resposta.json();

        console.table(dados);
    }
    catch(error){
        console.log("requisição com problema: " + error);
    }
    }
        return (
            <div id ="Listar_produtos">

            <h1>Listar Produtos</h1>
            <ul>

            <li></li>
            <li></li>

            </ul>
            </div>
        );
}
export default ListarProdutos;