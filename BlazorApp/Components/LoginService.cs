using BlazorApp.Components.Layout;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp.Components
{
    public class LoginService
    {
        private readonly NavigationManager _navigationManager;
        private readonly LoginState _loginState;

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
            _navigationManager.NavigateTo(returnUrl);
            _loginState.SetLoggedIn(firstName, lastName, profileId, true);
        }
    }
}
