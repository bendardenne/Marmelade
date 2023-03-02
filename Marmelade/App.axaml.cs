using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using JellyfinClient;
using Marmelade.ViewModels;
using Marmelade.Views;
using Splat;
using Splat.NLog;

namespace Marmelade;

public partial class App : Application
{
    public override void Initialize()
    {
        Locator.CurrentMutable.UseNLogWithWrappingFullLogger();
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            ExpressionObserver.DataValidators.RemoveAll(x => x is DataAnnotationsValidationPlugin);
            desktop.MainWindow = new LoginWindow
            {
                DataContext = new LoginWindowViewModel(),
            };
            
            // var httpClient = new HttpClient(new LoggingHandler( new HttpClientHandler() ));
            // var auth = "Client=\"Marmelade\", DeviceId=\"test\", Device=\"test\", Version=\"0.0.1\" ";
            // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("MediaBrowser",auth);
            // var client = new Client(httpClient);
            //
            // client.BaseUrl = "https://media.bendardenne.be";
            //
            // var authenticateUserByNameAsync = client.AuthenticateUserByNameAsync(new AuthenticateUserByName()
            // { Username = "benoit", Pw = "poisonpasfrais" });
            //
            // authenticateUserByNameAsync.Wait();
        }

        base.OnFrameworkInitializationCompleted();
    }
}