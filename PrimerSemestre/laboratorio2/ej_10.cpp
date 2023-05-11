#include <iostream>
using namespace std;

int main(){
    double kmS = 0.0;
    const double CMxKM = 10000.0;
    cout << "Convertir kilometros a centimetros\n\nIngrese Kilometros:\n";
    cin >> kmS;
    cout << kmS << " Km equivale a: " << (kmS * CMxKM) << " cm\n";
    return 0;
}