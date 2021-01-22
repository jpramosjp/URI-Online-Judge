#include <iostream>
using namespace std;

int main(){
    int a = 0, b = 0, c = 0, d = 0 , e = 0;
    int auxiP = 0, auxiN = 0, auxiPa = 0, auxiIm = 0;
    cin >> a >> b >> c >> d >> e ;

   if(a > 0){
       auxiP++;
   }
   else if (a < 0){
       auxiN++;
   }
    if (a % 2 == 0){
        auxiPa++;
    }
    else{
        auxiIm++;
    }

    
   if(b > 0){
       auxiP++;
   }
   else if (b < 0){
       auxiN++;
   }
    if (b % 2 == 0){
        auxiPa++;
    }
    else{
        auxiIm++;
    }

    if(c > 0){
       auxiP++;
   }
   else if (c < 0){
       auxiN++;
   }
    if (c % 2 == 0){
        auxiPa++;
    }
    else{
        auxiIm++;
    }

    if(d > 0){
       auxiP++;
   }
   else if (d < 0){
       auxiN++;
   }
    if (d % 2 == 0){
        auxiPa++;
    }
    else{
        auxiIm++;
    }

    if(e > 0){
       auxiP++;
   }
   else if (e < 0){
       auxiN++;
   }
    if (e % 2 == 0){
        auxiPa++;
    }
    else{
       auxiIm++;
    }

    cout << auxiPa << " valor(es) par(es)" << endl;
    cout << auxiIm << " valor(es) impar(es)" << endl;
    cout << auxiP << " valor(es) positivo(s)" << endl;
    cout << auxiN << " valor(es) negativo(s)" << endl;

    system ("pause");
    return 0;
}