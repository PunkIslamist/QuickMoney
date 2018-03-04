namespace QuickMoney.ViewModels
{
    internal class ExpenseVM : ViewModel
    {
        private string _category = "Default category";
        public string Category
        {
            get => _category;
            set { this.SetField(ref _category, value); }
        }

        private double _amount = 0.0;
        public double Amount
        {
            get => _amount;
            set { this.SetField(ref _amount, value); }
        }

        private string _date = "Default date";
        public string Date
        {
            get => _date;
            set { this.SetField(ref _date, value); }
        }
    }
}
