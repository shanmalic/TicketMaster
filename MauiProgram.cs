using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using TicketMaster.Services;

namespace TicketMaster
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services.AddScoped(sp => new HttpClient());
            builder.Services.AddScoped<ITicketmasterService, TicketmasterService>();
            builder
                .UseMauiApp<App>()
                .ConfigureLifecycleEvents(events =>
                {
#if WINDOWS
                    events.AddWindows(windows =>
                    {
                        windows.OnWindowCreated(window =>
                        {
                            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
                            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hwnd);
                            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

                            appWindow.Resize(new Windows.Graphics.SizeInt32
                            {
                                Width = 500,
                                Height = 850
                            });
                        });
                    });
#endif
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Register services
            builder.Services.AddMauiBlazorWebView();
            //builder.Services.AddSingleton<TicketmasterService>();
            builder.Services.AddSingleton<ITicketmasterService, TicketmasterService>();

            builder.Services.AddSingleton(new HttpClient());

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
