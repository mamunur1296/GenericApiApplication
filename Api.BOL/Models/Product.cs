
using System.ComponentModel.DataAnnotations;


namespace Api.BOL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int ProdSizeId { get; set; }
        public int ProdValveId { get; set; }
        public string ProdImage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual ProductSize Size { get; set; }
        public virtual Valve Valve { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProdReturn> Returns { get; set; }
    }
}
