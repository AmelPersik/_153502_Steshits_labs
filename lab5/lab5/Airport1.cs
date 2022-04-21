using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Airport1
    {
        private static List<Tarif> poss = new List<Tarif>(0);
        private static List<customer> customers = new List<customer>(0);
        private int currentCus = 0;
        public void AddTicket(string dest, int pr)
        {
            Tarif a = new Tarif(dest, pr);
            poss.Add(a);
        }
        public static List<Tarif> GetTicketList()
        {
            return poss;
        }

        public static List<customer> GetCustomers()
        {
            return customers;
        }

        public int GetWholeCost()
        {
            int sum = 0;
            for (int i = 0; i < customers.Count(); i++)
            {
                sum += customers[i].Sum();
            }
            return sum;
        }

        public void AddCustomer(string n, string p, CType t)
        {
            customer cus = new customer(n, p, t);
            customers.Add(cus);
        }

        public void LogIn(int val)
        {
            currentCus = val - 1;
        }
        public void LogOut()
        {
            currentCus = 0;
        }

        public string SearchName(string name)
        {
            string str = ""; int ind = 0;
            for (int i = 0; i < customers.Count; i++)
            {
                if (name == customers[i].name)
                {
                    ind = i; break;
                }
            }
            str += "\nSum: " + customers[ind].Sum().ToString()
                + "\nName: " + customers[ind].name + "[" + customers[ind].GetTyype() + "]" + "\nPassport: " + customers[ind].passp
                + "\nTickets: " + customers[ind].ListT();
            return str;
        }

        public string Customerrrs()
        {
            string str = "";

            for (int i = 0; i < customers.Count; i++)
            {
                str += "\n" + (i + 1).ToString() + ":\t" + customers[i].name;
            }


            return str;
        }
        public string Tickeeets()
        {
            string str = "";

            for (int i = 0; i < poss.Count; i++)
            {
                str += "\n" + (i + 1).ToString() + ":\t" + poss[i].Destination();
            }


            return str;
        }

        public void SellTicket(int val)
        {
            customers[currentCus].BuyTicket(poss[val - 1].Destination());
        }

    }
}

