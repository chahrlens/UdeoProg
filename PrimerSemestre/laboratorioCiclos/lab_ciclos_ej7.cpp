 #include <iostream>
 #include <string>

using namespace std;

int main()
{
    int total = 0, product = 0, price = 0, count = 1, amountP = 0, res = 0;
    int cien = 0, cincuenta = 0, veinte = 0, diez = 0, cinco = 0, uno = 0;
    string detalle = "";
    string cambio = "";
    while (true)
    {
        cout << "Cantidad de x producto:" << endl;
        cin >> product;
        if (!product)
        {
            break;
        }
        cout << "Ingrese Precio del producto:" << endl;
        cin >> price;
        detalle = detalle + to_string(count) + "# cant " + to_string(product) + " - Producto  Sub: " + to_string(product * price) + "\n";
        total = total + (product * price);
        count++;
    }
    cout << "\nProductos que lleva" << endl
         << detalle << endl
         << "Total: " << total << endl;

    do
    {
        cout << "Ingrese pago: " << endl;
        cin >> amountP;
        if (amountP < total)
        {
            cout << "El monto ingresado es menor al total!" << endl
                 << endl;
        }
    } while (amountP < total);

    amountP -= total;
    res = amountP;

    while (amountP > 0)
    {
        if (amountP >= 100)
        {
            cien++;
            amountP -= 100;
        }
        else if (amountP >= 50)
        {
            cincuenta++;
            amountP -= 50;
        }
        else if (amountP >= 20)
        {
            veinte++;
            amountP -= 20;
        }
        else if (amountP >= 10)
        {
            diez++;
            amountP -= 10;
        }
        else if (amountP >= 5)
        {
            cinco++;
            amountP -= 5;
        }
        else if (amountP >= 1)
        {
            uno++;
            amountP -= 1;
        }
    }

    cambio += (cien      > 0 ) ? to_string(cien)      + " x Q. 100.00\n"   : "";
    cambio += (cincuenta > 0 ) ? to_string(cincuenta) + " x Q. 50.00\n"    : "";
    cambio += (veinte    > 0 ) ? to_string(veinte)    + " x Q. 20.00\n"    : "";
    cambio += (diez      > 0 ) ? to_string(diez)      + " x Q. 10.00\n"    : "";
    cambio += (cinco     > 0 ) ? to_string(cinco)     + " x Q. 5.00\n"     : "";
    cambio += (uno       > 0 ) ? to_string(uno)       + " x Q. 1.00\n"     : "";
    
    cout << "Su cambio en billetes es:\n"
         << cambio << endl
         << "Q. " << res << ".00" << endl;
    return 0;
}