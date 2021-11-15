#ifndef PHONEBOOK_HPP
#define PHONEBOOK_HPP

#include <iostream>
#include <list>
#include <string>

class PhoneBook
{
public:
  struct contact_t
  {
    std::string name;
    std::string number;
  };

  using iterator = std::list<contact_t>::iterator;
  using const_iterator = std::list<contact_t>::const_iterator;

  void pushBack(const contact_t& contact);
  void insertAfter(iterator it, const contact_t& contact);
  void insertBefore(iterator it, const contact_t& contact);
  bool isEmpty() const;
  iterator removeContact(iterator it);
  iterator begin();
  iterator end();
  const_iterator begin() const;
  const_iterator end() const;

private:
  std::list<contact_t> contacts_;
};

#endif
