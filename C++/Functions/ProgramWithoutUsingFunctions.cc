//
// File name: ~ftp/pub/class/cplusplus/Functions/Absolute1.cpp
// Purpose:   This program find the absolute value of an integer
//	      without using a function
//

#include <iostream>
using namespace std;

int main()
{
	int number;
	int abs_number;

	// Ask for input
	cout << "This program finds the absolute value of an integer." << endl;
	cout << "Enter an integer (positive or negative): ";
	cin >> number;
	
	// Find the absolute value
	if(number >= 0)
	{
		abs_number = number;
	}
	else
		abs_number = -number;
	
	// Print out output
	cout << "The absolute value of " << number << " is " << abs_number;
	cout << endl;
	return 0;
}