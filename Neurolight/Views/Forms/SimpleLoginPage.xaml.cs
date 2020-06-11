using Neurolight.Views.Catalog;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Neurolight.Views.Forms
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLoginPage" /> class.
        /// </summary>
        public SimpleLoginPage()
        {
            InitializeComponent();
        }

        private void SfButton_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new CategoryTilePage());
        }
    }
}