using ClassLibraryLabo2;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLabo2
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                Name = "Albert Cupont",
                AdressLine1 = "Rue des Cerisiers, 16",
                City = "Arlon",
                Country = "Belgique",
                EMail = "info@me.com",
                Id = 3,
                Remark = "Ne pas avoir peur des chiens pour aller chez ce client",
                PostCode = "6700"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
