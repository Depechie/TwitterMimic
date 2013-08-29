using System.Collections.Generic;
using Microsoft.Phone.Controls;

namespace TwitterMimic
{
    public class PathData
    {
        public string XAMLContent { get; set; }
    }

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();            
        }

        private void ImageBar_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.ContentPivot.SelectedIndex = this.ImageBar.SelectedIndex;
        }

        private void ContentPivot_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.ImageBar.SelectedIndex = ((Pivot)sender).SelectedIndex;
        }
    }
}