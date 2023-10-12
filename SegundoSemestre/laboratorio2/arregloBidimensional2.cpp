#include <iostream>

using namespace std;
int inputNumber(string);
void addArray(int, int, void *);

int main()
{
    int column = 0, row = 0;
    row = inputNumber("Ingrese filas de la matriz:");
    column = inputNumber("Ingrese columnas de la matriz:");
    cout << endl
         << endl;
    {
        int arrayA[row][column];
        int arrayB[row][column];
        int arrayC[row][column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arrayA[i][j] = inputNumber("Ingrese un valor para la sección A: [" + to_string(i) + "][" + to_string(j) + "]: ");
            }
        }
        cout << endl
             << endl;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arrayB[i][j] = inputNumber("Ingrese un valor para la sección B: [" + to_string(i) + "][" + to_string(j) + "]: ");
            }
        }
        cout << endl
             << endl;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arrayC[i][j] = arrayA[i][j] + arrayB[i][j];
                cout << "Los elementos del arreglo A [" + to_string(i) + "][" + to_string(j) + "] + Arreglo B " + to_string(i) + "][" + to_string(j) + "] es: "
                     << arrayC[i][j] << endl;
            }
        }
    }

    return 0;
}

//Se desborda la memoria
void addArray(int row, int column, void *parse_array)
{
    int(*array)[row][column] = (int(*)[row][column])parse_array;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            int &section = *array[i][j];
            section = inputNumber("Ingrese un valor para la sección [" + to_string(i) + "][" + to_string(j) + "]: ");
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