using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01_CL_RegleDeControle
{
    public static class BoiteAOutilDeRegles
    {
        public static bool IsStartingSpace(string _input)
        {
            return Regex.IsMatch(_input, @"^\s");
        }

        public static bool IsEndingSpace(string _input)
        {
            return Regex.IsMatch(_input, @"\s$");
        }

        public static bool IsEmpty(string _input)
        {
            return String.IsNullOrEmpty(_input);
        }

        public static bool IsMoreThan30(string _input)
        {
            return _input.Length > 31;
        }

        public static bool IsNameLessThan2(string _input)
        {
            return _input.Length < 2;
        }

        public static bool IsNameNotAlphabetic(string _name)
        {
            return !Regex.IsMatch(_name, @"^\p{L}+(?:[-' ]\p{L}+)*$");

        }

        public static bool IsDateFormatValid(string _date, out DateTime date)
        {
            if (!DateTime.TryParseExact(_date, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out date))
            {
                date = DateTime.MinValue;
                return false;
            }
            return true;
        }

        public static (bool, DateTime) IsDateFormatValid(string _date)
        {
            bool ok = BoiteAOutilDeRegles.IsDateFormatValid(_date, out DateTime date);
            return (ok, date);
        }

        public static bool IsDateInPast(DateTime date)
        {
            return date < DateTime.Today;
        }

        public static bool IsMoreThan20(string _input)
        {
            return _input.Length > 20;
        }

        public static bool IsAmountNegative(string _amount)
        {
            return _amount.Contains('-');
        }

        public static bool IsAmountValid(string _amount, out decimal amount)
        {
            //_amount = _amount.Replace('.', ',');
            //if (!Regex.IsMatch(_amount, @"^\d+((\,|\.)\d+)?$"))
            //{
            //    amount = 0;
            //    return false;
            //}
            //return Decimal.TryParse(_amount, CultureInfo.GetCultureInfo("en-US"),out amount);

            return Decimal.TryParse(_amount, CultureInfo.CurrentCulture, out amount);
        }

        public static bool IsCodePostalValid(string _codePostal)
        {
            if (!Regex.IsMatch(_codePostal, @"^\d{5}$"))
            {
                return false;
            }
            return true;
        }


    }
}

    //public static class BoiteAOutilDeRegles
    //{
    //    // Optionnel mais recommandé : compiler les Regex utilisées souvent pour de meilleures performances
    //    private static readonly Regex RegexNomAlpha = new Regex(@"^\p{L}+(?:[-' ]\p{L}+)*$", RegexOptions.Compiled);
    //    private static readonly Regex RegexCodePostal = new Regex(@"^\d{5}$", RegexOptions.Compiled);

    //    public static bool IsStartingSpace(string input)
    //    {
    //        return input != null && Regex.IsMatch(input, @"^\s");
    //    }

    //    public static bool IsEndingSpace(string input)
    //    {
    //        return input != null && Regex.IsMatch(input, @"\s$");
    //    }

    //    public static bool IsEmpty(string input)
    //    {
    //        // Mieux que IsNullOrEmpty pour bloquer les saisies du type "   " (que des espaces)
    //        return string.IsNullOrWhiteSpace(input);
    //    }

    //    public static bool IsMoreThan30(string input)
    //    {
    //        // Sécurisé contre les valeurs nulles avec "?.", et corrigé (> 30 au lieu de > 31)
    //        return input?.Length > 30;
    //    }

    //    public static bool IsNameLessThan2(string input)
    //    {
    //        return input == null || input.Length < 2;
    //    }

    //    public static bool IsNameNotAlphabetic(string name)
    //    {
    //        if (string.IsNullOrWhiteSpace(name)) return true;
    //        return !RegexNomAlpha.IsMatch(name);
    //    }

    //    public static bool IsDateFormatValid(string dateText, out DateTime date)
    //    {
    //        // TryParseExact s'occupe de mettre 'date' à MinValue si ça échoue.
    //        return DateTime.TryParseExact(dateText, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out date);
    //    }

    //    public static (bool isValid, DateTime date) IsDateFormatValid(string dateText)
    //    {
    //        bool isValid = IsDateFormatValid(dateText, out DateTime date);
    //        return (isValid, date);
    //    }

    //    public static bool IsDateInPast(DateTime date)
    //    {
    //        // .Date assure qu'on ne compare pas les heures, juste les jours
    //        return date.Date < DateTime.Today;
    //    }

    //    public static bool IsMoreThan20(string input)
    //    {
    //        return input?.Length > 20;
    //    }

    //    public static bool IsAmountNegative(string amountText)
    //    {
    //        // Plus sûr que .Contains('-') car un utilisateur pourrait taper "12-3" par erreur
    //        return amountText != null && amountText.StartsWith("-");
    //    }

    //    public static bool IsAmountValid(string amountText, out decimal amount)
    //    {
    //        return decimal.TryParse(amountText, NumberStyles.Number, CultureInfo.CurrentCulture, out amount);
    //    }

    //    public static bool IsCodePostalValid(string codePostal)
    //    {
    //        if (string.IsNullOrWhiteSpace(codePostal)) return false;
    //        return RegexCodePostal.IsMatch(codePostal);
    //    }
    //}
