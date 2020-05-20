using System.ComponentModel;
using Xamarin.Forms;

namespace Lab8VAG
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ExplicitDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            ExplicitCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitCode());
            };
            ExplicitControlDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };
            ExplicitControlCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplictControlCode());
            };
            ImplicitDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };
            ImplicitCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitCode());
            };
            ImplicitControlDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            GlobalDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };
            GlobalCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalCode());
            };
            InheritanceDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceDemo());
            };
            InheritanceCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InheritanceCode());
            };
            DynamicDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
            DynamicCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicCode());
            };
            ClassDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ClassDemo());
            };
 
        }
    }
}
