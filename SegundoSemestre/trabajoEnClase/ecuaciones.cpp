#include <iostream>
#include <stdio.h>
#include <iomanip>
#include <math.h>
#include <cstring>
#include <string.h>
#include <stdlib.h>
#include "tools.h"

using namespace std;

void cuantas_ec_in(int &num);
void marco(float z[10][11], int num);
void ingreso(float y[10][11], int num);
void solucion(float y[10][11], int num);

int main()
{
    float x[10][11];
    int n;
    // system("CLS");
    clrscr();
    cuantas_ec_in(n);
    ingreso(x, n);
    solucion(x, n);

    return (0);
}
void cuantas_ec_in(int &num)
{
    do
    {
        // system("CLS");
        clrscr();
        gotoXy(5, 5);
        cout << "CUANTAS ECUACIONES E INCONGINTAS DESEA TRABAJAR [2..10]:_";
        cin >> num;
    } while (num < 2 || num > 10);
}

void ingreso(float y[10][11], int num)
{
    int fil, col;
    // Visualizar sistema de ecuaciones
    for (fil = 0; fil < num; fil++)
        for (col = 0; col <= num; col++)
        {
            if (col < num)
            {
                numbers::gotoXy(12 + 8 * col, 10 + 2 * fil);
                cout << "X" << col + 1;
            }
            else if (col == num)
            {
                gotoXy(12 + 8 * col, 10 + 2 * fil);
                cout << " = ";
            }
        }
    for (fil = 0; fil < num; fil++)
        for (col = 0; col <= num; col++)
        {
            if (col < num)
                gotoXy(8 + 8 * col, 10 + 2 * fil);
            else
                gotoXy(16 + 8 * col, 10 + 2 * fil);
            cin >> y[fil][col];
        }
}

void marco(float z[10][11], int num)
{
    int fil, col, izqs = 201, ders = 187, izqi = 200, deri = 188, hor = 205, vert = 186;
    // marco
    // system("CLS");
    clrscr();
    gotoXy(8, 8);
    printf("%c", izqs);
    gotoXy(9, 8);
    printf("%c", hor);
    gotoXy(17 + 5 * num, 8);
    printf("%c", hor);
    gotoXy(18 + 5 * num, 8);
    printf("%c", ders);

    gotoXy(8, 8 + 3 * num);
    printf("%c", izqi);
    gotoXy(9, 8 + 3 * num);
    printf("%c", hor);
    gotoXy(17 + 5 * num, 8 + 3 * num);
    printf("%c", hor);
    gotoXy(18 + 5 * num, 8 + 3 * num);
    printf("%c", deri);
    // verticales
    for (fil = 0; fil <= (8 + 3 * num - 1) - 9; fil++)
    {
        gotoXy(8, 9 + fil);
        printf("%c", vert);
        gotoXy(18 + 5 * num, 9 + fil);
        printf("%c", vert);
        gotoXy(12 + 5 * num, 9 + fil);
        printf("%c", vert);
    }
    // despliegue de la matriz
    for (fil = 0; fil < num; fil++)
        for (col = 0; col <= num; col++)
        {
            if (col < num)
                gotoXy(10 + 5 * col, 9 + 3 * fil);
            else
                gotoXy(14 + 5 * col, 9 + 3 * fil);
            printf("%.1f", z[fil][col]);
        }
    getch();
}

void solucion(float y[10][11], int num)
{
    int fil, col, cont;
    float valor;
    marco(y, num);
    for (cont = 0; cont < num; cont++)
    {
        for (fil = cont; fil < num; fil++)
        {
            valor = y[fil][cont];
            for (col = 0; col <= num; col++)
            {
                if (fil == cont)
                {
                    y[fil][col] = y[fil][col] / valor;
                }
                if (fil > cont)
                {
                    y[fil][col] = y[fil][col] - valor * y[cont][col];
                }
            }
        }
        for (fil = 0; fil < cont; fil++)
        {
            valor = y[fil][cont];
            for (col = 0; col <= num; col++)
            {
                y[fil][col] = y[fil][col] - valor * y[cont][col];
            }
        }
        marco(y, num);
    }
}