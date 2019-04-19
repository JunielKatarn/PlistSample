using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Claunia.PropertyList;

namespace PlistSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        string _plistString = @"
        <plist version=""1.0"">
            <dict>
                <key>key1</key>
                <string>value1</string>
                <key>key2</key>
                <string>value2</string>
            </dict>
        </plist>";

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var bytes = Encoding.ASCII.GetBytes(_plistString);
            var dict = PropertyListParser.Parse(bytes) as NSDictionary;

            DisplayAlert("Parsed!", $"The dictionary has {dict.Keys.Count} keys.", "Cancel");
        }
    }
}
