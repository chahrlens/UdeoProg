/*
9- Realizar la simulación del ingreso de password y usuario que iniciamos en
clase.
*/

#include <iostream>

using namespace std;
bool verifyPassword(const string &);
int main()
{
    bool passwordIsValid = true;
    string username, password;
    cout << "Simulador de login.\nIngrese nombre de usuario:\n";
    cin >> username;
    do
    {
        if (!passwordIsValid)
        {
            cout << "Contraseña es invalida. Intente de nuevo.\n";
        }
        cout << "\nIngrese su contraseña:\n";
        cin >> password;
        passwordIsValid = verifyPassword(password);

    } while (!passwordIsValid);
    cout << "Contraseña es valida!\n";
    return 0;
}

bool verifyPassword(const string &password)
{
    int verify;
    int opt[4];
    verify = password.length() > 8 ? 1 : 0;
    for (size_t i = 0; i < password.length(); i++)
    {
        const char word = password[i];
        if (word >= 65 && word <= 90)
        {
            // Mayúsculas
            opt[0] = 1;
        }
        else if (word >= 97 && word <= 122)
        {
            // Minúsculas
            opt[1] = 1;
        }
        else if (word >= 48 && word <= 57)
        {
            // Números
            opt[2] = 1;
        }
        else if (word >= 33 && word <= 47 || word >= 58 && word <= 63)
        {
            // Símbolos
            opt[3] = 1;
        }
    }
    for (int i = 0; i < 4; i++)
    {
        verify += opt[1];
    }
    return verify == 5;
}