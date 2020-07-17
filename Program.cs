using System;

namespace _24_ObjetosArgumento
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            Carrinho c = new Carrinho();

            Produto p1 = new Produto(1, "1984", 40.0f);
            Produto p2 = new Produto(2, "A revolução dos bichos", 55.0f);
            Produto p3 = new Produto(3, "Admirável Mundo Novo", 20.0f);
            Produto p4 = new Produto(4, "O Conto da Aia", 30.0f);

            c.Adicionar(p1);
            c.Adicionar(p2);
            c.Adicionar(p3);
            c.Adicionar(p4);

            c.Deletar(p2);

            Produto prodAlterado = new Produto(1, "A menina que roubava livros", 25.0f);
            

            c.Ler();
            c.MostrarTotal();           

        }
    }
}