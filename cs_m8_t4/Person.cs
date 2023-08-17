using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cs_m8_t4 {
    internal class Person {

        private string fullName;
        private string street;
        private short building;
        private short apt;
        private long mobilePhone;
        private long homePhone;

        public bool SetPersonName(string str) {
            bool result;
            if (!string.IsNullOrWhiteSpace(str)) {
                this.fullName = str;
                result = true;
            } else {
                result = false;
            }
            return result;

        }

        public bool SetPersonStreet(string str) {
            bool result;
            if (!string.IsNullOrEmpty(str)) {
                this.street = str;
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public bool SetPersonBulding(string str) {
            bool result;
            if (short.TryParse(str, out short building)) {
                this.building = building;
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public bool SetPersonApt(string str) {
            bool result;
            if (short.TryParse(str, out short apt)) {
                this.apt = apt;
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public bool SetPersonMobile(string str) {
            bool result;
            if (long.TryParse(str, out long number)) {
                this.mobilePhone = number;
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public bool SetPersonHomeNumber(string str) {
            bool result;
            if (long.TryParse(str, out long number)) {
                this.homePhone = number;
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public void WriteToFile() {
            //Declare variables
            XElement xePerson = new XElement("Person");
            XElement xeAddress = new XElement("Address");
            XElement xeStreet = new XElement("Street");
            XElement xeBuilding = new XElement("Building");
            XElement xeApt = new XElement("Appartment");
            XElement xePhones = new XElement("Phones");
            XElement xeMobilePhone = new XElement("MobilePhone");
            XElement xeHomePhone = new XElement("HomePhone");

            //Fill address fields
            xeStreet.Add(new XText(this.street));
            xeBuilding.Add(new XText(this.building.ToString()));
            xeApt.Add(new XText(this.apt.ToString()));
            //Put address fields to Address block
            xeAddress.Add(xeStreet, xeBuilding, xeApt);

            //Fill phone fields
            xeMobilePhone.Add(new XText(this.mobilePhone.ToString()));
            xeHomePhone.Add(new XText(this.homePhone.ToString()));
            //Put phone fields to Phones block
            xePhones.Add(xeMobilePhone, xeHomePhone);

            //Put address and phone blocks into Person block
            xePerson.Add(xeAddress, xePhones);
            xePerson.Add(new XAttribute("name", this.fullName));

            //Safe file
            xePerson.Save("myXML.xml");

        }

    }
}
