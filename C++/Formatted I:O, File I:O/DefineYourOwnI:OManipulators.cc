// File name: ~ftp/pub/class/cplusplus/IO/IOUserManip.cpp
// Purpose:   Demonstrates how to define an IO manipulator function
//            of your own.

#include <iostream>
#include <iomanip>
using namespace std;

// function prototype for a user-defined IO manipulator function
ostream &SetHex(ostream &stream);

int main()
{
	int input;
	cout << "Enter an integer: " ;
	cin  >> input;

	cout << "Hexdecimal is: ";
	
	// call the SetHex function so that the input
	// integer will be printed out in hexdecimal
	cout << SetHex << input << endl;
	return 0;
}

// definition of a user defined I/O manipulate function
ostream &SetHex(ostream &stream)
{
	// Set output base to be hexdecimal.
	// Use ios::basefield to make sure that all other
	// field in basefield is cleared before setting it
	// to hex.
	stream.setf(ios::hex,ios::basefield); 
	return stream;
}