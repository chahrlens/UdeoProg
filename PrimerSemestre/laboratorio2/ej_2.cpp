#include <iostream>
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

    res = ((3*a) - (5*b));
    res = res / (2*c);

    cout <<  "El resultado de:\n(3 * a) - (5 * b)\n------------------\n(2 * c)\n\n = " << res << endl;
    return 0;
}