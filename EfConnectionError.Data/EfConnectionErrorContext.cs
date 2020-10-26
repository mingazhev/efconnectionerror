using System;
using Microsoft.EntityFrameworkCore;

namespace EfConnectionError.Data
{
    public class EfConnectionErrorContext : DbContext
    {
        public EfConnectionErrorContext(DbContextOptions<EfConnectionErrorContext> options) : base(options)
        { }
    }
}