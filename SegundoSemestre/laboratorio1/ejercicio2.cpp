/*
2- El usuario ingrese el número de datos enteros que se van a trabajar, se debe
realizar el ingreso de los mismos en un arreglo unidimensional y encontrar
cuántos números son múltiplos de 5.
*/

#include <iostream>
#include <string>

using namespace std;

int inputNumber(string);

int main(){
    int n = 0, count = 0;
    cout << "Encontrar múltiplos de 5" << endl;
    n = inputNumber("Cuantos datos desea ingresar:");
    {
        int array[n];
        for (int i = 0; i < n; i ++){
            array[i] = inputNumber("Ingrese un valor para la posición i = "+to_string(i)+":");
        }
        for (int i = 0; i < n; i ++){
            bool isDivisible = false;
            isDivisible = (array[i] % 5 == 0) ? true : false;
            if (isDivisible){
                count ++;
                cout << "Numero encontrado: "<< array[i] << endl;
            }
        }
        cout << "Fueron encontrados (" << count << ") números divisibles entre 5" << endl;
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