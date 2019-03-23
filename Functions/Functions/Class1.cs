using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Class1
    {
        public string[] userN = new string[5];
        public string[] password = new string[5];

        public string Encrypt(string pass, string user)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(pass);
            string encrpyted = Convert.ToBase64String(b);
            for (int i = 0; i < 5; i++)
            {
                if (password[i] == null && userN[i] == null)
                {
                    userN[i] = user;
                    password[i] = encrpyted;
                    break;
                }
            }
            return pass;
        }

        public string Decrypt(string pass)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(pass);
            string encrpyted = Convert.ToBase64String(b);
            return encrpyted;
        }
        static int counter = 0;
        public int Counter()
        {
            counter++;
            return counter;
        }
    }
}
