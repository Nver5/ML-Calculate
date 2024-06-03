using ML_Calculate.ViewModel;
namespace ML_Calculate
{
        public partial class MainPage : ContentPage
        {
            int count = 0;
            int reset = 0;
            int delete = 0;
            public MainPage(MainViewModel vm)
            {
                InitializeComponent();
                BindingContext = vm;
            }
            private void OnResetCounterClicked(object sender, EventArgs e)
            {
                reset++;
                if (reset == 1)
                {
                    CounterBtn.Text = $"Add";
                    reset--;
                    count = 0;
                }
                SemanticScreenReader.Announce(CounterBtn.Text);
            }
            private void OnCounterClicked(object sender, EventArgs e)
        {
            
                count++;
                if (count == 1)
                    CounterBtn.Text = $"Add {count}";
                else
                    CounterBtn.Text = $"Add {count}";
                SemanticScreenReader.Announce(CounterBtn.Text);
            
        }
        private void OnDeleteItemCounterClicked(object sender, EventArgs e)
            {
                delete++;
                count -= delete;
                CounterBtn.Text = $"Add {count}";
                SemanticScreenReader.Announce(CounterBtn.Text);
                delete = 0;

            }

        }
}
