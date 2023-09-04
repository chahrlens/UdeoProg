
/*
El usuario ingrese el número de datos reales que se van a trabajar, se debe
realizar el ingreso de los mismos en un arreglo unidimensional y se debe
desplegar la suma de todos los números.
*/
#include <iostream>

using namespace std;

int inputNumber(string msg);

int main()
{
    int sm = 0, n = 0;
    n = inputNumber("Ingrese cuantos valores desea registrar:");

    int array[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = inputNumber("Ingrese un valor para la posición: " + to_string(i) + ":");
    }

    for (int i = 0; i < n ; i ++ ){
        sm = (sm + array[i]);
    }

    cout << "El Valor total de la sumatoria es: " << sm << endl;


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