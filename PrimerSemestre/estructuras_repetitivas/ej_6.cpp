#include <iostream>
#include <string>

using namespace std;
bool cousingFinder(int);

int main() {
    int n = 0, count = 2, auxc = 0;
    string ms = "";
    cout << "Ingrese cuantos numeros primos desea" << endl;
    cin >> n;
    int cousings[n];
    while (auxc < n){

        if (cousingFinder(count)){
            cousings[auxc] = count;
            auxc++;
            cout << "Encontrado: " << count << endl;
        }
        count ++;
    }
    for (int i = 0; i < n; i ++ ){
        ms += "# " + std::to_string(i+1) + " = " + std::to_string(cousings[i]);
        auxc = i + 1;
        ms += (auxc % 2) ? " " : "\n";
    }
    cout << ms << endl;

    return 0;
}

bool cousingFinder(int n){
    bool isCousing = true;
    for (int i = 2; i < n; i ++){
        isCousing = isCousing && ((bool) (n % i));
    }
    return isCousing;
}