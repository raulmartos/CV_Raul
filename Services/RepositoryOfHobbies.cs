using CV_Raul.Models;

namespace CV_Raul.Services
{
    public class RepositoryOfHobbies
    {
		public List<ClassHobbies> GetProjects()
		{
			return new List<ClassHobbies>() {
				new ClassHobbies
				{
					Title = "ASP.net",
					Description = "Juego realizado en ASP.NET Core",
					VideoURL = "/archivos/video1.MP4"
				},
				new ClassHobbies
				{
					Title = "PHP",
					Description = "eCommerce realizado con PHP",
					VideoURL = "/archivos/video2.mov"
				},
				new ClassHobbies
				{
					Title = "PHP",
					Description = "WEB realizado en ASP.NET Core",
					VideoURL = "/archivos/video5.mov"
				}
			};
		}
	}
}
