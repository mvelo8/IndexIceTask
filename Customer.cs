using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXicetask
{
    
    
        public class CustomerIndex
        {
        decimal balance;
        string email, phone, name;
        DateTime lastPurchase;

        public CustomerIndex(string name, string email, string phone, decimal balance, DateTime lastPurchase)
            {
                this.name = name;
                this.email = email;
                this.phone = phone;
                this.balance = balance;
                this.lastPurchase = lastPurchase;
            }

            public object this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0:
                            return this.name;
                        case 1:
                            return this.email;
                        case 2:
                            return this.phone;
                        case 3:
                            return this.balance;
                        case 4:
                            return this.lastPurchase;
                        default:
                            return null;
                    }
                }
                set
                {
                    switch (index)
                    {
                        case 0:
                            this.name = (string)value;
                            break;
                        case 1:
                            this.email = (string)value;
                            break;
                        case 2:
                            this.phone = (string)value;
                            break;
                        case 3:
                            this.balance = (decimal)value;
                            break;
                        case 4:
                            this.lastPurchase = (DateTime)value;
                            break;
                    }
                }
            }

            public object this[string attrName]
            {
                get
                {
                    switch (attrName.ToLower())
                    {
                        case "name":
                            return this.name;
                        case "email":
                            return this.email;
                        case "phone":
                            return this.phone;
                        case "balance":
                            return this.balance;
                        case "lastpurchase":
                            return this.lastPurchase;
                        default:
                            return null;
                    }
                }
                set
                {
                    switch (attrName.ToLower())
                    {
                        case "name":
                            this.name = (string)value;
                            break;
                        case "email":
                            this.email = (string)value;
                            break;
                        case "phone":
                            this.phone = (string)value;
                            break;
                        case "balance":
                            this.balance = (decimal)value;
                            break;
                        case "lastpurchase":
                            this.lastPurchase = (DateTime)value;
                            break;
                    }
                }
            }
        }
    }

