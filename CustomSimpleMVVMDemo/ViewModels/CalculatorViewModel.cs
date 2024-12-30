using CustomSimpleMVVMDemo.Commands;
using Microsoft.Win32;

namespace CustomSimpleMVVMDemo.ViewModels
{
    public class CalculatorViewModel: NotificationObject
    {
		private double input1;

		public double Input1
		{
			get => input1;
            set
            {
                input1 = value;
                RaisePropertyChanged("Input1");
            }
        }

        private double input2;

        public double Input2
        {
            get => input2;
            set
            {
                input2 = value;
                RaisePropertyChanged("Input2");
            }
        }

        private double result;

        public double Result
        {
            get => result;
            set
            {
                result = value;
                RaisePropertyChanged("Result");
            }
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
