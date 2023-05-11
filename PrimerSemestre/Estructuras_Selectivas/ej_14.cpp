#include <iostream>

using namespace std;

int main() {
    double estatura;
    string ms;
    cout << "Ingrese una estatura en metros" << endl;
    cin >> estatura;
    if (estatura >= 1.30 && estatura <= 1.50){
        ms = "Estatura baja";
    }
    else if (estatura >= 1.51 && estatura <= 1.70){
        ms = "Estatura media";
    } else if ( estatura >= 1.71 && estatura <= 2.0){
        ms = "Estatura alta";
    } else if (estatura <= 1.30 || estatura >2.0) {
        ms = "Estatura poco creible";
    }

    cout << ms << endl;
    return 0;
}