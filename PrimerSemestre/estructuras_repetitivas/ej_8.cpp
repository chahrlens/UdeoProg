#include <iostream>
using namespace std;

int main() {
    unsigned char l;
    for (unsigned int i = 0; i < 255; i++){
        l = i;
        cout << "#" << i << " = " << l << endl;
    }
    return 0;
}