using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaundryApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text=="admin123")
            { 
                Navigation.PushAsync(new Tampilan_home());
            }
            else
            {
                DisplayAlert("Maaf", "Username atau Passoword yang anda masukkan salah!", "Ok");
            }


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}