#include <stdlib.h>
#include <string>
#include <time.h>
#include <iostream>
#include <cctype>
#include <algorithm>
#include <vector>

struct Term
{
    double coefficient;
    char variable;
    int power;
};

double EQUATIONSARRAY[10][11];

std::string COUNTRIES[] = {
    "Afganistán",
    "Albania",
    "Alemania",
    "Andorra",
    "Angola",
    "Antigua y Barbuda",
    "Arabia Saudita",
    "Argelia",
    "Argentina",
    "Armenia",
    "Australia",
    "Austria",
    "Azerbaiyán",
    "Bahamas",
    "Bangladés",
    "Barbados",
    "Baréin",
    "Bélgica",
    "Belice",
    "Benín",
    "Bielorrusia",
    "Birmania",
    "Bolivia",
    "Bosnia-Herzegovina",
    "Botsuana",
    "Brasil",
    "Brunéi",
    "Bulgaria",
    "Burkina Faso",
    "Burundi",
    "Bután",
    "Cabo Verde",
    "Camboya",
    "Camerún",
    "Canadá",
    "Catar",
    "Chad",
    "Chile",
    "China",
    "Chipre",
    "Colombia",
    "Comoras",
    "Congo",
    "Corea del Norte",
    "Corea del Sur",
    "Costa de Marfil",
    "Costa Rica",
    "Croacia",
    "Cuba",
    "Dinamarca",
    "Dominica",
    "Ecuador",
    "Egipto",
    "El Salvador",
    "Emiratos Árabes Unidos",
    "Eritrea",
    "Eslovaquia",
    "Eslovenia",
    "España",
    "Estados Unidos",
    "Estonia",
    "Esuatini",
    "Etiopía",
    "Filipinas",
    "Finlandia",
    "Fiyi",
    "Francia",
    "Gabón",
    "Gambia",
    "Georgia",
    "Ghana",
    "Granada",
    "Grecia",
    "Guatemala",
    "Guinea",
    "Guinea Ecuatorial",
    "Guinea-Bisáu",
    "Guyana",
    "Haití",
    "Honduras",
    "Hungría",
    "India",
    "Indonesia",
    "Irak",
    "Irán",
    "Irlanda",
    "Islandia",
    "Islas Marshall",
    "Islas Salomón",
    "Israel",
    "Italia",
    "Jamaica",
    "Japón",
    "Jordania",
    "Kazajistán",
    "Kenia",
    "Kirguistán",
    "Kiribati",
    "Kosovo",
    "Kuwait",
    "Laos",
    "Lesoto",
    "Letonia",
    "Líbano",
    "Liberia",
    "Libia",
    "Liechtenstein",
    "Lituania",
    "Luxemburgo",
    "Macedonia del Norte",
    "Madagascar",
    "Malasia",
    "Malaui",
    "Maldivas",
    "Malí",
    "Malta",
    "Marruecos",
    "Mauricio",
    "Mauritania",
    "México",
    "Micronesia",
    "Moldavia",
    "Mónaco",
    "Mongolia",
    "Montenegro",
    "Mozambique",
    "Namibia",
    "Nauru",
    "Nepal",
    "Nicaragua",
    "Níger",
    "Nigeria",
    "Noruega",
    "Nueva Zelanda",
    "Omán",
    "Países Bajos",
    "Pakistán",
    "Palaos",
    "Palestina",
    "Panamá",
    "Papúa Nueva Guinea",
    "Paraguay",
    "Perú",
    "Polonia",
    "Portugal",
    "Reino Unido",
    "República Centroafricana",
    "República Checa",
    "República Democrática del Congo",
    "República Dominicana",
    "Ruanda",
    "Rumania",
    "Rusia",
    "Samoa",
    "San Cristóbal y Nieves",
    "San Marino",
    "San Vicente y las Granadinas",
    "Santa Lucía",
    "Santo Tomé y Príncipe",
    "Senegal",
    "Serbia",
    "Seychelles",
    "Sierra Leona",
    "Singapur",
    "Siria",
    "Somalia",
    "Sri Lanka",
    "Sudáfrica",
    "Sudán",
    "Sudán del Sur",
    "Suecia",
    "Suiza",
    "Surinam",
    "Tailandia",
    "Taiwán",
    "Tanzania",
    "Tayikistán",
    "Timor Oriental",
    "Togo",
    "Tonga",
    "Trinidad y Tobago",
    "Túnez",
    "Turkmenistán",
    "Turquía",
    "Tuvalu",
    "Ucrania",
    "Uganda",
    "Uruguay",
    "Uzbekistán",
    "Vanuatu",
    "Vaticano",
    "Venezuela",
    "Vietnam",
    "Yemen",
    "Yibuti",
    "Zambia",
    "Zimbabue",

};

