/*
7- Ingresar un numero en sistema de base 2 y se debe desplegar el equivalente
en sistema de base 10 y base 16. (Utilice arreglos unidimensionales)
*/

#include <iostream>
#include <string>
#include <math.h>
using namespace std;
int inputNumber(string msg);
void convertToDec(string &);
void convertToHex(const string &);
unsigned int convertStrBinaryToHex(const string &);

int main()
{
    int n = 0;
    n = inputNumber("Convertir numero binario a decimal y hexadecimal\nCuantos valores desea ingresar?\n->:");
    string array[n];
    for (int i = 0; i < n; i++)
    {
        cout << endl
             << "Ingrese un valor para la posición: " + to_string(i) + ":";
        cin >> array[i];
    }

    for (int i = 0; i < n; i++)
    {
        convertToHex(array[i]);
        convertToDec(array[i]);
    }

    return 0;
}

int inputNumber(string msg)
{

    int n = 0, attemps = 0;
    do
    {
        cout << msg << endl;
        if (attemps)
        {
            cout << "Intente de nuevo:" << endl;
        }
        cin >> n;
        attemps++;

    } while (!n);
    return n;
}

void convertToDec(string &number)
{
    int decimal = 0;
    int pot = 0;

    for (int i = number.length() - 1; i >= 0; i--)
    {
        if (number[i] == '1')
        {
            decimal += pow(2, pot);
        }
        pot++;
    }

    cout << endl << decimal << " Base 10" << endl;
}

void convertToHex(const string &number)
{
    std::string binario = number;
    unsigned int charts[20];
    int count = 0;
    size_t i = binario.length();
    int length = static_cast<int>(i);

    // Comprobar si el numero binario esta completo
    if ((length % 4) != 0)
    {
        int missing = 4 - (length % 4);
        for (int j = 0; j < missing; ++j)
        {
            binario.insert(0, "0");
        }
        i = binario.length();
    }

    std::cout << std::endl
              << binario << " Base 2 equivale a: " << std::endl;
    // Convertir cada cuarteto en Hex
    while (i >= 4)
    {
        std::string num = binario.substr(i - 4, 4);
        i -= 4;
        charts[count] = convertStrBinaryToHex(num);
        count++;
    }

    // Imprimir cada cuarteto en Hex
    for (int j = count - 1; j >= 0; j--)
    {
        if (charts[j] > 9)
        {
            std::cout << (char)charts[j];
        }
        else
        {
            std::cout << charts[j];
        }
    }

    std::cout << " Base 16" << std::endl;
}

unsigned int convertStrBinaryToHex(const string &number)
{
    size_t length = number.length();
    unsigned int sum = 0;

    for (size_t i = 0; i < length; i++)
    {
        char bit = number[i];

        int bitValue = bit - '0';
        sum = sum * 2 + bitValue;
    }

    if (sum > 9)
    {
        sum += 'A' - 10;
    }

    return sum;
}
