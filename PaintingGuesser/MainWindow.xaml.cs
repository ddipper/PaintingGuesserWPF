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


        // ------------------------------ 1 FIRST
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

        private void ButtonNext1_Click(object sender, RoutedEventArgs e)
        {
            grid1.Visibility = Visibility.Hidden;
            grid2.Visibility = Visibility.Visible;

            textBlock.Text = "";
        }



        // ------------------------------ 2 SECOND
        private void ButtonCheck2_Click(object sender, RoutedEventArgs e)
        {
            if (correct >= 2)
            {
                DisableCheckBox(sender);
                (sender as Button).IsEnabled = false;

                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Text = "Печаль разделенная – печаль уменьшенная (Народная мудрость)";

                buttonNext2.Content = "Дальше";
                buttonNext2.IsEnabled = true;

                total = 0;
                correct = 0;

                return;
            }

            else if (total == 0)
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
        private void ButtonNext2_Click(object sender, RoutedEventArgs e)
        {
            grid2.Visibility = Visibility.Hidden;
            grid3.Visibility = Visibility.Visible;

            textBlock.Text = "";
        }



        // ------------------------------ 3 THIRD
        private void ButtonCheck3_Click(object sender, RoutedEventArgs e)
        {
            if (correct >= 2)
            {
                DisableCheckBox(sender);
                (sender as Button).IsEnabled = false;

                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Text = "Природа  - это источник всего, что существует на земле. Ее язык загадочен и разнообразен. Природа – это искусство Бога. Врач лечит, природа исцеляет (Гиппократ)";

                buttonNext3.Content = "Дальше";
                buttonNext3.IsEnabled = true;

                total = 0;
                correct = 0;

                return;
            }

            else if (total == 0)
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
        private void ButtonNext3_Click(object sender, RoutedEventArgs e)
        {
            grid3.Visibility = Visibility.Hidden;
            grid4.Visibility = Visibility.Visible;

            textBlock.Text = "";
        }



        // ------------------------------ 4 FOURTH
        private void ButtonCheck4_Click(object sender, RoutedEventArgs e)
        {
            if (correct >= 2)
            {
                DisableCheckBox(sender);
                (sender as Button).IsEnabled = false;

                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Text = "Любовь к родным людям – величайшее благо жизни (Афоризм)\nДругие вещи могут нас изменить, но мы начинаем и заканчиваем семьей (Энтони Брандт)";

                buttonNext4.Content = "Дальше";
                buttonNext4.IsEnabled = true;

                total = 0;
                correct = 0;

                return;
            }

            else if (total == 0)
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
        private void ButtonNext4_Click(object sender, RoutedEventArgs e)
        {
            grid4.Visibility = Visibility.Hidden;
            grid5.Visibility = Visibility.Visible;

            textBlock.Text = "";
        }



        // ------------------------------ 5 FIFTH
        private void ButtonCheck5_Click(object sender, RoutedEventArgs e)
        {
            if (correct >= 2)
            {
                DisableCheckBox(sender);
                (sender as Button).IsEnabled = false;

                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Text = "Добрый досуг. Я никогда не бываю так занят, как в часы досуга. Уметь с умом распоряжаться досугом – высшая степень цивилизованности (Цицерон)";

                buttonNext5.Content = "Дальше";
                buttonNext5.IsEnabled = true;

                total = 0;
                correct = 0;

                return;
            }

            else if (total == 0)
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
        private void ButtonNext5_Click(object sender, RoutedEventArgs e)
        {
            grid5.Visibility = Visibility.Hidden;
            grid6.Visibility = Visibility.Visible;

            textBlock.Text = "";
        }



        // ------------------------------ 6 SIXTH
        private void ButtonCheck6_Click(object sender, RoutedEventArgs e)
        {
            if (correct >= 2)
            {
                DisableCheckBox(sender);
                (sender as Button).IsEnabled = false;

                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Text = "Каждому ребенку нужен мир, где можно смеяться, играть и быть счастливым (Бертран Рассел)";

                buttonNext6.Content = "Дальше";
                buttonNext6.IsEnabled = true;

                total = 0;
                correct = 0;

                return;
            }

            else if (total == 0)
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
        private void ButtonNext6_Click(object sender, RoutedEventArgs e)
        {
            grid6.Visibility = Visibility.Hidden;
            grid6.Visibility = Visibility.Visible;

            textBlock.Text = "";
        }
    }
}
