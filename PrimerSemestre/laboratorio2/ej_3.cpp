#include <iostream>
#include <math.h>
using namespace std;

int main() {
    int a = 0, b = 0, c = 0, res = 0;
    std::string ms = "Ingrese un valor de variable ";
    cout << ms+"a\n";
    cin >> a;
    cout << ms+"b\n";
    cin >> b;
    cout << ms+"c\n";
    cin >> c;

    res = pow((5*b), 3) - (2-a);
    res = res / pow((2+c), 2);

    cout << "\nEl resultado de\n(5*b)^3 - (2-a)\n---------------\n(2+c)^2\n\n    = " << res << endl;
    return 0;
}