//
// File name: ~ftp/pub/class/cplusplus/Functions/Absolute2.cpp
// Purpose:   This program finds the absolute value of an integer
//	      using a function
//

int Abs(int i); // Function prototype
int main()
{
	int number;
	int abs_number;

	cout << "This program finds the absolute value of an integer." << endl;
	cout << "Enter an integer (positive or negative): ";
	cin >> number;
	
	// Calling the function Abs()
	abs_number = Abs(number);
	cout << "The absolute value of " << number << " is " << abs_number;
	cout << endl;
	return 0;
}
// Function definition
int Abs(int i)
{
	if( i >= 0)
		return i;
	else
		return -i;
}