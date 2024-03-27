using BlazorApp.Components.Layout;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp.Components
{
    public class LoginService
    {
        private readonly NavigationManager _navigationManager;
        private readonly LoginState _loginState;
        public event Action OnLoginStatusChanged;

        private bool _userLoggedIn;
        public bool UserLoggedIn
        {
            get { return _userLoggedIn; }
            private set
            {
                if (_userLoggedIn != value)
                {
                    _userLoggedIn = value;
                    OnLoginStatusChanged?.Invoke();
                }
            }
        }

        public void LogOut()
        {
            UserLoggedIn = false;
        }

        public LoginService(NavigationManager navigationManager, LoginState loginState)
        {
            _navigationManager = navigationManager;
            _loginState = loginState;
        }

        public void NavigateToLogin(string returnUrl)
        {
            _navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(returnUrl)}");
        }

        public void RedirectLastPage(string firstName, string lastName, bool loggedIn, string returnUrl, int profileId)
        {
            UserLoggedIn = loggedIn;
            _navigationManager.NavigateTo(returnUrl);
            _loginState.SetLoggedIn(firstName, lastName, profileId, true);
        }
    }
}
