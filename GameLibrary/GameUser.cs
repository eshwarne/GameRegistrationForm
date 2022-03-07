using System;
namespace GameLibrary {
    class GameUser
    {
        private static string[] userNames;
        public string UserName {
            get
            {
                return this.UserName;
            }
            set
            {
                if (isUserExists(value))
                {
                    throw new Exception("User already exists");
                }
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new Exception("Invalid email");
                }
                else
                {
                    _email = value;
                }
            }
        }
        public string Id {
            get
            {
                return UserName.GetHashCode().ToString();
            }
        }
        public static bool isUserExists(string givenUser)
        {
            foreach (var user in GameUser.userNames)
            {
                if (user.Equals(givenUser))
                {
                    return true;
                }
            }
            return false;
        }
    }

    
}