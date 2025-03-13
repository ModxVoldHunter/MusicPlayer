using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media;

namespace MusicPlayer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer MediaPlayer = new MediaPlayer();
            //MediaPlayer.Play
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    public class MusicPlayerApp
    {
        public string Fileimported;
        public static MusicPlayerApp FileOpen()
        {
            FileDialog FileDialog;
            string FileName;
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Media files (*.mp3;*.flac;*.wav)|*.mp3;*.flac;*.wav|All files (*.*)|*.*";
            
            
            return FileOpen();
        }

        public static void ImportMedia(string IMPORTEDMEDIA)
        {
            FileOpen();
            
        }
    }
}