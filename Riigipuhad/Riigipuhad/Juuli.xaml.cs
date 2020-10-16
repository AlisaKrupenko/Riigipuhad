﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juuli : ContentPage
    {
        Label lbl1;
        public Juuli()
        {
            lbl1 = new Label()
            {
                Text = "Juulis pole pühi!",
                TextColor = Color.FromHex("#897d03")
            }; 
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#ebcc03"),
                Children = { lbl1}
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}