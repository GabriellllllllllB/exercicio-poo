    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        class Produto
        {
            public string nome;
            public double preço;
            public int quantidade;

            public void adicionarestoque(int adicionarquantidade)
            {
                quantidade += adicionarquantidade;
            }

            public void removerestoque(int removerquantidade)
            {
                if (removerquantidade <= quantidade)
                {
                    quantidade -= removerquantidade;
                }
                else
                {
                    Console.WriteLine("quantidade acima do estoque");
                }
            }

            public void exibirdetalhes()
            {
                Console.WriteLine($"Produto: {nome}");
                Console.WriteLine($"Preço: {preço}");
                Console.WriteLine($"Quantidade em estoque: {quantidade}");
            }
        }


