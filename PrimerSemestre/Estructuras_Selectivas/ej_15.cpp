#include <iostream>
/*
15- Ingresar la estatura de un hombre adulto y desplegar un texto de acuerdo
a lo siguiente:
1.30 - - 1.50 → “Estatura baja”
1.51 - - 1.70 → “Estatura media”
1.71 - - 2.00 → “Estatura alta”
<1.30 o > 2.00→ “Estatura poco creíble”
*/
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
