#include "commands.hpp"

#include <iostream>
#include <string>
#include "interface.hpp"
#include "phonebook.hpp"

void add(PhoneBookInterface& phonebook, const PhoneBook::contact_t contact)
{
  phonebook.add(contact);
}

void store(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName, const std::string& newMarkName)
{
  phonebook.store(markName, newMarkName, out);
}

void removeContact(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName)
{
  phonebook.removeContact(markName, out);
}

void insertAfter(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName, const PhoneBook::contact_t contact)
{
  phonebook.insertAfter(markName, contact, out);
}

void insertBefore(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName, const PhoneBook::contact_t contact)
{
  phonebook.insertBefore(markName, contact, out);
}

void show(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName)
{
  phonebook.show(markName, out);
}

void moveStep(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName, const long int steps)
{
  phonebook.move(markName, steps, out);
}

void movePos(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName, PhoneBookInterface::Position& pos)
{
  phonebook.move(markName, pos, out);
}

void printInvalidCommand(std::ostream& out)
{
  out << "<INVALID COMMAND>" << "\n";
}

void printInvalidStep(std::ostream& out)
{
  out << "<INVALID STEP>" << "\n";
}

