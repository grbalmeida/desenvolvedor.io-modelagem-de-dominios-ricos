using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoFinalizadoEvent : Event
    {
        public Guid PedidoId { get; private set; }

        public PedidoFinalizadoEvent(Guid pedidoId)
        {
            AggregateId = pedidoId;
            PedidoId = pedidoId;
        }
    }
}
