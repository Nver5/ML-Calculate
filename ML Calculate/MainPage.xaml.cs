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
                InitializeComponent();  // Initialize the UI components defined in the XAML file
                BindingContext = vm;   // Set the data context to the provided ViewModel
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
            
                count++; //Increment the count
                if (count == 1)
                    CounterBtn.Text = $"Add {count}"; // Update the button text for count = 1
                else
                    CounterBtn.Text = $"Add {count}"; // Update the button text for count > 1
                SemanticScreenReader.Announce(CounterBtn.Text); // Announce the updated button text for accessibility
            
        }
        private void OnDeleteItemCounterClicked(object sender, EventArgs e)
            {
                delete++; // Increment the delete count
                count -= delete; // Subtract the delete counter from the main count
                CounterBtn.Text = $"Add {count}"; // Update button text with the new count
                SemanticScreenReader.Announce(CounterBtn.Text); // Announce the updated  text for accessibility
                delete = 0; // Reset the delete counter

            }

        }
}
