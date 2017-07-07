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

namespace GridViewTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           

          //  GridCell.ItemsSource = list;
        }
        private void btnChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            //GridCell.SelectedItem = GridCell.Items[3];
            //var container = GridCell.ContainerFromIndex(3);
            //var _children = AllChildrenText(container);
            //var _control = _children.First(c => c.Name == "PhoneNumber");
            //_control.Text = "123456789";
            ViewModel.Items[999].PhoneNumber = "777777777";
        }
        public List<TextBlock> AllChildrenText(DependencyObject parent)
        {
            var _List = new List<TextBlock> { };
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var _Child = VisualTreeHelper.GetChild(parent, i);
                if (_Child is TextBlock)
                {
                    _List.Add(_Child as TextBlock);
                }
                _List.AddRange(AllChildrenText(_Child));
            }
            return _List;
        }
    }
}
