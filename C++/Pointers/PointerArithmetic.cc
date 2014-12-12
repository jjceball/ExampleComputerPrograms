// File name:  ~ftp/pub/class/cplusplus/Pointer/PointerArith.cpp
// Purpose:    Demonstrates pointer arithmetic

#include <iostream>
using namespace std;

int main()
{
	int	IntArray[10]; // array of int
	int 	*pInt;        // pointer to int
	int	i;            // loop counter

	// populate the int array with 1, 2, 3, ...
	for(i = 0; i < 10; i++)
	{
		IntArray[i] = i+1;
	}

	// store the address of the first element of IntArray 
	//in pointer
	pInt = IntArray;

	// print out values in the int array
	for (i = 0; i < 10; i++)
	{
		cout << *pInt << ' ' ;
		pInt++;      // pointer arithmetic
		// the above two lines could also be replaced with:
		// cout << *(pInt++) << ' ' ;
	}
	cout << endl;
	return 0;
}
