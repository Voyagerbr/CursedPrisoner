﻿using Microsoft.Extensions.Logging;

namespace CursedPrisoner;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("ARCADE.otf", "Arcade");
				fonts.AddFont("ARCADE-Italic.otf", "ArcadeItalic");
				fonts.AddFont("GajrajOne-Regular.ttf", "Garaj");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
