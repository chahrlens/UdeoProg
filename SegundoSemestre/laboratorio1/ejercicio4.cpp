/*
4- El usuario ingrese el número de datos enteros que se van a trabajar, se debe
realizar el ingreso de los mismos en un arreglo unidimensional y se debe
desplegar si cada número ingresado forma un palíndromo o no.
Nota: 121 – 2332 son números palíndromos porque son números que se leen
de igual manera de izquierda a derecha como de derecha a izquierda.
*/
#include <iostream>
#include <string>
using namespace std;

int inputNumber(string msg);
char numToChar(int);
int charToNumber(char&);

int main () {
    int n  = 0, count = 0;
    n = inputNumber("Ingrese cuantos valores desea registrar:");
    {
        int array[n];
        for (int i =0; i < n; i ++){
            array[i] = inputNumber("Ingrese un valor para la posición: "+to_string(i)+":");
        }
        
        for (int i = 0; i < n; i ++){
            bool isPalindrome = true;
            char word [] = { numToChar(array[i]) };
            int wordLength = (int) sizeof(word) / sizeof(char);
            
            int reverseCount  = 0;
            for (int j = 0 ; j < wordLength; j++){
                reverseCount  --;
                const char* a = &word[j];
                const char* b = &word[reverseCount];
                reverseCount ++;
                isPalindrome = isPalindrome && (atoi(a) == atoi(b));
            }
            if (isPalindrome) {
                cout  << "El numero: " << array[i] << " es palíndromo" << endl;
            }
            else {
                cout  << "El numero: " << array[i] << " no es palíndromo" << endl;
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

char numToChar(int num) {
    string strNum = to_string(num);
    const char*  charNum = strNum.c_str();
    return *charNum;
}
