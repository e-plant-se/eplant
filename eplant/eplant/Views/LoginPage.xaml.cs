namespace eplant.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using eplant.Helpers;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
            this.Title = Strings.viewName;

            this.appName_lbl.Text = Strings.viewName;
            this.email.Text = Login.Email;
            this.password.Text = Login.password;
            this.rememberme.Text = Login.rememberMe;
            this.logIn.Text = Login.loginTitle;
            this.signIn.Text = Login.signIn;
        }

        
    }
}