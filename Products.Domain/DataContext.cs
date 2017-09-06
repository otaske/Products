namespace Products.Domain
{
    using System.Data.Entity;

    class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
    }
}
