#include <iostream>
using namespace std;

int main () {
    double grados = 0.0,  angulo = 0.0;
    cout << "Convertir Angulo a radinaes\n"
    << "Ingrese angulo en grados" << endl;

    cin >> grados;

    angulo = (grados*(3.141592654)) / 180;

    cout << "El angulo de " << grados << " grados equivale a "
         << angulo << " radianes\n";

    return 0;
}