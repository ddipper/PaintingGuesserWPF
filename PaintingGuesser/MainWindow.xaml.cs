using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaintingGuesser
{
    public partial class MainWindow : Window
    {
        int total = 0;
        int correct = 0;
        public MainWindow()
        {
            InitializeComponent();
            textBlock.Text = string.Empty;
        }

        private void DragArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void DisableCheckBox(object sender)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Grid parentGrid = button.Parent as Grid;
                if (parentGrid != null)
                {
                    foreach (var child in parentGrid.Children)
                    {
                        if (child is CheckBox checkBox)
                        {
                            checkBox.IsChecked = false;
                        }
                        
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            gridStart.Visibility = Visibility.Hidden;
            grid1.Visibility = Visibility.Visible;
        }

        private void Correct_Select(object sender, RoutedEventArgs e)
        {
            if (total >= 4)
            {
                CheckBox checkBox = sender as CheckBox;
                if (checkBox != null)
                {
                    MessageBox.Show("Вы выбрали максимум пунктов!", "Painting Guesser");
                    checkBox.IsChecked = false;
                    total++;
                    return;
                }
            }

            correct++;
            total++;
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            if (total >= 4)
            {
                CheckBox checkBox = sender as CheckBox;
                if (checkBox != null)
                {
                    MessageBox.Show("Вы выбрали максимум пунктов!", "Painting Guesser");
                    checkBox.IsChecked = false;
                    total++;
                    return;
                }
            }

            total++;
        }
        private void Unselect(object sender, RoutedEventArgs e)
        {
            total--;
        }

        private void Correct_Unselect(object sender, RoutedEventArgs e)
        {
            total--;
            correct--;
        }

        private void ButtonCheck1_Click(object sender, RoutedEventArgs e)
        {
            if(correct >= 2)
            {
                DisableCheckBox(sender);
                (sender as Button).IsEnabled = false;

                textBlock.TextAlignment = TextAlignment.Justify;
                textBlock.Text = "Образование – первая потребность человека после хлеба насущного (Дантон)";

                buttonNext1.Content = "Дальше";
                buttonNext1.IsEnabled = true;

                total = 0;
                correct = 0;

                return;
            }

            else if(total == 0)
            {
                MessageBox.Show("Вы ничего не выбрали.", "Painting Guesser");

                return;
            }

            else
            {
                DisableCheckBox(sender);

                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Text = "Увы, вы не отгадали ассоциации, можете попробовать еще раз.";

                total = 0;
                correct = 0;

                return;
            }
        }


    }
}
