using CV_Raul.Models;

namespace CV_Raul.Services
{
	public class RepositoryOfProjects
	{
		public List<ClassProjects> GetProjects()
		{
			return new List<ClassProjects>() {
				new ClassProjects
				{
					Title = "ASP.net",
					Description = "Juego realizado en ASP.NET Core",
					Link = "/home/php",
					ImageURL = "/images/asp.png"
				},
				new ClassProjects
				{
					Title = "PHP",
					Description = "eCommerce realizado con PHP",
					Link = "/home/php",
					ImageURL = "/images/php.png"
				},
				new ClassProjects
				{
					Title = "PHP",
					Description = "WEB realizado en ASP.NET Core",
					Link = "https://amazon.com",
					ImageURL = "/images/asp.png"
				}
			};
		}
	}
}
