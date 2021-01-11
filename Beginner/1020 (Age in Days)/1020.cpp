#include <iostream>
using namespace std;

int main()
{
   int I;
   cin >> I;
   cout << I/365 << " ano(s)" << endl; I=I%365;
   cout << I/30 << " mes(es)" << endl; I=I%30;
   cout << I << " dia(s)" << endl;

    return 0;
}
