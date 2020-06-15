using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EndereçoCompleto { get; set; }

        public int NumeroEndereço { get; set; }

        public int FormaPagamentoID { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um Itém de Pedido
        /// ou Muitos Itens de Pedido
        /// </summary>
        public ICollection <ItemPedido> ItensPedidos { get; set; }
    }
}
