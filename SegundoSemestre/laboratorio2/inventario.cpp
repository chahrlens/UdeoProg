#include <iostream>

using namespace std;

struct Product
{
    int code;
    string name;
    double price;
    double stock;
};

void appendProducts(Product *[], int);
void sortData(Product *[], int);
void printData(Product *[], int);

int main()
{
    int length;
    bool tried = false;

    do
    {
        if (tried)
        {
            cout << "Numero invalido. Intente de nuevo:\n";
        }
        cout << "Ingrese el largo del array: ";
        cin >> length;
        tried = length > 0 ? true : false;
    } while (!tried);

    Product* stock[length];

    //Fill data;
    for (int i = 0; i < length; i++){
        appendProducts(stock, i);
    }

    printData(stock, length);

    sortData(stock, length);

    printData(stock, length);


    return 0;
}

void appendProducts(Product *array[], int post)
{
    bool tried = false;
    cout << "\n\n\n\n\nRegistro de productos\n";

    do
    {
        int code;
        double price, stock;
        string name;

        cout << "Ingrese código: " << endl;
        cin.ignore();
        cin >> code;

        cout << "Ingrese Nombre: " << endl;
        cin.ignore();
        getline(cin, name);

        cout << "Ingrese Precio: " << endl;
        cin.ignore();
        cin >> price;

        cout << "Ingrese cantidad: " << endl;
        cin.ignore();
        cin >> stock;

        tried = ((code > 0) && (name.length() > 0) && (price > -1) && (stock > -1));
        if (tried){
            cout << "Datos incorrectos intente de nuevo: " << endl;
        } else {
            Product item = {code, name, price, stock};
            array[post] = &item;
        }

    } while (!tried);
}

void sortData(Product *array[], int length){
    for (int i = 0; i < length; i++){
        for (int j = 0; j < length -1; j++){
            if (array[i]->code > array[j]->code){
                Product *aux = array[j];
                array[j] = array[i];
                array[i] = aux;
            }
        }
    }
}

void PrintData(Product *array[], int length){
    cout << "[Código]   [Nombre]        [Precio]        [Existencias]" << endl;
    for (int i = 0; i < length; i++){
        const Product &item = *array[i];
        cout << item.code << "  " << item.name << " " << item.price << "    " << item.stock << endl;
    }
}
