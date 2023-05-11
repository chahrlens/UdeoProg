#include <iostream>
#include <string>

using namespace std;

int main(){
    int n = 0;
    string ms = "";
    cout << "Ingrese un numero entero" << endl;
    cin >> n;
    ms = std::to_string(n) + " No se divide con: ";
    for (int i = n; i > 0; i --){
        if (n %i){
            ms += std::to_string(i) + ", ";
        }
    }
    cout << ms << endl;
    return 0;
}