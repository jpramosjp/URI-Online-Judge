#include <iostream>
using namespace std;

int main(){
  float x=0,soma=0,rej=0,percent=0;
  cin >> x;

  if(x>0 && x<=400.00){
      percent = 15;
      rej=x*(percent/100);
      soma = x + rej;
  }
  else if (x>400.00 && x<=800.00){
      percent = 12;
      rej=x*(percent/100);
      soma = x + rej;
  }
  else if (x>800.00 && x <= 1200.00){
      percent = 10;
      rej=x*(percent/100);
      soma = x + rej;
  }
  else if (x >1200.00 && x <=2000.00){
      percent = 7;
      rej=x*(percent/100);
      soma = x + rej;
  }
  else if (x>2000.00){
      percent = 4;
      rej=x*(percent/100);
      soma = x + rej;
  }

    printf("Novo salario: %.2f\n",soma);
    printf("Reajuste ganho: %.2f\n",rej);
    printf("Em percentual: %.0f %\n",percent);

    system ("pause");
    return 0;
}