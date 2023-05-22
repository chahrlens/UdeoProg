#include <iostream>
using namespace std;
/*
12-El usuario ingrese un número en base 2 y que se despliegue su
equivalente en base 16
*/
string numToChar(int);
int main()
{
    string binario = "";
    int n = 0, v = 0, temp = 0, aux = 0, count = 0;
    cout << "Convertir base 2 a base 16\nIngrese un numero entero:\n";
    cin >> binario;
    cout << endl << n << " Base 10 equivale a: \n";
    size_t i = binario.length();
    while ( i > 0){
        i -= 4;
        string num = binario.substr(i, i+4);
        cout << i <<" -- - i "<< i+4 << " = "<< num << endl;
    }

    return 0;
}

string numToChar(int n)
{
    string x;
    switch (n)
    {
    case 15:
        x = 'F';
        break;

    case 14:
        x = 'E';
        break;
    case 13:
        x = 'D';
        break;

    case 12:
        x = 'C';
        break;

    case 11:
        x = 'B';
        break;

    case 10:
        x = 'A';
        break;
    default:
        x = to_string(n);
        break;
    }
    return x;
}