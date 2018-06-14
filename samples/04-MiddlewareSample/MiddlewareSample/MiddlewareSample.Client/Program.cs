﻿using Blazor.Fluxor;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;

namespace MiddlewareSample.Client
{
	public class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = new BrowserServiceProvider(services =>
			{
				services.AddFluxor(options =>
					options
						//.AddMiddleware<AnExampleMiddleware>()
						.UseDependencyInjection(typeof(Program).Assembly)
				);
			});

			new BrowserRenderer(serviceProvider).AddComponent<App>("app");
		}
	}
}
