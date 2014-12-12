// File Name: ~ftp/pub/class/cplusplus/Structure/StrucSimple.cpp
// Purpose:   Demonstrates the use of nested structure in C++.
//            Stores some personal data in a structure, then prints
//            the info out.

#include <iostream>
using namespace std;

int main()
{
        // Defining a structure for name
        struct Name
        {
                char *FirstName;
                char *LastName;
        };

        struct PersonalData
        {
                Name NameField; // struct as a memeber
                char *Birthday;  // in the format of 12/30/1978
                int  PhoneNum;
        }; // don't forget the ending ";"

        // Declaring a variable of type PersonalData
        PersonalData PersonOne;


        PersonOne.NameField.FirstName = "John";
        PersonOne.NameField.LastName = "Doe";

        // Populate PersonOne with data
        PersonOne.Birthday = "12/30/1978";
        PersonOne.PhoneNum = 5855555;

        // Print the data out
        cout << "First name is: " << PersonOne.NameField.FirstName << endl;
        cout << "Last name is: " << PersonOne.NameField.LastName<< endl;
        cout << "Birthday is: " << PersonOne.Birthday<< endl;
        cout << "Phone number is: " << PersonOne.PhoneNum<< endl;

        return 0;
}
