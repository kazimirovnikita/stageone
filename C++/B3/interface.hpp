#ifndef INTERFACE_HPP
#define INTERFACE_HPP

#include <ostream>
#include <string>
#include <unordered_map>
#include "phonebook.hpp"

class PhoneBookInterface
{
public:
  enum class Position
  {
    FIRST,
    LAST
  };

  PhoneBookInterface();

  void add(const PhoneBook::contact_t& contact);
  void store(const std::string& markName, const std::string& newMarkName, std::ostream& out);
  void insertAfter(const std::string& markName, const PhoneBook::contact_t& contact, std::ostream& out);
  void insertBefore(const std::string& markName, const PhoneBook::contact_t& contact, std::ostream& out);
  void removeContact(const std::string& markName, std::ostream& out);
  void show(const std::string& markName, std::ostream& out) const;
  void move(const std::string& markName, long int steps, std::ostream& out);
  void move(const std::string& markName, Position& pos, std::ostream& out);
  void moveMarks();

private:
  PhoneBook book_;
  std::unordered_map<std::string, PhoneBook::iterator> bookmarks_;
};

#endif
