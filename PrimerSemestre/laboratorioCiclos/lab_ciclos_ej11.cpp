#include <iostream>
#include <string>
#include <math.h>
using namespace std;
/*
El usuario ingrese un número en base 16 y que se despliegue su
equivalente en base 2
*/
int charToNumber(char);
int main()
{
    int count = 0, sm = 0, n = 0;
    string number = "";
    cout << "Ingrese un numero hexadecimal: " << endl;
    cin >> number;
    for (size_t i = number.length(); i > 0; i--)
    {
        char l = number[i - 1];
        cout << "L = " << l << endl;
        int base = pow(16, count);
        sm += (base * charToNumber(l));
        count++;
    }
    
    n = sm;
    while (n > 1)
    {
        cout << n % 2;
        n = n / 2;
    }
    cout << " Base 2" << endl;
    return 0;
    cout << number << " b16 Equivale a: " << n << " b2 " << endl;
    return 0;
}

int charToNumber(char c)
{
    int n = 0;
    if (c == 'F' || c == 'f')
    {
        n = 15;
    }
    else if (c == 'E' || c == 'e')
    {
        n = 14;
    }
    else if (c == 'D' || c == 'd')
    {
        n = 13;
    }
    else if (c == 'C' || c == 'c')
    {
        n = 12;
    }
    else if (c == 'B' || c == 'b')
    {
        n = 11;
    }
    else if (c == 'A' || c == 'a')
    {
        n = 10;
    }
    else
    {
        n = (int)c - 48;
    }
    cout << "c = " << c << "N = " << n << endl;
    return n;
}