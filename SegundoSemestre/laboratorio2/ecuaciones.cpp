#include <iostream>
#include <stdio.h>
#include <iomanip>
#include <math.h>
#include <windows.h>
#include <cstring>
#include <string.h>
#include <stdlib.h>
#include <conio.h>
#include <fstream>

// #define CLRSCR

using namespace std;

void gotoxy(int x, int y)
{
    HANDLE hcon;
    hcon = GetStdHandle(STD_OUTPUT_HANDLE);
    COORD dwPos;
    dwPos.X = x;
    dwPos.Y = y;
    SetConsoleCursorPosition(hcon, dwPos);
}
void cuantas_ec_in(int &num);
void marco(float z[10][11], int num);
void ingreso(float y[10][11], int num);
void solucion(float y[10][11], int num);
int main()
{
    float x[10][11];
    int n;
    system("CLS");
    cuantas_ec_in(n);
    ingreso(x, n);
    solucion(x, n);

    return (0);
}
void cuantas_ec_in(int &num)
{
    do
    {
        system("CLS");
        gotoxy(5, 5);
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
                gotoxy(12 + 8 * col, 10 + 2 * fil);
                cout << "X" << col + 1;
            }
            else if (col == num)
            {
                gotoxy(12 + 8 * col, 10 + 2 * fil);
                cout << " = ";
            }
        }
    for (fil = 0; fil < num; fil++)
        for (col = 0; col <= num; col++)
        {
            if (col < num)
                gotoxy(8 + 8 * col, 10 + 2 * fil);
            else
                gotoxy(16 + 8 * col, 10 + 2 * fil);
            cin >> y[fil][col];
        }
}

void marco(float z[10][11], int num)
{
    int fil, col, izqs = 201, ders = 187, izqi = 200, deri = 188, hor = 205, vert = 186;
    // marco
    system("CLS");
    gotoxy(8, 8);
    printf("%c", izqs);
    gotoxy(9, 8);
    printf("%c", hor);
    gotoxy(17 + 5 * num, 8);
    printf("%c", hor);
    gotoxy(18 + 5 * num, 8);
    printf("%c", ders);

    gotoxy(8, 8 + 3 * num);
    printf("%c", izqi);
    gotoxy(9, 8 + 3 * num);
    printf("%c", hor);
    gotoxy(17 + 5 * num, 8 + 3 * num);
    printf("%c", hor);
    gotoxy(18 + 5 * num, 8 + 3 * num);
    printf("%c", deri);
    // verticales
    for (fil = 0; fil <= (8 + 3 * num - 1) - 9; fil++)
    {
        gotoxy(8, 9 + fil);
        printf("%c", vert);
        gotoxy(18 + 5 * num, 9 + fil);
        printf("%c", vert);
        gotoxy(12 + 5 * num, 9 + fil);
        printf("%c", vert);
    }
    // despliegue de la matriz
    for (fil = 0; fil < num; fil++)
        for (col = 0; col <= num; col++)
        {
            if (col < num)
                gotoxy(10 + 5 * col, 9 + 3 * fil);
            else
                gotoxy(14 + 5 * col, 9 + 3 * fil);
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