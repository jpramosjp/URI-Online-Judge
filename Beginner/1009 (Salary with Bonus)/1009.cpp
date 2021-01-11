#include <iostream>
#include <stdio.h>
using namespace std;
int main()
{
   string NAME;
   double SALARIO,VENDA;
   cin >> NAME >> SALARIO >> VENDA;
   printf("TOTAL = R$ %.2f\n",VENDA*0.15+SALARIO);
    return 0;
}
