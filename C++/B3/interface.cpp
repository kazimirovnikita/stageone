#include "interface.hpp"

#include <iostream>
#include <iterator>
#include "phonebook.hpp"


const std::string INVALID_BOOKMARK = "<INVALID BOOKMARK>\n";
const std::string EMPTY = "<EMPTY>\n";

PhoneBookInterface::PhoneBookInterface()
{
  bookmarks_["current"] = book_.end();
}

void PhoneBookInterface::add(const PhoneBook::contact_t& contact)
{
  book_.pushBack(contact);
  moveMarks();
}

void PhoneBookInterface::store(const std::string& markName, const std::string& newMarkName, std::ostream& out)
{
  if (markName.empty())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
    return;
  }
  bookmarks_[newMarkName] = it->second;
}

void PhoneBookInterface::insertAfter(const std::string& markName, const PhoneBook::contact_t& contact, std::ostream& out)
{
  if (markName.empty())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
    return;
  }
  book_.insertAfter(it->second, contact);
  moveMarks();
}

void PhoneBookInterface::insertBefore(const std::string& markName, const PhoneBook::contact_t& contact, std::ostream& out)
{
  if (markName.empty())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
    return;
  }
  book_.insertBefore(it->second, contact);
  moveMarks();
}

void PhoneBookInterface::removeContact(const std::string& markName, std::ostream& out)
{
  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
     return;
  }

  auto temp = it->second;
  if (temp == book_.end())
  {
    out << EMPTY;
    return;
  }

  for (auto i = bookmarks_.begin(); i != bookmarks_.end(); i++)
  {
    if (i->second == temp)
    {
      if ((i->second != std::prev(book_.end())) || (temp == book_.begin()))
      {
        i->second++;
      }
      else
      {
        i->second--;
      }
    }
  }
  book_.removeContact(temp);
}

void PhoneBookInterface::show(const std::string& markName, std::ostream& out) const
{
  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
    return;
  }
  if (it->second == book_.end())
  {
    out << EMPTY;
    return;
  }
  std::cout << it->second->number << " " << it->second->name << '\n';
}

void PhoneBookInterface::move(const std::string& markName, long int steps, std::ostream& out)
{
  if (markName.empty())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  if (book_.isEmpty())
  {
    out << EMPTY;
    return;
  }

  if (steps > 0)
  {
    if (std::distance(it->second, --book_.end()) < steps)
    {
      it->second = --book_.end();
    }
    it->second = std::next(it->second, steps);
  }
  else
  {
    if (std::distance(book_.begin(), it->second) < -steps)
    {
      it->second = book_.begin();
    }
    it->second = std::prev(it->second, -steps);
  }
}

void PhoneBookInterface::move(const std::string& markName, Position& pos, std::ostream& out)
{
  if (markName.empty())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  auto it = bookmarks_.find(markName);
  if (it == bookmarks_.end())
  {
    out << INVALID_BOOKMARK;
    return;
  }

  if (book_.isEmpty())
  {
    out << EMPTY;
    return;
  }

  if (pos == Position::FIRST)
  {
    it->second = book_.begin();
  }
  else if (pos == Position::LAST)
  {
    it->second = --book_.end();
  }
}

void PhoneBookInterface::moveMarks()
{
  if (std::next(book_.begin()) == book_.end())
  {
    for (auto i = bookmarks_.begin(); i != bookmarks_.end(); i++)
    {
      i->second = book_.begin();
    }
  }
}
