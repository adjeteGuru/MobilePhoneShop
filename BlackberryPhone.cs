using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneShopApp
{
    [Serializable]

    class BlackberryPhone : MobilePhone
    {


        public BlackberryPhone(string make, string model, DateTime releasedDate, decimal originalValue, Condition condition, OpSystem operatingSystem)
              : base(make, model, releasedDate, originalValue, condition, operatingSystem)
        {

        }



        public override decimal CalculateApproxValue()
        {


            decimal value = 0;
            // we modify the phones value based on its condition
            if (condition == Condition.mint)
            {
                value = OriginalValue * 0.7m;        // 70% of original value
            }
            else if (condition == Condition.good)
            {
                value = OriginalValue * 0.6m;        // 60% of original value
            }
            else if (condition == Condition.fair)
            {
                value = OriginalValue * 0.5m;        // 50% of original value
            }
            else if (condition == Condition.poor)
            {
                value = OriginalValue * 0.4m;        // 40% of original value
            }



            // we also take into account the cars age
            int age = CalculateApproxAgeInYears();

            // the loop below could be re-written as
            // decimal alternativeValue = value * (decimal)Math.Pow(0.7, age);    // we loose 20% of value for each year old... i.e. we keep 70% (0.7)
            // we lose another 20% of the value every year - so we keep 70% or 0.7

            for (int i = 0; i < age; i++)
            {
                value = value * 0.7m;
            }
            // this loop could be re-written as
            // value = value * (decimal)Math.Pow(0.7, age);    // we loose 20% of value for each year old... i.e. we keep 70% (0.7)

            value = Decimal.Round(value, 0);    // round to the nearest pound.          

            // the phone lot rounds this down to the nearest £100 
            value = value - (value % 100);

            // and then adds £99
            value = value + 99;
            return value;
        }
    }
}

