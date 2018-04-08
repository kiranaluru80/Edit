using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleDB
{
    public partial class JobInformationPage : ContentPage
    {
        public JobInformationPage()
        {
            
            InitializeComponent();

            resetRef.Clicked += (sender, e) =>
            {
                
               //Navigation.PushAsync(new CommunicationsPage(12,"12345"));
                Navigation.PushAsync(new EditCommunicationsPage(12, "12345"));
            };
        }
    }
}
