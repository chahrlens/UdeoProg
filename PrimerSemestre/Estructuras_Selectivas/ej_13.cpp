#include <iostream>

using namespace std;

int main() {
    double angulo = 0.0;
    int grados = 0, min = 0, seg= 0;
    float aux1 = 0.0, aux2 = 0.0;
    cout << "Convertir Grados a minutos y segundos" << endl;
    cin >> angulo;
    grados = (int) angulo;
    min = (int) ((angulo - grados) * 60);
    aux1 = (angulo - grados);
    aux2 = ((float) min / 60.0f);
    aux1 =  (aux1 - aux2);
    seg = aux1 * 3600;
    cout << angulo << " Angulo = " << grados << " Grados, " << min << " Min, "
         << seg << " Seg" << endl;
    return 0;
}