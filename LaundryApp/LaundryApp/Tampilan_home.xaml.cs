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
    public partial class Tampilan_home : ContentPage
    {
        public Tampilan_home()
        {
            InitializeComponent();
            
        }
        

        private void Button_Pesan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DaftarPesanan());
        }

        private void Button_Notif(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notifikasi());
        }

        private void Button_Akun(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Info_Akun());
        }
        
    }
}