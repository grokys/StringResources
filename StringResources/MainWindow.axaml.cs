using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.MarkupExtensions;

namespace StringResources
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dict = new ResourceInclude { Source = new Uri("avares://StringResources/Languages/StringResources.English.axaml") };
            var translatedWord = dict.Loaded["UserLevel"];
            Content = translatedWord;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