std::string CAPITALS[] = {
    "Kabul",
    "Tirana",
    "Berlín",
    "Andorra la Vieja",
    "Luanda",
    "Saint John",
    "Riad",
    "Argel",
    "Buenos Aires",
    "Ereván",
    "Canberra",
    "Viena",
    "Bakú",
    "Nasáu",
    "Daca",
    "Bridgetown",
    "Manama",
    "Bruselas",
    "Belmopán",
    "Porto-Novo",
    "Minsk",
    "Naipyidó",
    "Sucre",
    "Sarajevo",
    "Gaborone",
    "Brasilia",
    "Bandar Seri Begawan",
    "Sofía",
    "Uagadugú",
    "Buyumbura",
    "Thimphu",
    "Praia",
    "Nom Pen",
    "Yaundé",
    "Ottawa",
    "Doha",
    "Yamena",
    "Santiago",
    "Pekín",
    "Nicosia",
    "Bogotá",
    "Moroni",
    "Brazzaville",
    "Pionyang",
    "Seúl",
    "Yamusukro",
    "San José",
    "Zagreb",
    "La Habana",
    "Copenhague",
    "Roseau",
    "Quito",
    "El Cairo",
    "San Salvador",
    "Abu Dabi",
    "Asmara",
    "Bratislava",
    "Liubliana",
    "Madrid",
    "Washington D. C.",
    "Tallin",
    "Mbabane",
    "Adís Abeba",
    "Manila",
    "Helsinki",
    "Suva",
    "París",
    "Libreville",
    "Banjul",
    "Tiflis",
    "Accra",
    "Saint George",
    "Atenas",
    "Guatemala",
    "Conakri",
    "Malabo",
    "Bisáu",
    "Georgetown",
    "Puerto Príncipe",
    "Tegucigalpa",
    "Budapest",
    "Nueva Delhi",
    "Yakarta",
    "Bagdad",
    "Teherán",
    "Dublín",
    "Reikiavik",
    "Majuro",
    "Honiara",
    "Jerusalén",
    "Roma",
    "Kingston",
    "Tokio",
    "Amán",
    "Astaná",
    "Nairobi",
    "Biskek",
    "Tarawa",
    "Pristina",
    "Kuwait City",
    "Vientián",
    "Maseru",
    "Riga",
    "Beirut",
    "Monrovia",
    "Trípoli",
    "Vaduz",
    "Vilna",
    "Luxemburgo",
    "Skopie",
    "Antananarivo",
    "Kuala Lumpur",
    "Lilongüe",
    "Malé",
    "Bamako",
    "La Valeta",
    "Rabat",
    "Port Louis",
    "Nuakchot",
    "México",
    "Palikir",
    "Chisináu",
    "Mónaco",
    "Ulán Bator",
    "Podgorica",
    "Maputo",
    "Windhoek",
    "Yaren",
    "Katmandú",
    "Managua",
    "Niamey",
    "Abuya",
    "Oslo",
    "Wellington",
    "Mascate",
    "Ámsterdam",
    "Islamabad",
    "Melekeok",
    "Jerusalén Este",
    "Panamá",
    "Puerto Moresby",
    "Asunción",
    "Lima",
    "Varsovia",
    "Lisboa",
    "Londres",
    "Bangui",
    "Praga",
    "Kinsasa",
    "Santo Domingo",
    "Kigali",
    "Bucarest",
    "Moscú",
    "Apia",
    "Basseterre",
    "San Marino",
    "Kingstown",
    "Castries",
    "Santo Tomé",
    "Dakar",
    "Belgrado",
    "Victoria",
    "Freetown",
    "Singapur",
    "Damasco",
    "Mogadiscio",
    "Sri Jayawardenapura Kotte",
    "Pretoria",
    "Jartum",
    "Yuba",
    "Estocolmo",
    "Berna",
    "Paramaribo",
    "Bangkok",
    "Taipéi",
    "Dodoma",
    "Dusambé",
    "Dili",
    "Lomé",
    "Nukualofa",
    "Puerto España",
    "Túnez",
    "Asjabad",
    "Ankara",
    "Funafuti",
    "Kiev",
    "Kampala",
    "Montevideo",
    "Taskent",
    "Port Vila",
    "Vaticano",
    "Caracas",
    "Hanói",
    "Saná",
    "Yibuti",
    "Lusaka",
    "Harare",
};

