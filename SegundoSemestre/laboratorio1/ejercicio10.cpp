/*
10- Ingresar una frase con letras minúsculas y que no pase de 20 caracteres,
se debe guardar en un arreglo tipo char. Se debe desplegar la misma frase pero
los caracteres deben ir en orden alfabético ascendente, ya no se tomarían en
cuenta los espacios en blanco.
*/
#include <iostream>
# include <string>

using namespace std;

int main () {
    char words [20];
    for (int i =0; i < 20; i ++){
        words[i] = '\0';
    }
    cout << "Ingrese una palabra esta menor a 20 caracteres" << endl;
    cin.getline(words, 20, '\n');
    cout << endl;
    //Ordenamiento
    for (int i = 0; i < 20; i ++){
        for (int j = 0; j < 19; j ++){
            if (words[j] == 32){
                words[j] = '\0';
            }else if (words[j] >= 'A' && words[j] <= 'Z'){
                words[j] = words[j]+32;
            }
            if (words[j] > words[j + 1]){
                int aux = words[j];
                words[j] = words[j+1];
                words[j+1] = aux;
            }
        }
    }
    for (int i = 0; i < 20; i ++){
        cout << words[i];
    }
    cout << endl;
    return 0;
}