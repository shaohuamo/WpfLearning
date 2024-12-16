using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfBookCodeSample.ControlSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingADONETSource.xaml
    /// </summary>
    public partial class BindingADONETSource : Window
    {
        public BindingADONETSource()
        {
            InitializeComponent();

            DataTable dtInfo = CreateDataTable();
            for (int i = 0; i < 10; i++)
            {
                DataRow dr = dtInfo.NewRow();
                dr[0] = i;
                dr[1] = "猴王" + i;
                dr[2] = i + 10;
                dr[3] = "男";
                dtInfo.Rows.Add(dr);
            }

            //set Binding
            //listView1.DataContext = dtInfo;
            //listView1.SetBinding(ItemsControl.ItemsSourceProperty, new Binding());

            //上述2句代码与↓功能相同
            listView1.ItemsSource = dtInfo.DefaultView;
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable("newtable");

            DataColumn[] columns = new DataColumn[]
            {
                new DataColumn("Id"), 
                new DataColumn("Name"), 
                new DataColumn("Age"), 
                new DataColumn("Sex")
            };
            dt.Columns.AddRange(columns);
            return dt;
        }
    }
}
