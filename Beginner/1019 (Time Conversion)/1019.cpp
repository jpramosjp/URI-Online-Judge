#include <iostream>
using namespace std;
int main()
{
    int N;
    cin >> N;
    cout << N/3600 << ":"; N=N%3600;
    cout << N/60 << ":"; N=N%60;
    cout << N <<endl;
    return 0;
}
