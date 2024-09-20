using Microsoft.Extensions.Logging;

namespace showDoMilhao;

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
				fonts.AddFont("RoyalFlush_Basic-Regular.ttf", "FontCard");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
