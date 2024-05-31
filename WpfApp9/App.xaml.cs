using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp9
{
    public partial class App : Application
    {

        private static string lang;
        public static string Lang
        {
            get { return lang; }
            set
            {
                lang = value;
                var dict = new ResourceDictionary { Source = new Uri($"/CustomLib;component/Dictionaries/lang.{value}.xaml", UriKind.Relative) };
                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        public App()
        {
            InitializeComponent();

        }
    }
}
