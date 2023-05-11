#include <iostream>

using namespace std;

int main() {
    double km = 0, cm = 0;
    const double relacion = 27.778;
    cout << "Ingrese una velocidad en Kilometros/h" << endl;
    cin >> km;

    cm = km * relacion;
    cout << endl << km << " Km/h Equivale a: " << cm << " cm/s" << endl;
    return 0;
}