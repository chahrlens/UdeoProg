#include <iostream>
#include <string>

using namespace std;

int main(){
    cout << "Ingrese un numero entero:\n";
    int n = 0, sum = 0;

    cin >> n;

    for (int i = n; i >0; i--) {
        sum += i;
        cout << i << "; ";
    }

    cout << endl << "La suma de todos es  = " << sum << endl;

    return 0;
}