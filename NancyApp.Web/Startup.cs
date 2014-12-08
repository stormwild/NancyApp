using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace NancyApp.Web
{
	public class Startup
	{
		public void Configuration(IAppBuilder builder)
		{
			builder.UseNancy();
		}
	}
}