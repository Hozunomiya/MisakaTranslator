﻿using Config.Net;
using HandyControl.Controls;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MisakaTranslator_WPF
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAppearance();
        }

        private void InitializeAppearance()
        {
            ISettings settings = new ConfigurationBuilder<ISettings>().UseJsonFile("settings/settings.json").Build();
            this.Resources["Foreground"] = (SolidColorBrush)(new BrushConverter().ConvertFrom(settings.ForegroundHex));
        }
    }
}
