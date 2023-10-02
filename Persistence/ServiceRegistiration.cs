using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
	public static class ServiceRegistiration
	{
		public static void AddPersistenceService(this IServiceCollection services)
		{
			services.AddDbContext<APIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));		}
	}
}
