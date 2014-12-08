using Nancy;

namespace NancyApp.Web.Modules
{
	public class Home : NancyModule
	{
		public Home()
		{
			Get["/"] = _ => View["Home", new { Title = "Home", Greeting = "Hi there welcome to my first Nancy application." }];
		}
	}
}