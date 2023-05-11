#include <iostream>

using namespace std;

int main() {
    double val1, val2, val3, res = 0;
    cout << "Ingrese un valor" << endl;
    cin >> val1;
    cout << "Ingrese un valor" << endl;
    cin >> val2;
    cout << "Ingrese un valor" << endl;
    cin >> val3;

    res = (3 * val1) - (5*val2);
    res = res / (2*val3);
    cout << "El Producto de los tres es: " << res << endl;

    return 0;
}