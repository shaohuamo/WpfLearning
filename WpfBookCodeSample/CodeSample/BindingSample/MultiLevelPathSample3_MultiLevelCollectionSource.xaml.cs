using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfBookCodeSample.CodeSample.BindingSample
{
    /// <summary>
    /// Interaction logic for MultiLevelPathSample3_MultiLevelCollectionSource.xaml
    /// </summary>
    public partial class MultiLevelPathSample3_MultiLevelCollectionSource : Window
    {
        public MultiLevelPathSample3_MultiLevelCollectionSource()
        {
            InitializeComponent();

            List<Country> infos =
                new List<Country>() {
                    new Country() {
                        Name = "中国",
                        Provinces=
                            new List<Province>()
                            { new Province() {
                                Name="四川",
                                Cities=new List<City>(){
                                    new  City(){
                                        Name="绵阳市"
                                    }}}}}};
            //infos集合中第一个元素的Name属性
            textBox1.SetBinding(TextBox.TextProperty,
                new Binding("/Name") { Source = infos });

            //infos集合中第一个元素的Provinces中的ii一个元素的Name属性，以此类推
            textBox2.SetBinding(TextBox.TextProperty,
                new Binding("/Provinces/Name") { Source = infos });

            textBox3.SetBinding(TextBox.TextProperty,
                new Binding("/Provinces/Cities/Name") { Source = infos });
        }
    }

    public class City
    {
        public string Name { set; get; }
    }

    public class Province
    {
        public string Name { set; get; }
        public List<City> Cities { set; get; }
    }

    public class Country
    {
        public string Name { set; get; }
        public List<Province> Provinces { get; set; }
    }
}
