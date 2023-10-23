using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WordPad_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Title = "Open File",
            InitialDirectory = @"C:\",
            Filter = "Text Files|*.txt|All Files|*.*",
            FilterIndex = 1
        };
        private void btn_open_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFile = openFileDialog.FileName;
                txt.Text = selectedFile;
                string text = File.ReadAllText(selectedFile);

                TextRange textRange = new TextRange(rich_txt.Document.ContentStart, rich_txt.Document.ContentEnd);
                textRange.Text = text;
            }

        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (txt.Text != null)
            {
                TextRange textRange = new TextRange(rich_txt.Document.ContentStart, rich_txt.Document.ContentEnd);

                File.WriteAllText(openFileDialog.FileName, textRange.Text);
            }
        }

        private void btn_cut_Click(object sender, RoutedEventArgs e)
        {
            rich_txt.Background = new SolidColorBrush(Color.FromArgb(255,255, 255, 255));
            if (rich_txt.Selection.Text.Length > 0)
            {
                string path = @".../../../Save/text.txt";

                Clipboard.SetText(rich_txt.Selection.Text);//secilmis hisseni kesmek

                string cutText = rich_txt.Selection.Text;
                TextRange textRange = new TextRange(rich_txt.Selection.Start, rich_txt.Selection.End);
                textRange.Text = string.Empty;
                using (FileStream fileStream = new(path, FileMode.Truncate, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.Write(cutText);
                }
            }



        }

        private void btn_copy_Click(object sender, RoutedEventArgs e)
        {
            rich_txt.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            string path = @".../../../Save/text.txt";
            TextRange textRange = new TextRange(rich_txt.Document.ContentStart, rich_txt.Document.ContentEnd);
            string cutText = rich_txt.Selection.Text;

            using (FileStream fileStream = new(path,FileMode.Truncate, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(cutText);
            }
        }

        private void btn_paste_Click(object sender, RoutedEventArgs e)
        {
            rich_txt.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            string path = @".../../../Save/text.txt";
            if (File.Exists(path))
            {
                string textFromFile = File.ReadAllText(path);
                rich_txt.Selection.Text = textFromFile;
            }
        }
        private void btn_selectAll_Click(object sender, RoutedEventArgs e)
        {
            rich_txt.SelectAll();
            rich_txt.Background = new SolidColorBrush(Color.FromArgb(255, 173, 216, 230));
        }


        private void rich_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (checkbox.IsChecked == true)
            {
                if (txt.Text != null)
                {
                    TextRange textRange = new TextRange(rich_txt.Document.ContentStart, rich_txt.Document.ContentEnd);

                    File.WriteAllText(openFileDialog.FileName, textRange.Text);
                }
            }
        }
    }
}
