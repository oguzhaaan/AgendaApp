namespace Agenda_App.Models
{
	public class Group
	{
		public int Id { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }

	}
}
