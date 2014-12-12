// File:    ~ftp/pub/class/cplusplus/Inheritance/ProtectedInheritance.cpp
// Purpose: using protected for inheritance of a base class

#include <iostream>
using namespace std;

class base {
  int i;
protected:
  int j;
public:
  int k;
  void seti(int a) { i = a; }
  int geti() { return i; }
};

// Inherit base as protected.
class derived : protected base {
public:
  void setj(int a) { j = a; } // j is protected here
  void setk(int a) { k = a; } // k is also protected
  int getj() { return j; }
  int getk() { return k; }
};

int main()
{
  derived ob;

  /* This next line is illegal because seti() is
     a protected member of derived, which makes it
     inaccessible outside of derived. */
//  ob.seti(10);

//  cout << ob.geti(); // illegal -- geti() is protected
//  ob.k = 10; // also illegal because k is protected

  // these next statements are OK
  ob.setk(10);
  cout << ob.getk() << ' ';
  ob.setj(12);
  cout << ob.getj() << ' ';

  return 0;
}
