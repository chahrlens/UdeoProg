#include <iostream>
#include <string>

using namespace std;

int main(){
    int n = 0, sum = 0;
    string ms = "";
    cout << "Ingrese un numero:" << endl;
    cin >> n;
    while (n > 1)
    {
        bool isCousing = true;
        for (int i = 2; i < n; i ++){
        isCousing = isCousing && ((bool) (n % i));
    }
    ms = isCousing ? " es primo" : " no es primo";
    sum += isCousing ? n : 0;

    cout << "El numero: " <<  n << ms << endl << endl;
    n --;

    }
    cout << "La suma total de todos los primos encontrados es:\n" << sum << endl;
    return 0;
}

