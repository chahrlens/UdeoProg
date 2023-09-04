/*
12- Realizar un traductor ingles-español, el usuario deberá ingresar la palabra
en ingles y se deberá desplegar su equivalente en español pero únicamente
con las siguientes palabras:
*/
#include <iostream>
#include <string>

int main() {
    std::string palabrasIngles[] = {"word", "write", "while", "main", "dog", "cat", "boy", "girl"};
    std::string palabrasEspañol[] = {"palabra", "escribir", "mientras", "principal", "perro", "gato", "niño", "niña"};

    std::string palabraIngles;
    std::cout << "Ingrese una palabra en inglés: ";
    std::cin >> palabraIngles;

    bool traducida = false;

    for (int i = 0; i < sizeof(palabrasIngles) / sizeof(palabrasIngles[0]); i++) {
        if (palabraIngles == palabrasIngles[i]) {
            std::cout << "Traducción al español: " << palabrasEspañol[i] << std::endl;
            traducida = true;
            break;
        }
    }

    if (!traducida) {
        std::cout << "No se pudo traducir lo que ingresó." << std::endl;
    }

    return 0;
}
