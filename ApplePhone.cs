using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneShopApp
{

    [Serializable]

    public class ApplePhone : MobilePhone
    {

        public ApplePhone(string make, string model, DateTime datePurchased, decimal originalValue, Condition condition, OpSystem operatingSystem)
                : base(make, model, datePurchased, originalValue, condition, operatingSystem)
        {

        }

    public override decimal CalculateApproxValue()
    {

            decimal value = 0;
        // we modify the phones value based on its condition
        if (condition == Condition.mint)
        {
            value = OriginalValue * 0.9m;        // 90% of original value
        }
        else if (condition == Condition.good)
        {
            value = OriginalValue * 0.8m;        // 80% of original value
        }
        else if (condition == Condition.fair)
        {
            value = OriginalValue * 0.7m;        // 70% of original value
        }
        else if (condition == Condition.poor)
        {
            value = OriginalValue * 0.5m;        // 50% of original value
        }

        
            // we also take into account the cars age
            int age = CalculateApproxAgeInYears();

        // the loop below could be re-written as
        // decimal alternativeValue = value * (decimal)Math.Pow(0.9, age);    // we loose 20% of value for each year old... i.e. we keep 90% (0.9)
        // we lose another 20% of the value every year - so we keep 90% or 0.9

        for (int i = 0; i < age; i++)
        {
            value = value * 0.9m;
        }
        // this loop could be re-written as
        // value = value * (decimal)Math.Pow(0.9, age);    // we loose 20% of value for each year old... i.e. we keep 90% (0.9)

        value = Decimal.Round(value, 0);    // round to the nearest pound.          

        // the car lot rounds this down to the nearest £100 
        value = value - (value % 100);

        // and then adds £99
        value = value + 99;
        return value;
    }
}

}
