/*
8- Ingresar un numero en sistema de base 16 y se debe desplegar el
equivalente en sistema de base 10 y base 2. (Utilice arreglos unidimensionales)
*/

#include <iostream>
#include <string>
using namespace std;
int inputNumber(string);
int hexCharToDecimal(char);
int convertHexToDecimal(const std::string &);
std::string convertHexToBinary(const std::string &);
void convertToDecimal(const std::string &);
void convertToBinary(const std::string &);

int main()
{
    int n = 0;
    n = inputNumber("Convertir numero Hex a Binario y Decimal\nCuantos valores desea ingresar?\n->:");
    string array[n];
    for (int i = 0; i < n; i++)
    {
        cout << endl
             << "Ingrese un valor para la posición: " + to_string(i) + ":";
        cin >> array[i];
    }
    for (int i = 0; i < n; i++)
    {
        convertToDecimal(array[i]);
        convertToBinary(array[i]);
        cout << endl;
    }

    return 0;
}

int inputNumber(string msg)
{

    int n = 0, attemps = 0;
    do
    {
        cout << msg << endl;
        if (attemps)
        {
            cout << "Intente de nuevo:" << endl;
        }
        cin >> n;
        attemps++;

    } while (!n);
    return n;
}

// Función para convertir un dígito hexadecimal en su valor decimal
int hexCharToDecimal(char hexChar)
{
    if (hexChar >= '0' && hexChar <= '9')
    {
        return hexChar - '0';
    }
    else if (hexChar >= 'A' && hexChar <= 'F')
    {
        return hexChar - 'A' + 10;
    }
    else if (hexChar >= 'a' && hexChar <= 'f')
    {
        return hexChar - 'a' + 10;
    }
    return -1; // Valor inválido
}

// Función para convertir de base 16 a base 10
int convertHexToDecimal(const std::string &hex)
{
    int decimal = 0;
    int power = 1; // Potencia de 16

    // Comenzar desde el último carácter (más significativo)
    for (int i = hex.length() - 1; i >= 0; i--)
    {
        int digitValue = hexCharToDecimal(hex[i]);
        if (digitValue == -1)
        {
            std::cerr << "Error: Carácter hexadecimal no válido." << std::endl;
            return -1;
        }

        decimal += digitValue * power;
        power *= 16;
    }

    return decimal;
}

// Función para convertir de base 16 a base 2
std::string convertHexToBinary(const std::string &hex)
{
    std::string binary;
    for (char c : hex)
    {
        int digitValue = hexCharToDecimal(c);
        if (digitValue == -1)
        {
            std::cerr << "Error: Carácter hexadecimal no válido." << std::endl;
            return "";
        }

        // Convertir el valor decimal en su representación binaria de 4 bits
        for (int i = 3; i >= 0; i--)
        {
            int bit = (digitValue >> i) & 1;
            binary += std::to_string(bit);
        }
    }

    return binary;
}

// Función para convertir de base 16 a base 10 e imprimir el resultado
void convertToDecimal(const std::string &hex)
{
    int decimalValue = convertHexToDecimal(hex);
    if (decimalValue != -1)
    {
        std::cout << hex << " Base 16 equivale a " << decimalValue << " Base 10" << std::endl;
    }
}

// Función para convertir de base 16 a base 2 e imprimir el resultado
void convertToBinary(const std::string &hex)
{
    std::string binaryValue = convertHexToBinary(hex);
    if (!binaryValue.empty())
    {
        std::cout << hex << " Base 16 equivale a " << binaryValue << " Base 2" << std::endl;
    }
}