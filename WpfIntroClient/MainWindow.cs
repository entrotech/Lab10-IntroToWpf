using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfIntroClient
{

    class MainWindow : Window
    {
        TextBox textBox;
        TextBlock resultTextBlock;

        public MainWindow()
        {
            // Set Some Properties of the Window itself
            SizeToContent = SizeToContent.WidthAndHeight;
            Title = "WPF Intro";
            FontSize = 16;

            // Create a new Canvas layout panel to
            // hold various controls, and make it the
            // Content of the Window
            var canvas = new Canvas();
            canvas.Width = 300;
            canvas.Height = 200;
            canvas.Background = new SolidColorBrush(Colors.SteelBlue);
            this.Content = canvas;

            // Create a TextBlock
            var textBlock = new TextBlock()
            {
                Text = "Please enter your name:"
            };
            canvas.Children.Add(textBlock);

            // Position the child object (textBlock) within
            // the Layout panel using special "attached" 
            // properties. I.e., the positioning properties
            // are Canvas-related properties attached to the
            // TextBlock
            textBlock.SetValue(Canvas.LeftProperty, (double)20);
            textBlock.SetValue(Canvas.TopProperty, (double)20);

            // Create a TextBox for accepting input
            textBox = new TextBox()
            {
                Width = 150
            };
            canvas.Children.Add(textBox);

            // Position the TextBox with attached properties
            textBox.SetValue(Canvas.LeftProperty, (double)20);
            textBox.SetValue(Canvas.TopProperty, (double)50);

            // Create a button
            var button = new Button()
            {
                Content = "Run"
            };
            canvas.Children.Add(button);
            button.SetValue(Canvas.LeftProperty, (double)170);
            button.SetValue(Canvas.TopProperty, (double)50);

            // Create an empty TextBlock
            resultTextBlock = new TextBlock();
            canvas.Children.Add(resultTextBlock);

            resultTextBlock.SetValue(Canvas.LeftProperty, (double)20);
            resultTextBlock.SetValue(Canvas.TopProperty, (double)80);

            var throwButton = new Button()
            {
                Content = "Throw error!"
            };
            canvas.Children.Add(throwButton);
            throwButton.SetValue(Canvas.RightProperty, (double)20);
            throwButton.SetValue(Canvas.BottomProperty, (double)20);

            button.Click += Button_Click;
            throwButton.Click += ThrowButton_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = "Hello, " + textBox.Text;
        }

        private void ThrowButton_Click(object sender, RoutedEventArgs e)
        {
            throw new ApplicationException("Ouch!");
        }
    }
}

