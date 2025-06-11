using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;

namespace destinygoalplanner
{
    public partial class FormOAuth : Form
    {
        private WebView2 webView;

        public string AuthorizationCode { get; private set; }

        public FormOAuth(string loginUrl)
        {
            InitializeComponent();

            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            webView.NavigationStarting += WebView_NavigationStarting;
            this.Controls.Add(webView);

            this.Load += async (s, e) =>
            {
                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.Navigate(loginUrl);
            };
        }

        private void WebView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.Uri.StartsWith("myapp://auth"))
            {
                var uri = new Uri(e.Uri);
                var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
                AuthorizationCode = query.Get("code");

                e.Cancel = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
