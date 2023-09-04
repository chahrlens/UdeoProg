/*
11- Ingresar una frase que no pase de 20 caracteres, se debe guardar en un
arreglo tipo char. Se debe desplegar:

El número de letras minúsculas
El número de letras mayúsculas
El número de dígitos
El número de caracteres especiales
*/

#include <iostream>
#include <string>

using namespace std;

int main()
{
    int min = 0, may = 0, digit = 0, special = 0;
    char array[20];
    for (int i = 0; i < 20; i++)
    {
        array[i] = '\0';
    }
    cout << "Ingrese cualquier texto menor a 20 caracteres\n";
    cin.getline(array, 20, '\n');

    for (int i = 0; i < 20; i++)
    {
        const char item = array[i];
        min     = (item >= 'a' && item <= 'z') ? (min + 1) : min;
        may     = (item >= 'A' && item <= 'Z') ? (may + 1) : may;
        digit   = (item >= '1' && item <= '9') ? (digit + 1) : digit;
        special = ((item >= 32 && item <= '/') || (item >= 58 && item <= 63) || (item >= 123 && item <= 126)) ? (special + 1) : special;
    }
    cout << "Valores encontrados:"
         << "\nLetras minúsculas:     " << min
         << "\nLetras mayúsculas:     " << may
         << "\nNúmero de dígitos:     " << digit
         << "\nCaracteres especiales: " << special << endl;

    return 0;
}