using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public static class Helper
    {
        public static string ConnectionString { get; } = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=LibrarySystemDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static bool ValidateName(string input)
        {
            string[] inputParts = input.Split(' ');

            foreach (string part in inputParts)
            {
                if (string.IsNullOrWhiteSpace(part))
                    continue;

                if (part.All(char.IsLetter) && part.Length <= 15)  
                    return true;
                else
                    return false;
            }
            return true;
        }

        public static bool ValidateAge(string age)
        {
            int num;

            if (int.TryParse(age, out num) && num > 0 && num <= 110)
                return true;
            else
                return false;
        }

        public static string CapitalizeFirstLetter(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        public static void ClearAll(TextBox txtBxFname, TextBox txtBxLname, TextBox txtBxAge, RadioButton rdbtnFemale, RadioButton rdbtnMale)
        {
            txtBxFname.Clear();
            txtBxLname.Clear();
            txtBxAge.Clear();
            rdbtnFemale.Checked = false;
            rdbtnMale.Checked = false;
        }
    }
}