int inputNumber(std::string);
int displayMenu(std::string options[], int);
bool comparareWords(const std::string &, const std::string &);
void spacer(int);

// Functions Menu
void displayAges();
void displayDerivatives();
std::vector<Term> differentiate(const std::vector<Term> &);
void displayEquation();

void displayCountries();
void displayGuessCapital();

int main()
{

    std::string menuOptions[] = {"Matemáticas", "Geografía", "Salir"};
    std::string mathOptions[] = {"Ecuaciones", "Edades", "Derivadas", "Regresar", "Salir"};
    std::string equationsMenu[] = {"Lineales", "Cuadráticas", "Cúbicas", "Regresar", "Salir"};
    std::string geographyOptions[] = {"Ver Países", "Adivina la Capital", "Regresar", "Salir"};
    while (true)
    {
        int option = displayMenu(menuOptions, sizeof(menuOptions) / sizeof(std::string));
        spacer(10);
        switch (option)
        {
        case 0:
        {
            option = displayMenu(mathOptions, sizeof(mathOptions) / sizeof(std::string));
            switch (option)
            {
            case 0:
            {
                option = displayMenu(equationsMenu, sizeof(equationsMenu) / sizeof(std::string));
                switch (option)
                {
                case 0:
                {
                    displayEquation();
                    break;
                }
                case 3:
                {
                    spacer(50);
                    continue;
                }
                case 4:
                    return 0;
                default:
                    break;
                }
                break;
            }
            case 1:
            {
                displayAges();
                break;
            }
            case 2:
            {
                displayDerivatives();
                break;
            }
            case 3:
            {
                spacer(50);
                continue;
            }
            case 4:
                return 0;
            default:
                break;
            }
            break;
        }
        case 1:
        {
            option = displayMenu(geographyOptions, sizeof(geographyOptions) / sizeof(std::string));
            switch (option)
            {
            case 0:
            {
                displayCountries();
                break;
            }
            case 1:
            {
                displayGuessCapital();

                break;
            }
            case 2:
            {

                spacer(50);
                continue;
            }
            case 3:
                return 0;

            default:
                break;
            }
            break;
        }
        case 2:
            return 0;
        default:
            break;
        }
    }

    return 0;
}

int inputNumber(std::string msg)
{

    int n = 0, attemps = 0;
    do
    {
        std::cout << msg << std::endl;
        if (attemps)
        {
            std::cout << "Intente de nuevo:" << std::endl;
        }
        std::cin >> n;
        attemps++;

    } while (!n);
    return n;
}

int displayMenu(std::string options[], int length)
{

    int selected = -1;

    do
    {
        for (int i = 0; i < length; i++)
        {
            std::cout << "->" << i + 1 << " " << options[i] << ":" << std::endl;
        }
        std::cin >> selected;
    } while (selected == -1);
    return selected - 1;
}

bool comparareWords(std::string &w1, std::string &w2)
{
    if (w1.length() != w2.length())
    {
        return false;
    }

    for (std::size_t i = 0; i < w1.length(); ++i)
    {
        if (std::toupper(w1[i]) != std::toupper(w2[i]))
        {
            return false;
        }
    }

    return true;
}

void spacer(int space)
{
    for (int i = 0; i < space; i++)
    {
        std::cout << std::endl;
    }
}

