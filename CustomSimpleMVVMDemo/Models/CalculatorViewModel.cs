using CustomSimpleMVVMDemo.Commands;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSimpleMVVMDemo.Models
{
    public class CalculatorViewModel: BaseViewModel
    {
		private double input1;

		public double Input1
		{
			get => input1;
            set => SetField(ref input1, value);
        }

        private double input2;

        public double Input2
        {
            get => input2;
            set => SetField(ref input2, value);
        }

        private double result;

        public double Result
        {
            get => result;
            set => SetField(ref result, value);
        }

        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }

        private void Add(object parameter)
        {
            Result = Input1 + Input2;
        }

        private void Save(object parameter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        public CalculatorViewModel()
        {
            AddCommand = new DelegateCommand();
            AddCommand.ExecuteAction = Add;

            SaveCommand = new DelegateCommand();
            SaveCommand.ExecuteAction = Save;
        }
    }
}
