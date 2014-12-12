// File name: ~ftp/pub/class/cplusplus/Modularity/Absolute.cpp
// Purpose:   implementation of the Abs() function declared in
//            Absolute.h

#include "Absolute.h" // This header file contains the function prototype
int Abs(int i)
{
	if( i >= 0)
		return i;
	else
		return -i;
}