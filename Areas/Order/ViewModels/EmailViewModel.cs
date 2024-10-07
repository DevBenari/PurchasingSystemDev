namespace PurchasingSystemApps.Areas.Order.ViewModels
{
    public class EmailViewModel
    {
        public Guid? Emailid { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Pesan { get; set; }
        public string Status { get; set; }
        public string AttachmentFileName { get; set; }
    }
}
