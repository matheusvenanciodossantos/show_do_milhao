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
				fonts.AddFont("Stoehr_Numbers.ttf ", "Number");
				fonts.AddFont("GaelleNumber5.ttf", "Numbers");
				fonts.AddFont("Technology-Bold.ttf", "LetraDeRelogio");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
