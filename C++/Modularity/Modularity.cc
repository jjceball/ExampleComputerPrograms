// File name:  ~ftp/pub/class/cplusplus/Modularity/Modularity.cpp
// Purpose:    Driver program for the finding-abslute-value program

#include "Absolute.h"
#include <iostream>
using namespace std;

int main()
{
	int number;
	int abs_number;

	cout << "This program finds the absolute value of an integer." << endl;
	cout << "Enter an integer (positive or negative): ";
	cin >> number;
	
	abs_number = Abs(number);
	cout << "The absolute value of " << number << " is " << abs_number;
	cout << endl;
	return 0;
}