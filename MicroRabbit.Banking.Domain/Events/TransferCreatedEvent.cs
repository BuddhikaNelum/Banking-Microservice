using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int TO { get; private set; }
        public decimal Amount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            From = from;
            TO = to;
            Amount = amount;
        }
    }
}
