using System;
namespace tset
{
    public class FactoryDesignPattren
    {
        public FactoryDesignPattren()
        {
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            
        
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}


#region "interface region"


public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }
    }


    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
#endregion

#region "making Abstract concrete"
public abstract class CreditCardFactory
    {
        protected abstract ICreditCard _ICreditCard();

        public ICreditCard CreateProduct()
        {
            return this._ICreditCard();
        }
    }

public abstract class CreditCardFactory2
{
    protected abstract ICreditCard _ICreditCard();

    public ICreditCard CreateProduct()
    {
        return this._ICreditCard();
    }
}
public class MoneyBackFactory : CreditCardFactory // inheriting abstract CreditCardFactory
{
        protected override ICreditCard _ICreditCard() // making instace of platinum, moneyback, titanium
        {
            ICreditCard MoneyBackObj = new MoneyBack();
            return MoneyBackObj;
        }
    }

    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard _ICreditCard()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }

    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard _ICreditCard()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
#endregion