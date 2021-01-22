#include <iostream>
using namespace std;

int main(){
   int x[5], contP = 0 ;
   int i = 0 ;

   for (i = 0; i < 5; i++){
       cin >> x[i];
       if(x[i] % 2 == 0){
           contP++;
       }
   }

    cout << contP << " valores pares" << endl;
    system ("pause");
    return 0;
}