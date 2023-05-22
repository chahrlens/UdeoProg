#include <iostream>
#include <string>

using namespace std;

void numPefect(int);


int main(){
    int n = 0;
    cout << "Ingrese un numero\n";
    cin >> n;
    
    for (int i = n; i > 0; i --){
        if (n % i) {
            cout << n << " No divisible en: " << i << endl;
        }
    }    
    return 0;
}