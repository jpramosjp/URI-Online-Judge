#include <iostream>
#include <stdio.h>
using namespace std;
int main() {
    int number, hours;
    double salary;
    cin >> number >> hours >> salary;
    printf("NUMBER = %d\nSALARY = U$ %.2f\n",number,salary*hours);
    return 0;
}
