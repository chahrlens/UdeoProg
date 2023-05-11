#include <iostream>
using namespace std;


int main(){
        double fahrenheit = 0.0;
    cout << "Convertir grados fahrenheit, a celsius y kelvin\nIngrese grados Fahrenheit25\n\n";
    cin >> fahrenheit;

    cout << endl << fahrenheit << " F = " << ((fahrenheit -32.0 )/(1.8)) << " Celsius\n\n"
         << fahrenheit << " F = " << (((fahrenheit -32.0 )/(1.8)) + 273.15) << " Kelvin\n";

    return 0;
}