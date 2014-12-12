// File name: ~ftp/pub/class/cplusplus/IO/IOMember.cpp
// Purpose:   Demonstrating formatted IO manipulators

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	float num[5] = {1.0, -1.2345, 2350.1, 23.4, 45.34};
	int i;

 	cout << setiosflags(ios::showpos);
	cout << setiosflags(ios::scientific); 
	cout << setprecision(2); 
	
	for(i = 0; i < 5; i++)
	{
  		cout << setw(20);    
  		cout << setfill('$');    
  	    	cout << num[i] << endl;
	}

  return 0;
}