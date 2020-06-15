using System;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Id == 0)
                AdicionarCritica("Identificação do Produto não informada.");

            if (Preco == 0)
                AdicionarCritica("Preço do Produto não informação");
        }
    }
}
