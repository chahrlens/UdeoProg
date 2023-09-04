/*
Ingresar un numero entero positivo en sistema decimal y se debe desplegar
el equivalente en sistema de base 2 y base 16. (Utilice arreglos
unidimensionales)
*/

#include <iostream>

using namespace std;

int inputNumber(string msg);
void convertToBinary(int);
void convertToExa(int);

int main()
{
    int n = 0;
    n = inputNumber("Ingrese cuantos valores desea registrar:");
    int array[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = inputNumber("Ingrese un valor para la posición: " + to_string(i) + ":");
    }

    for (int i = 0; i < n; i++)
    {
        cout << endl;
        convertToBinary(array[i]);
        convertToExa(array[i]);
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

void convertToBinary(int number)
{
    cout << "Numer: " << to_string(number) << " base 10 equivale a:" << endl;
    string numbers = "";
    while (number > 1)
    {
        numbers.insert(0, to_string(number % 2));
        number = (int)(number / 2);
    }
    if (number > 0)
    {
        numbers.insert(0, to_string(number % 2));
    }
    cout << numbers << " base 2" << endl;
}

void convertToExa(int number)
{
    int n = 0, v = 0, temp = 0, aux = 0, count = 0, maxLength = 10;
    if (number > 90000)
    {
        maxLength = (int)((number / 100) / 100);
    }
    unsigned int array[maxLength];
    v = number;
    while (v > 0)
    {
        if (v <= 9)
        {
            array[count] = v;
        }
        temp = v;
        v = (int)temp / 16;
        aux = temp - (int)(v * 16);
        if (aux > 9)
        {
            aux += 55;
        }
        array[count] = aux;
        count++;
    }
    std::cout << "Decimal " << number << " en hexadecimal es: ";

    for (int i = count - 1; i >= 0; i--)
    {
        if (array[i] > 9)
        {
            cout << (unsigned char)array[i];
        }
        else
        {
            cout << array[i];
        }
    }

    std::cout << std::endl;
}
