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
    public partial class Notifikasi : ContentPage
    {
        public Notifikasi()
        {
            InitializeComponent();
        }
        private void Button_Home(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tampilan_home());
        }
        private void Button_Pesan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DaftarPesanan());
        }
        private void Button_Akun(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Info_Akun());
        }
    }
}