using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace destinygoalplanner
{
    public class BungieOAuth
    {
        private const string clientId = "49928";
        private const string redirectUri = "myapp://auth";

        public async Task<string> StartLoginAsync()
        {
            var loginForm = new FormOAuth(BuildLoginUrl());
            var code = loginForm.ShowDialog() == DialogResult.OK
                ? loginForm.AuthorizationCode
                : null;

            if (string.IsNullOrEmpty(code))
                return null;

            var tokenResponse = await ExchangeCodeForTokenAsync(code);
            return tokenResponse?.access_token;
        }


        private string BuildLoginUrl()
        {
            return $"https://www.bungie.net/en/OAuth/Authorize?client_id={clientId}&response_type=code&redirect_uri={Uri.EscapeDataString(redirectUri)}";
        }

        private async Task<TokenResponse> ExchangeCodeForTokenAsync(string code)
        {
            using var httpClient = new HttpClient();

            var parameters = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("code", code),
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("redirect_uri", redirectUri)
            });

            var response = await httpClient.PostAsync("https://www.bungie.net/platform/app/oauth/token/", parameters);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TokenResponse>(json);
        }

        public class TokenResponse
        {
            public string access_token { get; set; }
            public string refresh_token { get; set; }
            public int expires_in { get; set; }
            public int refresh_expires_in { get; set; }
            public string membership_id { get; set; }
        }
    }
}
