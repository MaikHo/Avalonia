// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using RenderTest.ViewModels;
using ReactiveUI;
using Avalonia.Rendering;

namespace RenderTest
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();

            var vm = new MainWindowViewModel();
            vm.WhenAnyValue(x => x.DrawFps).Subscribe(x => RendererMixin.DrawFpsCounter = x);
            this.DataContext = vm;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
