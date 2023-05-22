#include <iostream>
using namespace std;
/*
El usuario ingrese un número en base 10 y que se despliegue su
equivalente en base 16
*/
string numToChar(int);
int main()
{
    string hexnum = "";
    int n = 0, v = 0, temp = 0, aux = 0;
    cout << "Convertir base 10 a base 16\nIngrese un numero entero:\n";
    cin >> n;
    cout << endl << n << " Base 10 equivale a: \n";
    v = n;

    while (v > 0)
    {
        if (v <= 9)
        {
            hexnum.insert(0, numToChar(v));
            break;
        }
        temp = v;
        v = (int)temp / 16;
        aux = temp - (int)(v * 16);
        hexnum.insert(0, numToChar(aux));
    }
    cout << hexnum << " Base 16" << endl;
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