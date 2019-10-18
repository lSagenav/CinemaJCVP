using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinemajcvp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : TabbedPage
    {
        public Login()
        {
            InitializeComponent();
            btLogin.Clicked += BtLogin_Clicked;
        }

        private async void BtLogin_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {

                await DisplayAlert("Validacion", "Por favor digite un usuario", "ok");
                txtUsuario.Focus();
                return;


            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {

                await DisplayAlert("Validacion", "Por favor digite una contraseña ", "ok");
                txtPassword.Focus();
                return;


            }
            await ((NavigationPage)this.Parent).PushAsync(new Cartelera());


        }
    }
}