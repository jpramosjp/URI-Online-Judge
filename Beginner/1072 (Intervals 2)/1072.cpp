#include <iostream>
using namespace std;

int main(){
   int N = 0, X = 0;
    int in=0, out=0;
   cin >> N;

   for(int i = 0; i < N; i++){
       cin >> X;
        if(X>=10 && X<=20){
            in++;
        }
        else{
            out++;
        }
   }

    cout << in << " in" << endl;
    cout << out << " out" << endl;
    system ("pause");
    return 0;
}