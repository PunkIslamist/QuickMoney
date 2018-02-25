namespace QuickMoney.ViewModels
{
    internal class ExpenseVM : ViewModel
    {
        private string _category;
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
    }
}
