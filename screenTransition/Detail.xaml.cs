using screenTransition.viewmodels;
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
    /// Detail.xaml の相互作用ロジック
    /// </summary>
    public partial class Detail : Page
    {
        private List<Person> Persons = new List<Person>();
        public Detail()
        {
            InitializeComponent();

            Persons.Add(Store.Person);
            this.DataContext = new { Persons, Store.Person };
        }
    }
}
