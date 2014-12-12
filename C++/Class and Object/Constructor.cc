// File Name: ~ftp/pub/class/cplusplus/Class/Constructor.cpp
// Purpose:   Demonstrates the use of constructor in a C++ class
// Author:    Ivor Horton, Beginning Visutal C++ 6

#include <iostream>
using namespace std;

// Class to represent a box
class Box
{
  public:
    double length;
    double breadth;
    double height;

    // Constructor
    Box(double lengthValue, double breadthValue, double heightValue)
    {
      cout << "Box constructor called" << endl;
      length = lengthValue;
      breadth = breadthValue;
      height = heightValue;
    }

    // Function to calculate the volume of a box
    double volume()
    {
      return length * breadth * height;
    }
};