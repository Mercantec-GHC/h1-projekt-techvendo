using Microsoft.Extensions.Primitives;
using System.ComponentModel;
using BlazorApp.Components;

namespace BlazorApp.Components
{
    public class LoginState : INotifyPropertyChanged
    {
        public bool UserLoggedIn { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public int ProfileId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetLoggedIn(string firstName, string lastName, int profileId, bool loggedIn)
        {
            UserLoggedIn = loggedIn;
            UserFirstname = firstName;
            UserLastname = lastName;
            ProfileId = profileId;

            OnPropertyChanged(nameof(UserLoggedIn));
            OnPropertyChanged(nameof(UserFirstname));
            OnPropertyChanged(nameof(UserLastname));
            OnPropertyChanged(nameof(ProfileId));
        }

        public void SetLoggedOut()
        {
            UserLoggedIn = false;
            UserFirstname = string.Empty;
            UserLastname = string.Empty;
            ProfileId = 0;

            OnPropertyChanged(nameof(UserLoggedIn));
            OnPropertyChanged(nameof(UserFirstname));
            OnPropertyChanged(nameof(UserLastname));
            OnPropertyChanged(nameof(ProfileId));
        }
    }
}
