namespace Loth.Infra.Migrations
{
    using Loth.Infra.Data.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        
    }
}
