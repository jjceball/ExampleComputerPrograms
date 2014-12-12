// File:    ~ftp/pub/class/cplusplus/Class/CopyCons.cpp
// Purpose: Demonstrate the use of copy constructor in C++

#include <iostream>
#include <cstdlib>
using namespace std;

class myclass {
  int *p;
public:
  myclass(int i);
  ~myclass();
  int getval() { return *p; }
};

myclass::myclass(int i)
{
  cout << "Allocating p\n";
  p = new int;
  if(!p) {
    cout << "Allocation failure.\n";
    exit(1); // exit program if out of memory
  }

  *p = i;
}

myclass::~myclass()
{
  cout << "Freeing p\n";
  delete p;
}

// when this function is called, the copy constructor is called
void display(myclass ob)
{
  cout << ob.getval() << '\n';
}

int main()
{
  myclass a(10);

  display(a);

  return 0;
}