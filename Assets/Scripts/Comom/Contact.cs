using System.Collections.Generic;
using System;

public struct Contacts
{
    public List<Contact> contactList;

    public Contacts(List<Contact> contacts)
    {
        this.contactList = contacts;
    }
}

public struct Contact : IComparable<Contact>
{
    public int CompareTo(Contact other)
    {
        throw new NotImplementedException();
    }
}
