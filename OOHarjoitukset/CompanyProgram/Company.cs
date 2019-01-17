using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CompanyProgram
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public decimal income;
        public decimal expense;

        public Company()
        {
        }

        public Company(string t, string a, string p, decimal i, decimal o)
        {
            title = t;
            address = a;
            phone = p;
            income = i;
            expense = o;
        }

        public Company (Company previousCompany)
        {
            title = previousCompany.title;
            address = previousCompany.address;
            phone = previousCompany.phone;
            income = previousCompany.income;
            expense = previousCompany.expense;
        }

        public string Profit()
        {
            string s = string.Empty;
            decimal profit = (income - expense) / expense;

            if (profit < 1)
                s = "tämä ei ole hyväksyttävää";
            else if (profit < 2)
                s = "on kyl huono tulos";
            else if (profit < 3)
                s = "ihan ok tulos";
            else
                s = "on kyl hyvä tulos";

            return $"Voittoprosentti {profit.ToString("P")}: {s}";
        }

        public override string ToString()
        {
            return "Firma:\t" + title + "\nOsoite:\t" + address
                + "\npuh.\t" + phone + "\nTulot:\t" + income.ToString("c", CultureInfo.CurrentCulture) +
                "\nMenot:\t" + expense.ToString("c", CultureInfo.CurrentCulture);
        }
    }
}
