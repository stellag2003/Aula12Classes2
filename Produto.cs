using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes2
{
    
    internal class Produto
    {
        public string nome;
        public string descricao;
        public int preco;
        public int quantidade;
        public bool status = true;

        

        public void mostra()
        {
            Console.WriteLine($"O produto é {nome}, descrição: {descricao}, preço {preco}, no estoque tem  {quantidade}, o status é  {status}. ");
        }
        
        public void desativa()
        {
            Console.WriteLine($"Quantidade {quantidade = 0}, status {status = false} ");
        }
       









    }
}
