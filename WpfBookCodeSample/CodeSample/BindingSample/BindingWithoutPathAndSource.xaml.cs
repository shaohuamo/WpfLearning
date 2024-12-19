using System.Windows;

namespace WpfBookCodeSample.CodeSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingWithoutPathAndSource.xaml
    /// </summary>
    public partial class BindingWithoutPathAndSource : Window
    {
        public BindingWithoutPathAndSource()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(btn.DataContext.ToString());
        }
    }
}
