using MicroRabbit.Banking.Application.Interface;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;


namespace MicroRabbit.Infra.IOC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();

            services.AddTransient<IAccountService, AccountService>();

            services.AddTransient<IAccountRepository,AccountRepository>();

            services.AddTransient<BankingDbContext>();

        }
    }
}
