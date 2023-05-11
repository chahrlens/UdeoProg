#include <iostream>
#include <math.h>

using namespace std;

int main() {
    double a = 0, b = 0, c = 0, d = 0, res = 0;
    cout << "Ingrese un valor" << endl;
    cin >> a;
    cout << "Ingrese un valor" << endl;
    cin >> b;
    cout << "Ingrese un valor" << endl;
    cin >> c;
    cout << "Ingrese un valor" << endl;
    cin >> d;
    res = pow(b,3) + pow((a+3), 4);
    res = res / ((3*c)+pow((2*d),2));
    res = sqrt(res);
    cout << "El Producto de los cuatro es: " << res << endl;

    return 0;
}