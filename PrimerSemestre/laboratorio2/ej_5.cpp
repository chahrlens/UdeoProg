#include <iostream>
#include <math.h>

using namespace std;

int main() {
        int a = 0, b = 0, c = 0, d = 0, res = 0;
    std::string ms = "Ingrese un valor de variable ";
    cout << ms+"a\n";
    cin >> a;
    cout << ms+"b\n";
    cin >> b;
    cout << ms+"c\n";
    cin >> c;
    cout << ms+"d\n";
    cin >> d;

    res = pow(b, 3) + pow((a+3), 4);
    res = res / pow(((3*c) + (2*d)), 2);
    res = sqrt(res);

    cout << "\nEl resultado de\n\nRaiz Cuadrada de:\n(b)^+(a+3)^4\n---------------------"
    << endl <<"      ((3*c)+(2*d))^2\n = " << res << endl;
    return 0;
}