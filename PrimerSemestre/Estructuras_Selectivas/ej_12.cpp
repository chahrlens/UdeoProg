#include <iostream>

using namespace std;

int main() {
    double seg = 0, d = 0, h = 0, m;
    cout << "Ingrese una tiempo en Segundos" << endl;
    cin >> seg;

    m = seg / 60;
    h = m  / 60;
    d = h / 24;
    
    cout << endl << seg << " Seg Equivale a: " << m << " minutos"
        << endl  << seg << " Seg Equivale a: " << h << " horas"
        << endl  << seg << " Seg Equivale a: " << d << " dias" <<endl;
    return 0;
}