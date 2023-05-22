#include <iostream>
using namespace std;
/*
Se debe encontrar la suma de n datos reales, el usuario debe ingresar
el valor de n, luego el usuario debe ingresar los n datos y se debe
encontrar la suma (No se debe utilizar arreglos).
*/
int main()
{
    int n = 0, sm = 0, temp = 0;
    cout << "Sumatoria de n datos\n Ingrese el valor de n:" << endl;
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cout << "\nAgregue un valor: " << endl;
        cin >> temp;
        sm += temp;
    }
    cout << "\nLa suma de todos los numeros es: " << sm << endl;
    return 0;
}