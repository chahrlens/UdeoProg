#include <iostream>

using namespace std;

int main() {
    double fahrenheit = 0, kelvin = 0, celcius = 0;
    cout << "Ingrese un valor en grados Celcius" << endl;
    cin >> celcius;
    fahrenheit = (celcius * 1.8) + 32;
    kelvin = celcius + 273.15;
    cout << endl << celcius << " Celcius equivale a: " << fahrenheit << " fahrenheit." << endl;
    cout << endl << celcius << " Celcius equivale a: " << kelvin << " kelvin." << endl;

    return 0;
}