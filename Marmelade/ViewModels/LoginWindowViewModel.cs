using System;
using System.Windows.Input;
using ReactiveUI;

namespace Marmelade.ViewModels;

public class LoginWindowViewModel : ViewModelBase
{
    private string _password;
    private string _serverURL;
    private string _username;

    public LoginWindowViewModel()
    {
        ConnectCommand = ReactiveCommand.Create(() =>
        {   
            
           
        });
    }

    public string Username
    {
        get => _username;
        set => this.RaiseAndSetIfChanged(ref _username, value);
    }

    public string Password
    {
        get => _password;
        set => this.RaiseAndSetIfChanged(ref _password, value);
    }

    public ICommand ConnectCommand { get; }


    public string ServerURL
    {
        get => _serverURL;
        set => this.RaiseAndSetIfChanged(ref _serverURL, value);
    }
}