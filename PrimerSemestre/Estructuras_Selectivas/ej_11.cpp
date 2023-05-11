#include <iostream>

using namespace std;

int main() {
    double km = 0, m = 0, cm = 0;
    const double relacion_cm_m = 100, relacion_m_km = 1000;
    cout << "Ingrese una distancia en Centimetros" << endl;
    cin >> cm;

    m  = cm / relacion_cm_m;
    km = m / relacion_m_km;
    cout << endl << cm << " Cm Equivale a: " << m << " m"
         << endl << cm << " Cm Equivale a: " << km <<endl;
    return 0;
}