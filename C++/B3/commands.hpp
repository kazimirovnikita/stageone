#ifndef COMMANDS_HPP
#define COMMANDS_HPP

#include <iostream>
#include "interface.hpp"
#include "phonebook.hpp"


void add(PhoneBookInterface& phonebook, const PhoneBook::contact_t contact);
void store(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName, const std::string& newMarkName);
void removeContact(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName);
void insertAfter(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName,
    const PhoneBook::contact_t contact);
void insertBefore(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName,
    const PhoneBook::contact_t contact);
void show(PhoneBookInterface& phonebook, std::ostream& out, const std::string& markName);
void moveStep(PhoneBookInterface& phonebook, std::ostream& out,
    const std::string& markName, const long int steps);
void movePos(PhoneBookInterface& phonebook, std::ostream& out,
    const std::string& markName, PhoneBookInterface::Position& pos);

void printInvalidCommand(std::ostream& out);
void printInvalidStep(std::ostream& out);
#endif
