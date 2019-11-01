using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace screenTransition
{
    /// <summary>
    /// Start.xaml の相互作用ロジック
    /// </summary>
    public partial class Start : Page
    {

        private static Detail detail = null;

        public Start()
        {
            InitializeComponent();

            this.DataContext = new { Store.Person };
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (detail == null)
            {
                // 次に表示するページを生成、以後使いまわし
                detail = new Detail();
            }

            // 移動
            this.NavigationService.Navigate(detail);
        }

    }
}
