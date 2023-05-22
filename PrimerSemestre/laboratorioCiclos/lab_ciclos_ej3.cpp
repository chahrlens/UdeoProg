#include <iostream>
/*
Realizar un programa que encuentre el Fibonacci de un número entero
positivo n, el usuario debe ingresar dicho número
*/

using namespace std;

int fi(int);

int main()
{
    int n = 0;
    cout << "Ingrese un numero\n";
    cin >> n;
    fi(n);
    return 0;
}

int fi(int n)
{
    cout << n << endl;
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return fi(n - 1);
    }
}