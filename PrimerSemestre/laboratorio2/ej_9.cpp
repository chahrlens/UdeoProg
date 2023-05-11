#include <iostream>
using namespace std;

int main() {
    double km = 0.0;
    const double CMxKM = 10000.0;
    cout << "Convertir kilometros a centimetros\n\nIngrese Kilometros:\n";
    cin >> km;
    cout << km << " Km equivale a: " << (km * CMxKM) << " cm\n";
    return 0;
}