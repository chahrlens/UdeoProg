#include <iostream>
using namespace std;

int main() {
    double celsius = 0.0;
    cout << "Convertir grados celsius a fahrenheit y kelvin\nIngrese grados celsius\n\n";
    cin >> celsius;

    cout << endl << celsius << " C = " << ((celsius* (9/5))+32) << " Fahrenheit\n\n"
         << celsius << " C = " << (celsius + 273.15) << " Kelvin\n";

    return 0;
}