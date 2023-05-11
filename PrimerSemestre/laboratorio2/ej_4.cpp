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

    res = pow((a-b), 2) + (b-(5*c));
    res = res / pow((d+c), 2);

    cout << "\nEl resultado de\n\n(a-b)^2 + (b-(5*c))\n---------------------"
    << endl <<"      (d+c)^2\n = " << res << endl;
    return 0;
}