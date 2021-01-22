#include <iostream>
using namespace std;

int main(){
    float x[6], auxiM = 0, m;
    int i = 0, auxiP = 0;
    for (i = 0; i < 6 ; i++){
        cin >> x[i];
        if (x[i] > 0){
            auxiP++;
            auxiM = auxiM + x[i];
        }
    }
    m=auxiM/auxiP;

    cout << auxiP << " valores positivos" << endl;
    printf("%.1f\n",m);

    system ("pause");
    return 0;
}