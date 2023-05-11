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
    res = pow((a-b), 2) + (b- (5*c));
    res = res / pow((d+c), 2);
    cout << "El Producto de los cuatro es: " << res << endl;

    return 0;
}