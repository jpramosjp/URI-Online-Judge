#include <iostream>
using namespace std;

int main(){
   int x = 0 ;
   int i = 0 ;

   cin >> x ;

   for (i = 0; i < 6; i++){
       if(x % 2 == 0){
           x ++;
           cout << x << endl;
       }
      else if(x % 2 == 1){
           cout << x << endl;
       }
       x=x+2;
   }

    system ("pause");
    return 0;
}