void displayEquation()
{
    spacer(10);
    int unknownsVar;
    double value = 0;
    // Clean Array
    for (int row = 0; row < 11; row++)
    {
        for (int col = 0; col < 10; col++)
        {
            EQUATIONSARRAY[row][col] = 0;
        }
    }


    unknownsVar = inputNumber("Ingrese numero de incógnitas en la ecuación. Min. 2, Max 10:\n ");
    unknownsVar = unknownsVar < 2 ? 2 : unknownsVar;

    //Fill array;
    for (int row = 0; row < unknownsVar; row++)
    {
        for (int col = 0; col < unknownsVar; col++)
        {
            EQUATIONSARRAY[row][col] =
                inputNumber("Ingrese un valor para la posición [" + std::to_string(row) + "][" + std::to_string(col) + "]: ");
        }
    }
    spacer(5);

    //Solution

    for (int count = 0; count < unknownsVar; count ++){
        for (int row = 0; row < unknownsVar; row ++){
            value = EQUATIONSARRAY[row][count];
            for (int col = 0; col <= unknownsVar; col++){
                if (row == count){
                    EQUATIONSARRAY[row][col] = EQUATIONSARRAY[row][col] / value;
                }
                if (row > count){
                    EQUATIONSARRAY[row][col] = EQUATIONSARRAY[row][col] - (value * EQUATIONSARRAY[count][col]);
                }
            }
        }

        for (int row = 0; row < count; row ++){
            value = EQUATIONSARRAY[row][count];
            for (int col = 0; col <= unknownsVar; col ++){
                EQUATIONSARRAY[row][col] = EQUATIONSARRAY[row][col] - (value * EQUATIONSARRAY[count][col]);
            }
        }
    }

    //Show array
    for (int row = 0; row < unknownsVar; row++)
    {
        for (int col = 0; col < unknownsVar; col++)
        {
            std::cout << "array[" + std::to_string(row) + "][" + std::to_string(col) + "] = " <<
            EQUATIONSARRAY[row][col] << std::endl;
        }
    }

    spacer(3);
}

void displayCountries()
{
    int count = 0, num = 0, length, indexes[5];

    length = sizeof(COUNTRIES) / sizeof(std::string);
    srand(time(NULL));

    do
    {
        num = rand() % length;
        bool existsIndex = false;
        for (int i = 0; i < count; i++)
        {
            existsIndex = indexes[i] == num;
            if (existsIndex)
            {
                break;
            }
        }
        if (existsIndex)
        {
            continue;
        }

        indexes[count] = num;
        count++;
    } while (count < 5);

    spacer(2);
    std::cout << "Se muestran 5 países del mundo:\n";
    for (int i = 0; i < 5; i++)
    {
        std::cout << i + 1 << ". " << COUNTRIES[indexes[i]] << std::endl;
    }
    spacer(2);
}

void displayGuessCapital()
{
    int count = 0, num = 0, length, indexes[3], tries = 0;

    length = sizeof(COUNTRIES) / sizeof(std::string);
    srand(time(NULL));

    do
    {
        num = rand() % length;
        bool existsIndex = false;
        for (int i = 0; i < count; i++)
        {
            existsIndex = indexes[i] == num;
            if (existsIndex)
            {
                break;
            }
        }
        if (existsIndex)
        {
            continue;
        }

        indexes[count] = num;
        count++;
    } while (count < 3);

    spacer(2);
    std::cout << "Adivina las capitales.\n";
    for (int i = 0; i < 3; i++)
    {
        std::string guest;
        std::cout << i + 1 << "Cual es la capital de: " << COUNTRIES[indexes[i]] << "?\n--:";
        std::string &capital = CAPITALS[indexes[i]];
        std::cin.ignore();
        std::getline(std::cin, guest);
        bool result = comparareWords(capital, guest);
        if (result)
        {
            tries++;
        }
    }
    std::cout << "Aciertos: " << tries;
    spacer(2);
}

