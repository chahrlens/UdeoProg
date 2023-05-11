#include <iostream>
#include <string>
using namespace std;

int main () {
   int n = 0;
   string ms = "";
   cout << "Ingrese un numero:" << endl;
   cin >> n;
   while (n > 1)
   {
      bool isCousing = true;
      for (int i = 2; i < n; i ++){
         isCousing = isCousing && ((bool) (n % i));
      }
      ms = isCousing ? " es primo" : " no es primo";

      cout << "El numero: " <<  n << ms << endl << endl;
      n --;

   }
   
   return (0);    
}