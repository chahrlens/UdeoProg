#include <iostream>

using namespace std;
int inputNumber(string);
void addArray(int array[3][3]);

int main()
{
    int arrayA[3][3];
    int arrayB[3][3];
    int arrayC[3][3];

    addArray(arrayA);
    cout << endl
         << endl;
    addArray(arrayB);

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arrayC[i][j] = arrayA[i][j] + arrayB[i][j];
            cout << "Los elementos del arreglo A [" + to_string(i) + "][" + to_string(j) + "] + Arreglo B " + to_string(i) + "][" + to_string(j) + "] es: "
                 << arrayC[i][j] << endl;
        }
    }
    return 0;
}

void addArray(int array[3][3])
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            array[i][j] = inputNumber("Ingrese un valor para la sección [" + to_string(i) + "][" + to_string(j) + "]: ");
        }
    }
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