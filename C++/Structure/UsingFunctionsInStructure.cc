// File Name: ~ftp/pub/class/cplusplus/Structure/StrucSimple.cpp
// Purpose:   Demonstrates the use of funciton in C++ struct.
//            Stores some personal data in a structure, then prints
//            the info out.

#include <iostream>
using namespace std;

int main()
{
        
        struct PersonalData
        {
                char *FirstName;
                char *LastName;
                char *Birthday;  // in the format of 12/30/1978
                int  PhoneNum;

                // struc can also have member functions
                void PrintDat()
                {
                        // Print the data out
                        cout << "First name is: " << FirstName << endl;
                        cout << "Last name is: " << LastName << endl;
                        cout << "Birthday is: " << Birthday << endl;
                        cout << "Phone number is: " << PhoneNum << endl;
                }
        }; // don't forget the ending ";"

        // Declaring a variable of type PersonalData
        PersonalData PersonOne;

        // Populate PersonOne with data
        PersonOne.FirstName = "John";
        PersonOne.LastName = "Doe";
        PersonOne.Birthday = "12/30/1978";
        PersonOne.PhoneNum = 5855555;

        PersonOne.PrintDat();
        return 0;
}