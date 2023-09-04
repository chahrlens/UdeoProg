/*
3- El usuario ingrese el número de datos enteros que se van a trabajar, se debe
realizar el ingreso de los mismos en un arreglo unidimensional y se deben
encontrar todos los números primos que hay, se tienen que almacenar los
números primos en otro arreglo y que se desplieguen.
*/
#include <iostream>

using namespace std;

int inputNumber(string msg);
bool isCousins(int);

int main()
{
    int length = 0;
    length = inputNumber("Encontrar números primos\nCuantos datos desea ingresar: ");

    {
        int array[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = inputNumber("Ingrese un valor mayor a cero:");
        }
        cout << endl
             << endl;
        for (int i = 0; i < length; i++)
        {
            if (isCousins(array[i]))
            {
                cout << "Numero primo encontrado: " << array[i] << endl;
            }
        }
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

bool isCousins(int num)
{
    int count = 0;
    bool result = false;
    for (int i = 1; i < num; i++)
    {
        if ((num % i) == 0)
        {
            count++;
        }
    }
    result = count <= 2;
    return result;
}
