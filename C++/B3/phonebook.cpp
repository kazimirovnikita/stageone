#include "phonebook.hpp"

#include <iostream>
#include <iterator>

void PhoneBook::pushBack(const contact_t& contact)
{
  contacts_.push_back(contact);
}

void PhoneBook::insertAfter(iterator it, const contact_t& contact)
{
  contacts_.insert(std::next(it), contact);
}

void PhoneBook::insertBefore(iterator it, const contact_t& contact)
{
  contacts_.insert(it, contact);
}

bool PhoneBook::isEmpty() const
{
  return contacts_.empty();
}

PhoneBook::const_iterator PhoneBook::begin() const
{
  return contacts_.begin();
}

PhoneBook::const_iterator PhoneBook::end() const
{
  return contacts_.end();
}

PhoneBook::iterator PhoneBook::begin()
{
  return contacts_.begin();
}

PhoneBook::iterator PhoneBook::end()
{
  return contacts_.end();
}

PhoneBook::iterator PhoneBook::removeContact(iterator it)
{
  return contacts_.erase(it);
}
