using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace MobilePhoneShopApp
{
    // Serializable says this class can be written to disk
    [Serializable]

    //BIGINING OF MOBILE PHONES CLASSES
    public abstract class MobilePhone : IComparable

    {// mobile phone is an abstract base class, we can inherit android , apple and windows phones from this
        public enum Condition
        {
            poor,
            fair,
            good,
            mint,
        }

        public enum OpSystem
        {
            android,
            appleiOS,
            windowsOS,
            blackberryOS,
        }


        protected string make;
        
        protected string model;
        
        protected DateTime releasedDate;
        
        protected decimal originalValue;
        
        protected Condition condition;

        protected OpSystem operatingSystem;


        // declare second hand phone current value based on  how old
        
       // int count;

        int IComparable.CompareTo(object obj)
        {
            MobilePhone selectedPhone = (MobilePhone)obj;
            decimal differentInPrice = this.CalculateApproxValue() -
                selectedPhone.CalculateApproxValue();
            return Math.Sign(differentInPrice);
        }

        //constructor AndroidPhone with its parameters
        public MobilePhone(string make, string model, DateTime releasedDate, decimal originalValue, Condition condition, OpSystem operatingSystem)
        {
            this.make = make;
            this.model = model;
            this.releasedDate = releasedDate;
          
            this.originalValue = originalValue;
            this.condition = condition;
            this.operatingSystem = operatingSystem;

        }

       
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }


        public DateTime ReleasedDate
        {
            get
            {
                return releasedDate;
            }    
            
            set
            {
                releasedDate = value;
            }
        }


        public decimal OriginalValue
        {
            get
            {
                return originalValue;
            }
            set
            {
                originalValue = value;
            }
        }


        public OpSystem OperatingSystem
        {
            get
            {
                return operatingSystem;
            }
            set
            {
                operatingSystem = value;
            }
        }




        public int CalculateApproxAgeInYears()
        {

            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(releasedDate);
            int ageInYears = ageAsTimeSpan.Days / 365;
            return ageInYears;
        }
        
        public abstract decimal CalculateApproxValue();

       
        public virtual string Description()
        {
            //get a string describing the current mobile phone condition
            //whether it is fair, poor, good, or mint
            string conditionName = Enum.GetName(typeof(Condition), condition);

                string description = string.Format(" {4}{5}",
                make,
                Environment.NewLine,
                model,
                Environment.NewLine,
                conditionName,
                Environment.NewLine,


                CalculateApproxValue());
            return description;
       }

    }


}
 //END MOBILE PHONES CLASSES

  

