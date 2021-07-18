#include<iostream>
#include<map>
#include<vector>
#include "header.h"

using namespace std;

int main() {
    listActions();
    dictionaryActions();

    return 0;
}

void listActions() {
    vector<Employee*> list;

    list.push_back(new Employee("Mike", 25));
    list.push_back(new Employee("Sue", 45));

    for (auto const& employee : list)
        cout << employee->name << employee->age << "\r\n";

    for (size_t i=0; i<list.size(); ++i)
        cout << list[i]->name << list[i]->age << "\r\n";
}

void dictionaryActions() {
    map<int, Employee*> dict;

    dict[0] = new Employee("Mike", 25);
    dict[1] = new Employee("Sue", 45);
    dict[10] = NULL; // compiles

    for (auto const &pair : dict)
        if (pair.second != NULL)
            cout << pair.first << pair.second->name << pair.second->age << "\r\n";

    dict[0] = new Employee("Joe", 32);

    if (dict.find(0) != dict.end()) {
        dict[0]->name = "Mike";
        cout << dict[0]->name << "\r\n";
    }       
}