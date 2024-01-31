using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PaintingGuesser
{
    public partial class Load : Window
    {
        Random rnd = new Random();

        public Load()
        {
            InitializeComponent();
            Loaded += async (s, e) => await ProgressAsync();
        }
        private async Task ProgressAsync()
        {
            while (progressLoad.Value < 97)
            {
                if(progressLoad.Value >= 92) { progressLoad.Value++; }
                else { progressLoad.Value += rnd.Next(1, 6); }
                labelPersent.Content = $"{progressLoad.Value.ToString()}%";
                await Task.Delay(200);
            }
            this.Hide();
            var newWindow = new MainWindow();
            newWindow.Show();
        }
    }
    
}
