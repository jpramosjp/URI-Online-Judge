#include <iostream>
using namespace std;

int main(){
   int x = 0, y , aux = 0,soma=0;
   int i = 0;

    cin >> x >> y;
   if(x>y){
       aux= y;
       y=x;
       x=aux;
   }

   for(i=x+1; i<y;i++){
       if(i%2){
           soma= soma + i;
       }
   }

    cout << soma << endl;
    system ("pause");
    return 0;
}