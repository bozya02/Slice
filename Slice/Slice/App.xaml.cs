using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Slice.View;
using Slice.LocalDB;
using System.IO;

namespace Slice
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Slice.db";
        private static LocalRepository _database;
        public static LocalRepository Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new LocalRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthorizationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
