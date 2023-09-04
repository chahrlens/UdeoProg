/*
1- El usuario ingrese el número de datos reales que se van a trabajar, se debe
realizar el ingreso de los mismos en un arreglo unidimensional y se deben
ordenar ascendentemente, utilice un método distinto al que se explicó en
clase.
*/

#include <iostream>
#include <string>
using namespace std;
int getNum(string);
int main (){
  int length, n;
  cout << "Defina el la cantidad de numeros que desea ingresar:" << endl;
  
  length =  getNum("Ingrese un numero");
  unsigned int arrayNumber[length];
  for (int i = 0; i < length; i++){
    n = getNum("Ingrese un numero para pos: "+std::to_string(i)); 
  }
  cout << "Se imprime la lista" << endl;
  for (int i = 0; i < length; i ++) {
    cout << "Pos: " << i << " Val: " << arrayNumber[i];
  }
  cout << "Se ordena la lista de valores" << endl;
  for (int i = 0; i < length; i++){
    for (int j = 0; j < length -1; j++) {
      int aux;
      if (arrayNumber[i] > arrayNumber[j]){
        int aux = arrayNumber[j] ;
        arrayNumber[j] = arrayNumber[i];
        arrayNumber[i] = aux;
      }  
    }
  }
  for (int i = 0; i < length; i++){
    cout << endl << "Pos: "<< i << " Val: " << arrayNumber[i] << endl;
  }
  return 0;
}

int getNum(string msg){
  int n;
  do {
    cout << msg << endl;
    cin >> n;
  } while (0 > n);
  return n;
}
