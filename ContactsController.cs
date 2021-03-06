using System;
using System.Collections.Generic;
using A2CONSOLE.Classes;

namespace A2CONSOLE.Controllers
{
  public class ContactsController
  {
    private readonly List<Contact> Book;

    public ContactsController()
    {
      this.Book = new List<Contact>();
    }

    public bool Add(Contact contact)
    {
      this.Book.Add(contact);

      return this.Book.IndexOf(contact) != -1;
    }

    public List<Contact> List() => this.Book;

    public Contact Find(Contact contact) =>
      this.Book.Find(cont => Equals(cont, contact));

    public bool Update(Contact contact)
    {
      int indexOfContact = -1;

      indexOfContact = this.Book.IndexOf(contact);

      if (indexOfContact == -1) return false;

      this.Book.Insert(indexOfContact, contact);

      return true;
    }

    public bool Delete(Contact contact)
    {
      int indexOfContact = -1;

      indexOfContact = this.Book.IndexOf(contact);

      if (indexOfContact == -1) return false;

      this.Book.RemoveAt(indexOfContact);

      return true;
    }
  }
}