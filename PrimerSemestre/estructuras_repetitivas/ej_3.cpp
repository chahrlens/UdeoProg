#include <iostream> 

using namespace std;


int main(){
    cout << "Ingrese un numero entero:\n";
    int n = 0, sum = 0;

    cin >> n;

    for (int i = n; i >0; i--) {
        if (not(i % 2)){
            sum += i;
            cout << i << "; ";
        }
    }
    cout << endl << "La sumatoria es = " << sum << endl;
    return 0;
}
