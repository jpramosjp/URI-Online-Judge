#include <iostream>
#include <stdio.h>
#include <cmath>
using namespace std;
int main() {
    double x1,y1,x2,y2;
    cin >> x1 >> y1 >> x2 >> y2;
    printf("%.4f\n",sqrt( pow(x2-x1,2.0) + pow(y2-y1,2.0) ) );
    system ("pause");
    return 0;
}
