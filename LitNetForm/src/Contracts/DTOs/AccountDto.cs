using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contracts.DTOs;

public record AccountDto : INotifyPropertyChanged
{
    private string _login;
    private string _password;
    private bool _litNet;
    private bool _litMarket;

    public AccountDto(string login, string password, bool litNet, bool litMarket)
    {
        _login = login;
        _password = password;
        _litNet = litNet;
        _litMarket = litMarket;
    }

    public int Id { get; init; }
    
    public string Login { get => _login;
        set
        {
            if (_login == value) return;
            _login = value;
            OnPropertyChanged(nameof(Login));
        } 
    }

    public string Password
    {
        get => _password;
        set
        {
            if (_password == value) return;
            _password = value;
            OnPropertyChanged(nameof(Password));
        }
    }

    public bool LitNet { 
        get => _litNet;
        set
        {
            if (_litNet == value) return;
            _litNet = value;
            OnPropertyChanged(nameof(LitNet));
        }
    }
    
    public bool LitMarket { 
        get => _litMarket;
        set
        {
            if (_litMarket == value) return;
            _litMarket = value;
            OnPropertyChanged(nameof(LitMarket));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}