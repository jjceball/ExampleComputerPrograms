// File name: ~ftp/pub/class/cplusplus/Array/Array2.cpp
// Purpose:   Demonstrate the use of character array.
//	      Ask for the user's name and print it out.

#include <iostream>
#include <stdlib.h> //for newer compilers, include <cstdlib>
using namespace std;

int main()
{
	char name[32]; // big enough to hold 32 characters

	// prompt for the name
	cout << "What's your name?" << endl;
	gets(name); // read a string from the key board.
	cout << "Hello! " << name << "!"  << endl;

	return 0;
}