#include <iostream>
#include <string>

using namespace std;

void numPefect(int);


int main(){
    int n1 = 0, n2 = 0, count = 1, sum = 0, aux = 0;
    cout << "Ingrese un numero\n";
    cin >> n1;
    cout << "Ingrese un numero\n";
    cin >> n2;
    
    numPefect(n1);
    numPefect(n2);
    
    return 0;
}

void numPefect(int n){
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
    cout << endl << endl << endl;
}