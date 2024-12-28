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
using System.Windows.Shapes;
using WpfBookCodeSample.Model;

namespace WpfBookCodeSample.CodeSample.StyleSample.Trigger
{
    /// <summary>
    /// Interaction logic for MultiDataTriggerSample.xaml
    /// </summary>
    public partial class MultiDataTriggerSample : Window
    {
        public MultiDataTriggerSample()
        {
            InitializeComponent();
            InitialInfo();
        }

        private void InitialInfo()
        {
            List<Person> infos = new List<Person>() {
                new Person(){ Id=2, Name="Darren", Skill="WPF"},
                new Person(){ Id=1, Name="Tom", Skill="Java"},
                new Person(){ Id=3, Name="Jacky", Skill="Asp.net"},
                new Person(){ Id=2, Name="Andy", Skill="C#"},
            };
            listBoxPerson.ItemsSource = infos;
        }
    }
}
