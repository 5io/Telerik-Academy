namespace Phonebook.Common.Contacts
{
    using System;
    using System.Collections.Generic;

    public interface IPhoneEntry : IComparable<IPhoneEntry>
    {
        string Name { get; set; }

        ISet<string> PhoneNumbers { get; set; }

        string ToString();
    }
}