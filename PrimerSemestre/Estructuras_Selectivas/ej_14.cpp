#include <iostream>

/*El usuario debe ingresar un carácter y que despliegue si lo que se ingresó
es:
Letra minúscula
Letra mayúscula
Dígito
Carácter especial
*/
int main () {
    unsigned char letra;
    std::string ms;
    printf("Ingrese un valor: ");
    scanf("%c", &letra);

    if (letra >= 97  || letra <= 122){
        ms = "El caracter es una letra minuscula";
    }
    else if (letra >= 65 || letra <= 90){
        ms = "El caracters es una letra mayuscula";
    }
    else if (letra >= 48 || letra <= 57){
        ms = "Es un digito";
    }
    else if (letra >=0 || letra <= 255){
        ms = "Es un caracter especial";
    }
    std::cout << ms << std::endl;

    return 0;
}