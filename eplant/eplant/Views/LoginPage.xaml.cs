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

            Title = Strings.appName;

            appName_lbl.Text = Strings.appName;
            email_lbl.Text = Login.Email;
            password_lbl.Text = Login.password;
            rememberMe_lbl.Text = Login.rememberMe;
            logIn_btn.Text = Login.loginTitle;
            signIn_btn.Text = Login.signIn;
        }

        
    }
}