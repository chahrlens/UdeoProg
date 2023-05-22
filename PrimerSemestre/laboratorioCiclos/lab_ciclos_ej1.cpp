#include <iostream>
#include <string>

using namespace std;

int main(){
    int n = 0, count = 1, sum = 0, aux = 0;
    cout << "Ingrese un numero\n";
    cin >> n;
    int count = 1, sum = 0, aux = 0;
    aux = n;
    while (count < n){
        if (not(n % count)){
            sum += count;
            cout << "Divisor " << count << endl;
        }

        count ++;
    }
    if (sum == aux ){
        cout << n << " Es un numero perfecto";
    }
    else {
        cout << n << " No es un numero perfecto";
    }
    return 0;
}
