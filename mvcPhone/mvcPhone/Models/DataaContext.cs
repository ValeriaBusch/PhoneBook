using System.Data.Entity;

namespace mvcPhone.Models
{
    public class DataaContext:DbContext
    {
        public DataaContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mvcPhone.Models.Phone> Phones { get; set; }
    }
}