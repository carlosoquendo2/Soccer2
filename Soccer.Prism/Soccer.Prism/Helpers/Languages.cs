﻿using Soccer.Prism.Interfaces;
using Soccer.Prism.Resources;
using Xamarin.Forms;

namespace Soccer.Prism.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            Culture = ci.ToString();
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Culture { get; set; }

        public static string PictureSource => Resource.PictureSource;

        public static string Cancel => Resource.Cancel;

        public static string FromCamera => Resource.FromCamera;

        public static string FromGallery => Resource.FromGallery;

        public static string Ok => Resource.Ok;

        public static string DocumentError => Resource.DocumentError;

        public static string FirstNameError => Resource.FirstNameError;

        public static string LastNameError => Resource.LastNameError;

        public static string Address => Resource.Address;

        public static string AddressError => Resource.AddressError;

        public static string AddressPlaceHolder => Resource.AddressPlaceHolder;

        public static string Phone => Resource.Phone;

        public static string PhoneError => Resource.PhoneError;

        public static string PhonePlaceHolder => Resource.PhonePlaceHolder;

        public static string FavoriteTeam => Resource.FavoriteTeam;

        public static string FavoriteTeamError => Resource.FavoriteTeamError;

        public static string FavoriteTeamPlaceHolder => Resource.FavoriteTeamPlaceHolder;

        public static string PasswordConfirm => Resource.PasswordConfirm;

        public static string PasswordConfirmError1 => Resource.PasswordConfirmError1;

        public static string PasswordConfirmError2 => Resource.PasswordConfirmError2;

        public static string PasswordConfirmPlaceHolder => Resource.PasswordConfirmPlaceHolder;

        public static string Logout => Resource.Logout;

        public static string LoginError => Resource.LoginError;

        public static string Email => Resource.Email;

        public static string EmailPlaceHolder => Resource.EmailPlaceHolder;

        public static string EmailError => Resource.EmailError;

        public static string Password => Resource.Password;

        public static string PasswordError => Resource.PasswordError;

        public static string PasswordPlaceHolder => Resource.PasswordPlaceHolder;

        public static string Register => Resource.Register;

        public static string Open => Resource.Open;

        public static string Closed => Resource.Closed;

        public static string Groups => Resource.Groups;

        public static string Accept => Resource.Accept;

        public static string ConnectionError => Resource.ConnectionError;

        public static string Error => Resource.Error;
        
        public static string Name => Resource.Name;

        public static string MP => Resource.MP;

        public static string MW => Resource.MW;

        public static string MT => Resource.MT;

        public static string ML => Resource.ML;

        public static string PO => Resource.PO;

        public static string GD => Resource.GD;

        public static string Loading => Resource.Loading;

        public static string Tournaments => Resource.Tournaments;

        public static string MyPredictions => Resource.MyPredictions;

        public static string MyPositions => Resource.MyPositions;

        public static string ModifyUser => Resource.ModifyUser;

        public static string Login => Resource.Login;
    }
}
