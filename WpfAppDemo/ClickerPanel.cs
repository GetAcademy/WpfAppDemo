using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppDemo
{
    class ClickerPanel : StackPanel
    {
        private int _count = 0;
        private Label _label;
        private Button _button;

        public ClickerPanel()
        {
            _button = new Button();
            _button.Content = "Klikk her";
            _button.Width = 300;
            Children.Add(_button);
            _button.Click += ButtonClick;

            _label = new Label();
            _label.Content = "Hei!";
            _label.Width = 300;
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = $"Du har klikket {_count} ganger.";
        }
    }
}
