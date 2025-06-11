using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destinygoalplanner
{
    internal class Storage
    {
        // store auth token
        // store information from token
        private static TokenResponse _userToken;
        private static string _accessToken;
        public static TokenResponse userToken
        {
            get
            {
                if (_userToken == null)
                    _userToken = new TokenResponse();
                return _userToken;
            }
            set 
            { 
                _userToken = value;
            }
        }

        public static string accessToken
        {
            get
            {
                return _accessToken ?? string.Empty;
            }
            set
            {
                _accessToken = value;
            }
        }
    }
}
