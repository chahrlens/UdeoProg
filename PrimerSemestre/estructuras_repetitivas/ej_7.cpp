#include <iostream>
#include <string>

using namespace std;

bool cousingFinder(int);

int main(){
    int n = 1, count = 2, aux = 1;
    bool isCousing = true;
    cout << "Numeros no primos, cuantos desea?" << endl;
    cin >> n;
    int cousings[n];
    if (n < 1){return 1;}
    cousings[0] = 1;
    while (aux < n){
        if (!(cousingFinder(count))){
            cousings[aux] = count;
            aux ++;
        }
        count ++;
    }
    for (int i = 0; i < n; i++){
        cout << "No primo encontrado = " << cousings[i] << endl;
    }
    return 0;
}

bool cousingFinder(int n){
    bool isCousing = true;
    for (int i = 2; i < n; i ++){
        isCousing = isCousing && ((bool) (n % i));
    }
    return isCousing;
}