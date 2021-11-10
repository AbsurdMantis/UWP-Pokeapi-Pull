﻿using PokedexAPI_Test;
using PokedexAPI_Test.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokedexMix
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ApiRequest api = new ApiRequest();

        public MainPage()
        {
            this.InitializeComponent();
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
    }
}