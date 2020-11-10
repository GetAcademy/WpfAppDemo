using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppDemo
{
    class ClickerWindow : Window
    {
        public ClickerWindow(int count)
        {
            var stackPanel = new StackPanel();
            for (var i = 0; i < count; i++)
            {
                var clickerPanel = new ClickerPanel();
                stackPanel.Children.Add(clickerPanel);
            }

            Content = stackPanel;
        }
    }
}
