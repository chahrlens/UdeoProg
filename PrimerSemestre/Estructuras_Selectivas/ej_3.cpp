#include <iostream>
#include <math.h>

using namespace std;

int main() {
    double val1, val2, val3, res = 0;
    cout << "Ingrese un valor" << endl;
    cin >> val1;
    cout << "Ingrese un valor" << endl;
    cin >> val2;
    cout << "Ingrese un valor" << endl;
    cin >> val3;

    res = pow((5 * val2), 3) - (2*val1);
    res = res / pow((2*val3),2);
    cout << "El Producto de los tres es: " << res << endl;

    return 0;
}