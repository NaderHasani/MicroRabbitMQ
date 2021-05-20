using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext ctx;

        public TransferRepository(TransferDbContext _ctx)
        {
            ctx = _ctx;
        }

        public void Add(TransferLog transferLog)
        {
            ctx.transferLogs.Add(transferLog);
            ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return ctx.transferLogs;
        }
    }
}
