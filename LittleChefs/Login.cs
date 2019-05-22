using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleChefs
{
    public class Login
    {
        public class Account : PermissionController
        {
            private string username;
            private string password;
            private int wrongAttempts;

            public Account(string username, string password)
            {
                this.username = username;
                this.password = password;
                wrongAttempts = 0;
                addPermission(1);
            }

            public string getUsername()
            {
                return username;
            }

            public string getPassword()
            {
                return password;
            }

            public void increaseWrongAttempts()
            {
                ++wrongAttempts;
            }

            public int getWrongAttempts()
            {
                return wrongAttempts;
            }
        }

        public class Validation
        {
            private List<Login.Account> accounts;
            private Login.Account loggedIn;

            public Validation(List<Login.Account> accounts)
            {
                this.accounts = accounts;
            }

            public int attempt(string user, string pass)
            {
                int y = 0;

                if (user.Length == 0 && pass.Length == 0)
                {
                    y = 4;
                }
                else
                {
                    foreach (Account acc in accounts)
                    {
                        var account = acc;
                        if (acc.getUsername().Equals(user))
                        {
                            if (acc.getWrongAttempts() >= 5)
                            {
                                y = 2;
                                break;
                            }
                            else
                            {
                                if (acc.getPassword().Equals(pass))
                                {
                                    y = 1;
                                    loggedIn = acc;
                                    break;
                                }
                                else
                                {
                                    y = 3;
                                    acc.increaseWrongAttempts();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            y = 0;
                        }
                    }
                }
                return y;
            }

            public Login.Account getLoggedAccount()
            {
                return loggedIn;
            }
        }
    }
}
