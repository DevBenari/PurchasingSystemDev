using PurchasingSystemApps.Repositories;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PurchasingSystemApps.Areas.Order.Models
{
    [Table("OrdPurchaseEmail", Schema = "dbo")]
    public class Email : UserActivity
    {
        [Key]
        public Guid? Emailid { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Pesan { get; set; }
        public string Status { get; set; }
        public string AttachmentFileName { get; set; }
    }
}
