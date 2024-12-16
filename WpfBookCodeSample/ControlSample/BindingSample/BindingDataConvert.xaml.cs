﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfBookCodeSample.ControlSample.BindingSample
{
    /// <summary>
    /// Interaction logic for BindingDataConvert.xaml
    /// </summary>
    public partial class BindingDataConvert : Window
    {
        public BindingDataConvert()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> planeList = new List<Plane>() {
                new Plane(){ Category= Category.Bomber,Name="B-1", State= State.Indeterminate},
                new Plane(){ Category= Category.Bomber,Name="B-2", State= State.Indeterminate},
                new Plane(){ Category= Category.Fighter,Name="F-22", State= State.Locked},
                new Plane(){ Category= Category.Fighter,Name="Su-47", State= State.Indeterminate},
                new Plane(){ Category= Category.Bomber,Name="B-52", State= State.Available},
                new Plane(){ Category= Category.Fighter,Name="J-10", State= State.Indeterminate},
            };
            listBoxPlane.ItemsSource = planeList;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane item in listBoxPlane.Items)
            {
                sb.AppendLine($"Category={item.Category},State={item.State},Name={item.Name}");
            }
            File.WriteAllText(@"D:\PlaneList.text", sb.ToString());
            MessageBox.Show("Done");
        }
    }
}
