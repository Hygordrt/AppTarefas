using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarefas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Aqui chama a pagina
            MainPage = new NavigationPage(new Telas.Listar());
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
