#include <iostream>

using namespace std;

int main() {
    double fahrenheit = 0, kelvin = 0, celcius = 0;
    cout << "Ingrese un valor en grados Fahrenheit" << endl;
    cin >> fahrenheit;
    celcius = (fahrenheit - 32) * 1.8;
    kelvin = ((fahrenheit + 459.67) * (0.555555556));
    cout << endl << fahrenheit << " Fahrenheit equivale a: " << celcius << " celcius." << endl;
    cout << endl << fahrenheit << " Fahrenheit equivale a: " << kelvin << " kelvin." << endl;

    return 0;
}