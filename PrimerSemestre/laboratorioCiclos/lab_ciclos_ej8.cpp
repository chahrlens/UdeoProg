#include <iostream>
using namespace std;

int main(){
    int n = 0;
    cout << "Convertir base 10 a base 2\nIngrese un numero entero:\n";
    cin >> n;
    cout << n << " Base 10 equivale a: \n";
    while (n > 1)
    {
        cout << n % 2;
        n = n / 2;
    }
    cout << " Base 2" << endl;
    return 0;
}
