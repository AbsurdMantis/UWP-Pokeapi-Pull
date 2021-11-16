using PokedexAPI_Test;
using PokedexAPI_Test.Models;
using PokedexMix.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static PokedexMix.Models.PokemonDataWrapper;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokedexMix
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ApiRequest api = new ApiRequest();
        UnitRequest api2 = new UnitRequest();
        
        

        public MainPage()
        {
            
            this.InitializeComponent();
            PokeList weather = api.GetList();
            Pokemon X = api2.GetPokey();
            this.DataContext = X;
            
        }

   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PokeList weather = api.GetList();

            //ResultTextBlock.Text = weather.listPokemon[2].NamePokemon;

            
                foreach (var item in weather.listPokemon)
                {
                    for (int i = 0; i < 9; i++) {
                        ResultTextBlock.Text += weather.listPokemon[i].NamePokemon + " - ";

                }
            }
            
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //PokeList weather = api.GetList();
            //Pokemon poketest = new Pokemon();
            Pokemon X = api2.GetPokey();

            List<Pokemon> listPkm = new List<Pokemon>();

            listPkm.Add(X);


            ListViewTest.ItemsSource = listPkm;
            
        }
    }
}
