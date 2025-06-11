namespace destinygoalplanner
{
    public partial class mainScreenForm : Form
    {
        public mainScreenForm()
        {
            InitializeComponent();
        }

        private async void accountLoginbtn_Click(object sender, EventArgs e)
        {
            var bungieOAuth = new BungieOAuth();
            string accessToken = await bungieOAuth.StartLoginAsync();

            if (!string.IsNullOrEmpty(accessToken))
            {
                Storage.accessToken = accessToken;
                // Storage.userToken = userToken;

                // Proceed to load the next form or use the token


                MessageBox.Show("Login successful!", "Success");
            }
            else
            {
                MessageBox.Show("Login failed or was canceled.", "Error");
            }
        }
        private void saveToken()
        {

        }

        private void loadNextForm()
        {

        }
    }
}