void displayAges()
{
    spacer(20);
    const int maxAges = 20;
    int numAges;
    do
    {
        std::cout << "Ingrese cuántas edades va a ingresar (entre 1 y 20): ";
        std::cin >> numAges;
    } while (numAges < 1 || numAges > maxAges);

    int ages[numAges];
    for (int i = 0; i < numAges; ++i)
    {
        int age;
        do
        {
            std::cout << "Ingrese la edad " << i + 1 << ": ";
            std::cin >> age;

            if (age < 0)
            {
                std::cout << "La edad no puede ser menor a 0.\n";
            }
            else if (age > 110)
            {
                std::cout << "¡Atención! La edad es mayor a 110 años. Verifique si es válida.\n";
            }
        } while (age < 0 || age > 110);

        // ages.push_back(age);
        ages[i] = age;
    }

    // Ordenar las edades
    for (int i = 0; i < numAges; i++)
    {
        for (int j = 0; j < numAges - 1; j++)
        {
            if (ages[i] > ages[j])
            {
                int aux = ages[j];
                ages[j] = ages[i];
                ages[i] = aux;
            }
        }
    }

    // Categorizar y mostrar las edades
    std::cout << "\nEdades de niños (0-12 años):\n";
    for (int i = 0; i < numAges; i++)
    {
        if (ages[i] <= 12)
        {
            std::cout << ages[i] << ", ";
        }
    }

    std::cout << "\n\nEdades de adolescentes (13-18 años):\n";
    for (int i = 0; i < numAges; i++)
    {
        if (ages[i] >= 13 && ages[i] <= 18)
        {
            std::cout << ages[i] << " ";
        }
    }
    std::cout << "\n\nEdades de adultos jóvenes (19-35 años):\n";
    for (int i = 0; i < numAges; i++)
    {
        if (ages[i] >= 19 && ages[i] <= 35)
        {
            std::cout << ages[i] << ", ";
        }
    }
    std::cout << "\n\nEdades de adultos mayores (36-64 años):\n";
    for (int i = 0; i < numAges; i++)
    {
        if (ages[i] >= 36 && ages[i] <= 64)
        {
            std::cout << ages[i] << ", ";
        }
    }
    std::cout << "\n\nEdades de la tercera edad (65-110 años):\n";
    for (int i = 0; i < numAges; i++)
    {
        if (ages[i] >= 65 && ages[i] <= 110)
        {
            std::cout << ages[i] << ", ";
        }
    }
    std::cout << "\n";
    spacer(3);
}

void displayDerivatives()
{
    spacer(10);
    std::vector<Term> terms;
    std::string operation;

    std::cout << "Ingrese una función a derivar\n: ";
    std::cin.ignore();
    std::getline(std::cin, operation);

    size_t i = 0;
    while (i < operation.length())
    {
        Term term;
        term.coefficient = 1.0;

        // Leer el coeficiente
        if (operation[i] == '+' || operation[i] == '-')
        {
            term.coefficient = (operation[i] == '+') ? 1.0 : -1.0;
            i++;
        }
        else if (isdigit(operation[i]))
        {
            term.coefficient = std::stod(operation.substr(i));
            while (i < operation.length() && (isdigit(operation[i]) || operation[i] == '.'))
            {
                i++;
            }
        }

        // Leer la variable
        if (i < operation.length() && isalpha(operation[i]))
        {
            term.variable = operation[i];
            i++;
        }
        else
        {
            term.variable = 'x';
        }

        // Leer el exponente
        if (i < operation.length() && operation[i] == '^')
        {
            i++;
            term.power = std::stoi(operation.substr(i));
            while (i < operation.length() && isdigit(operation[i]))
            {
                i++;
            }
        }
        else
        {
            term.power = 1;
        }

        terms.push_back(term);

        // Buscar el siguiente termino
        while (i < operation.length() && isspace(operation[i]))
        {
            i++;
        }
    }

    // Imprimir los terminos ingresados por el usuario
    std::cout << "Términos de la ecuación ingresada:\n";
    for (const auto &term : terms)
    {
        std::cout << term.coefficient << term.variable;
        if (term.power != 1)
        {
            std::cout << '^' << term.power;
        }
        std::cout << " ";
    }
    std::cout << std::endl;

    // Calcular y mostrar la derivada
    std::vector<Term> derivative = differentiate(terms);
    std::cout << "Derivada: ";
    for (const auto &term : derivative)
    {
        std::cout << term.coefficient << term.variable;
        if (term.power != 1)
        {
            std::cout << '^' << term.power;
        }
        std::cout << " ";
    }
    spacer(3);
}

std::vector<Term> differentiate(const std::vector<Term> &terms)
{
    std::vector<Term> result;
    for (const auto &term : terms)
    {
        Term derivative;
        derivative.coefficient = term.coefficient * term.power;
        derivative.power = term.power - 1;
        derivative.variable = term.variable;
        if (derivative.power < 0)
        {
            derivative.coefficient = 0;
        }
        result.push_back(derivative);
    }
    return result;
}