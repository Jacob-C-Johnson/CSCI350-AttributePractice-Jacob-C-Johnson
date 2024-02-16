using System;

public class PersonalInformationAttribute : Attribute
{
    public int level { get; set; }
    public PersonalInformationAttribute(int l)
    {
        level = l;
    }
}

public class PublicInformationAttribute : Attribute
    {
        public int level { get; set; }
        public PublicInformationAttribute(int importance)
        {
            level = importance;
        }
    }

public class StorageTypeAttribute : Attribute
    {
        public string storageType { get; set; }
        public StorageTypeAttribute(string s)
        {
            this.storageType = s;
        }
    }