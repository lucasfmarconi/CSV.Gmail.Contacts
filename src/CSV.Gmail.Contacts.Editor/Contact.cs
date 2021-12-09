using CsvHelper.Configuration;

namespace CSV.Gmail.Contacts.Editor
{
    public class Contact
    {
        public string Name { get; set; }
        public string GivenName { get; set; }
        public string AdditionalName { get; set; }
        public string FamilyName { get; set; }
        public string YomiName { get; set; }
        public string GivenNameYomi { get; set; }
        public string AdditionalNameYomi { get; set; }
        public string FamilyNameYomi { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public string Initials { get; set; }
        public string Nickname { get; set; }
        public string ShortName { get; set; }
        public string MaidenName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string BillingInformation { get; set; }
        public string DirectoryServer { get; set; }
        public string Mileage { get; set; }
        public string Occupation { get; set; }
        public string Hobby { get; set; }
        public string Sensitivity { get; set; }
        public string Priority { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public string Language { get; set; }
        public string Photo { get; set; }
        public string GroupMembership { get; set; }
        public string E_mail1_Type { get; set; }
        public string E_mail1_Value { get; set; }
        public string E_mail2_Type { get; set; }
        public string E_mail2_Value { get; set; }
        public string E_mail3_Type { get; set; }
        public string E_mail3_Value { get; set; }
        public string IM1_Type { get; set; }
        public string IM1_Service { get; set; }
        public string IM1_Value { get; set; }
        public string Phone1_Type { get; set; }
        public string Phone1_Value { get; set; }
        public string Phone2_Type { get; set; }
        public string Phone2_Value { get; set; }
        public string Phone3_Type { get; set; }
        public string Phone3_Value { get; set; }
        public string Phone4_Type { get; set; }
        public string Phone4_Value { get; set; }
        public string Address1_Type { get; set; }
        public string Address1_Formatted { get; set; }
        public string Address1_Street { get; set; }
        public string Address1_City { get; set; }
        public string Address1_POBox { get; set; }
        public string Address1_Region { get; set; }
        public string Address1_PostalCode { get; set; }
        public string Address1_Country { get; set; }
        public string Address1_ExtendedAddress { get; set; }
        public string Organization1_Type { get; set; }
        public string Organization1_Name { get; set; }
        public string Organization1_YomiName { get; set; }
        public string Organization1_Title { get; set; }
        public string Organization1_Department { get; set; }
        public string Organization1_Symbol { get; set; }
        public string Organization1_Location { get; set; }
        public string Organization1_JobDescription { get; set; }
        public string Website1_Type { get; set; }
        public string Website1_Value { get; set; }
        public string Website2_Type { get; set; }
        public string Website2_Value { get; set; }
    }

    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.GivenName).Name("Given Name");
            Map(m => m.AdditionalName).Name("Additional Name");
            Map(m => m.FamilyName).Name("Family Name");
            Map(m => m.YomiName).Name("Yomi Name");
            Map(m => m.GivenNameYomi).Name("Given Name Yomi");
            Map(m => m.AdditionalNameYomi).Name("Additional Name Yomi");
            Map(m => m.FamilyNameYomi).Name("Family Name Yomi");
            Map(m => m.NamePrefix).Name("Name Prefix");
            Map(m => m.NameSuffix).Name("Name Suffix");
            Map(m => m.Initials).Name("Initials");
            Map(m => m.Nickname).Name("Nickname");
            Map(m => m.ShortName).Name("Short Name");
            Map(m => m.MaidenName).Name("Maiden Name");
            Map(m => m.Birthday).Name("Birthday");
            Map(m => m.Gender).Name("Gender");
            Map(m => m.Location).Name("Location");
            Map(m => m.BillingInformation).Name("Billing Information");
            Map(m => m.DirectoryServer).Name("Directory Server");
            Map(m => m.Mileage).Name("Mileage");
            Map(m => m.Occupation).Name("Occupation");
            Map(m => m.Hobby).Name("Hobby");
            Map(m => m.Sensitivity).Name("Sensitivity");
            Map(m => m.Priority).Name("Priority");
            Map(m => m.Subject).Name("Subject");
            Map(m => m.Notes).Name("Notes");
            Map(m => m.Language).Name("Language");
            Map(m => m.Photo).Name("Photo");
            Map(m => m.GroupMembership).Name("Group Membership");
            Map(m => m.E_mail1_Type).Name("E-mail 1 - Type");
            Map(m => m.E_mail1_Value).Name("E-mail 1 - Value");
            Map(m => m.E_mail2_Type).Name("E-mail 2 - Type");
            Map(m => m.E_mail2_Value).Name("E-mail 2 - Value");
            Map(m => m.E_mail3_Type).Name("E-mail 3 - Type");
            Map(m => m.E_mail3_Value).Name("E-mail 3 - Value");
            Map(m => m.IM1_Type).Name("IM 1 - Type");
            Map(m => m.IM1_Service).Name("IM 1 - Service");
            Map(m => m.IM1_Value).Name("IM 1 - Value");
            Map(m => m.Phone1_Type).Name("Phone 1 - Type");
            Map(m => m.Phone1_Value).Name("Phone 1 - Value");
            Map(m => m.Phone2_Type).Name("Phone 2 - Type");
            Map(m => m.Phone2_Value).Name("Phone 2 - Value");
            Map(m => m.Phone3_Type).Name("Phone 3 - Type");
            Map(m => m.Phone3_Value).Name("Phone 3 - Value");
            Map(m => m.Phone4_Type).Name("Phone 4 - Type");
            Map(m => m.Phone4_Value).Name("Phone 4 - Value");
            Map(m => m.Address1_Type).Name("Address 1 - Type");
            Map(m => m.Address1_Formatted).Name("Address 1 - Formatted");
            Map(m => m.Address1_Street).Name("Address 1 - Street");
            Map(m => m.Address1_City).Name("Address 1 - City");
            Map(m => m.Address1_POBox).Name("Address 1 - PO Box");
            Map(m => m.Address1_Region).Name("Address 1 - Region");
            Map(m => m.Address1_PostalCode).Name("Address 1 - Postal Code");
            Map(m => m.Address1_Country).Name("Address 1 - Country");
            Map(m => m.Address1_ExtendedAddress).Name("Address 1 - Extended Address");
            Map(m => m.Organization1_Type).Name("Organization 1 - Type");
            Map(m => m.Organization1_Name).Name("Organization 1 - Name");
            Map(m => m.Organization1_YomiName).Name("Organization 1 - Yomi Name");
            Map(m => m.Organization1_Title).Name("Organization 1 - Title");
            Map(m => m.Organization1_Department).Name("Organization 1 - Department");
            Map(m => m.Organization1_Symbol).Name("Organization 1 - Symbol");
            Map(m => m.Organization1_Location).Name("Organization 1 - Location");
            Map(m => m.Organization1_JobDescription).Name("Organization 1 - Job Description");
            Map(m => m.Website1_Type).Name("Website 1 - Type");
            Map(m => m.Website1_Value).Name("Website 1 - Value");
            Map(m => m.Website2_Type).Name("Website 2 - Type");
            Map(m => m.Website2_Value).Name("Website 2 - Value");
        }
    }

}