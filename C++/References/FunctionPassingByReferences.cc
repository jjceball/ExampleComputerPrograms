// File name: ~ftp/pub/class/cplusplus/Reference/RefFunction.cpp
// Purpose:   Demonstrates pass by reference in a function

#include <iostream>
using namespace std;

void swap(int &i, int &j);  // function prototype for swapping two values

int main()
{
	int NumOne = 0;
	int NumTwo = 0;

	cout << "Please enter two integers: " << endl;

	cout << "Enter value for NumOne: " ;
	cin >> NumOne;

	cout << "Enter value for NumTwo: " ;
	cin >> NumTwo;

	cout << "Before swapping, NumOne is: " << NumOne << endl;
	cout << "Before swapping, NumTwo is: " << NumTwo<< endl;

	swap(NumOne, NumTwo);

	cout << "After swapping, NumOne is: " << NumOne << endl;
	cout << "After swapping, NumTwo is: " << NumTwo<< endl;

	return 0;
}

// function definition for swap()

void swap(int &i, int &j)
{
	int temp;

	temp = i;
	i = j;
	j = temp;

}