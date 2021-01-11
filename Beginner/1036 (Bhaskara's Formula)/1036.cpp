#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;
int main()
{
    double A,B,C,delta;
    cin >> A >> B >> C;
    delta= pow(B,2.0) -4 * A * C;
    if (A<=0 || delta < 0){
        cout << "Impossivel calcular" << endl;
    }
    else{
        printf("R1 = %.5f\n", ((-B) + sqrt(delta))/(2*A));
        printf("R2 = %.5f\n", ((-B)- sqrt(delta))/(2*A));
    }

    return 0;
}