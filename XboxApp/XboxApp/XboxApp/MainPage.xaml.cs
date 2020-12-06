using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XboxApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            fillInfo();
        }

        public void fillInfo()
        {
            List<DummyUserModel> dummyUserModels = new List<DummyUserModel>
            {
                new DummyUserModel
                {
                    NameSurname = "Ahmet Çotur",
                    ImageUrl = "ahmet.png"
                },
                new DummyUserModel
                {
                    NameSurname = "Barış Hasdemir",
                    ImageUrl = "baris.jpg"
                },
                new DummyUserModel
                {
                    NameSurname = "Berke Can Ongun",
                    ImageUrl = "berke.jpg"
                },
                new DummyUserModel
                {
                    NameSurname = "Ebubekir Sezer",
                    ImageUrl = "ebubekir.jpg"
                },
                new DummyUserModel
                {
                    NameSurname = "Fatih Zor",
                    ImageUrl = "fatih.jpg"
                },
                new DummyUserModel
                {
                    NameSurname = "Ferhat Ali Tokuç",
                    ImageUrl = "ferhat.jpeg"
                },
                new DummyUserModel
                {
                    NameSurname = "Mert Can Bilgiç",
                    ImageUrl = "mert.jpg"
                },
                new DummyUserModel
                {
                    NameSurname = "Mert Sancar",
                    ImageUrl = "merts.jpg"
                },
                new DummyUserModel
                {
                    NameSurname = "Vuslat Sena Emre",
                    ImageUrl = "vuslat.jpg"
                }
            };

            mslaList.BindingContext = dummyUserModels;
        }
    }
}
