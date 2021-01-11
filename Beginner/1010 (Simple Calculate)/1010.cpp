#include <iostream>
#include <stdio.h>
using namespace std;
int main()
{
    int A,B,C,D;
    double E,F;
    cin >> A >> B >> E >> C >> D >> F;
    printf("VALOR A PAGAR: R$ %.2f\n",E*B+D*F);
    system("pause");
    return 0;
}
