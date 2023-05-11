#include <iostream> 
#include <string>
using namespace std;


int main () {
    int a, b, c;
    std::string ms = "Ingrese un valor de variable ";
    cout << ms+"a\n";
    cin >> a;
    cout << ms+"b\n";
    cin >> b;
    cout << ms+"c\n";
    cin >> c;
    cout << "El resultado de a x b x c: es = " << (a*b*c) << endl;
    return 0;
}