#include <iostream>

using namespace std;

int main() {
    double km = 0, cm = 0;
    const double relacion = 100000;
    cout << "Ingrese una distancia en Kilometros" << endl;
    cin >> km;

    cm = km * relacion;
    cout << endl << km << " Km Equivale a: " << cm << " cm" << endl;
    return 0;
}