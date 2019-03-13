using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace MobilePhoneShopApp
{
    [Serializable]
    public class Shop 
    {
        // this Shop Class contains a list of mobile phone (android  and apple)
        // using polymorphism we inherit from the abstract base class phone
        // and provide a method that differs for the two type to calculate
        // their approximate value based on their age and condition


        public List<MobilePhone> listMobilePhoneStock;

        private int mobilePhoneCurrentlyDisplayed = 0;

       //add new comment added
        public Shop()
        {
            listMobilePhoneStock = new List<MobilePhone>();
            
        }

        //get setter method to fetch info
        public string GetMobilePhoneMake()
        {
            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].Make;
        }

        public string GetMobilePhoneModel()
        {
            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].Model;
        }


        public DateTime GetReleasedDate()
        {
            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].ReleasedDate;
        }

        
        public decimal GetOriginalValue()
        {
            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].OriginalValue;
        }

        public int MobilePhoneCurrentlyDisplayed
        {
            get
            { return mobilePhoneCurrentlyDisplayed; }
        }

        public int NumberOfMobilePhone
        {
            get { return listMobilePhoneStock.Count; }
        }

        public string GetPhoneAgeInYears()
        {
            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].CalculateApproxAgeInYears().ToString();
        }

        public decimal GetCalculateApproxValue()
        {
            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].CalculateApproxValue();
        }

        public string GetOpSystem()
        {

            return listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].OperatingSystem.ToString();

        }

        public string DescribeCurrentMobilePhone()
        {
            string description;

            // for any mobilePhone then displayed its description
            if (listMobilePhoneStock.Count > 0)
            {
                description = listMobilePhoneStock[mobilePhoneCurrentlyDisplayed].Description();
            }
            else
            {
                description = "No phone in stock";
            }
            return description;
        }

        // we are not using these currently...
        public void AddMobilePhone(MobilePhone mobilePhone)
        {
            listMobilePhoneStock.Add(mobilePhone);

        }
        
        // we ensure that mobilePhoneCurrentDisplayed indexes a mobilePhone that exists
        // (if there are any)
        private void MobilePhoneCurentlyDisplayed()
        {
            if (mobilePhoneCurrentlyDisplayed > (listMobilePhoneStock.Count - 1))
            {
                mobilePhoneCurrentlyDisplayed = listMobilePhoneStock.Count - 1;   // not this will be -1 if stock is zero

                if (mobilePhoneCurrentlyDisplayed < 0)
                {
                    mobilePhoneCurrentlyDisplayed = 0;  // make sure its legal or zero....
                }
            }
        }
        

        public bool IsPreviousMobilePhone()
        {
            if (mobilePhoneCurrentlyDisplayed > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }

        public bool IsNextMobilePhone()
        {
            if (mobilePhoneCurrentlyDisplayed < listMobilePhoneStock.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StepToPreviousMobilePhone()
        {
            if (IsPreviousMobilePhone())
            {
                mobilePhoneCurrentlyDisplayed--;
            }
        }

        public void StepToNextMobilePhone()
        {
            if (IsNextMobilePhone())
            {
                mobilePhoneCurrentlyDisplayed++;
            }
        }

        public string ListMobiles(int index)
        {
            string mobileName = "";
            
            mobileName = listMobilePhoneStock[index].Make + " " + listMobilePhoneStock[index].Model;

            return mobileName;
        }


        public int ListCount()
        {
            return listMobilePhoneStock.Count;
        }

        public void SetCurrent(int current)
        {
           // int mobilePhoneCurrentlyDisplayed = current;
            int selected = current;
        }

        
    }
      
}

