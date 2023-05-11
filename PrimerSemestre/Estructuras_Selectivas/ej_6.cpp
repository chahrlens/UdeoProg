#include <iostream>
#include <math.h>
#define _USE_MATH_DEFINES

using namespace std;

int main() {
    double angulo = 0, radianes = 0;
    cout << "Ingrese un valor para un angulo" << endl;
    cin >> angulo;
    radianes = (angulo * M_PI ) / 180;
    cout << endl << angulo << " Grados equivale a: " << (radianes) << endl;

    return 0;
}