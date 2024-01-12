using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Stocks.Domain.Repositories;
using Stocks.Infrastructure.Repositories;
using MongoDB.Driver;


namespace Stocks.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfraestructure(
            this IServiceCollection services, string connectionString
            )
        {

            services.AddDataBaseFactories(connectionString);
            services.AddRepositories();
        }

        private static void AddDataBaseFactories(this IServiceCollection services, string connectionString)
        {
            //mongodb://127.0.0.1:27017/?retryWrites=true&loadBalanced=false&connectTimeoutMS=10000
            services.AddSingleton(mongoDatabase =>
            {
                var mongoClient = new MongoClient(connectionString);
                return mongoClient.GetDatabase("db-productos-stocks");
            });

        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductoRepository, ProductoRepository>();

            
        }
    }
}
