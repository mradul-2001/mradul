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

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String[] str = new String[10];
        
        int i = 0;
        public MainPage()
        {
            this.InitializeComponent();
            
            
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            str[i] = inp.Text;
            i++;
            inp.Text = "";
            if (str[0] != null)
                clickme.Text = str[0];
            if (str[1] != null)
                clickme.Text = str[1];
            if (str[2] != null)
                clickme.Text = str[2];
            if (str[3] != null)
                clickme.Text = str[3];
            if (str[4] != null)
                clickme.Text = str[4];
            if (str[5] != null)
                clickme.Text = str[5];
            if (str[6] != null)
                clickme.Text = str[6];
            if (str[7] != null)
                clickme.Text = str[6];
            if (str[8] != null)
                clickme.Text = str[7];
        }  
    }
}
