using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx) 
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAcounts()
        {
            return _ctx.Accounts;
        }
    }
}
