namespace BookstoreAPP.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int BookId { get; set; }
		public int Quantity { get; set; }
		public DateTime OrderDate { get; set; }
	}

}
