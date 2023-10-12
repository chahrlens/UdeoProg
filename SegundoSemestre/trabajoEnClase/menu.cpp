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
void dibujo_cuadro();
void menu();
void palindromo();
void estadistica();
void promedio();
void cuantas_notas(int &num);
void ingreso_notas(int notas2[20], int num);
void encontrar_promedio(int notas2[20], int num);
void ingreso_palabra(unsigned char nombre[20], int &cont);
void verificar_pal(unsigned char nombre[20], int cont);
int main()
{
	menu();

	return (0);
}
void menu()
{
	char op;

	do
	{
		system("CLS");
		dibujo_cuadro();

		gotoxy(55, 10);
		cout << "M E N U";
		gotoxy(52, 12);
		cout << "1_Estadistica";
		gotoxy(52, 14);
		cout << "2_Palindromo";
		gotoxy(52, 16);
		cout << "s_Salir";
		gotoxy(52, 19);
		cout << "Elija una opcion:_";
		cin >> op;

		switch (op)
		{
		case '1':
			estadistica();
			break;
		case '2':
			palindromo();
			// getch();
			break;
		}
	} while (op != 's');
}

void dibujo_cuadro()
{
	int i;
	char hor = 205, ver = 186, izq1 = 201, izq2 = 200, der1 = 187, der2 = 188;
	system("color 97");
	// PARTES HORIZONTALES DEL CUADRO
	for (i = 0; i < 47; i++)
	{
		gotoxy(35 + i, 5);
		printf("%c", hor);
		gotoxy(35 + i, 25);
		printf("%c", hor);
	}
	// PARTES VERTICALES DEL CUADRO
	for (i = 0; i < 19; i++)
	{
		gotoxy(34, 6 + i);
		printf("%c", ver);
		gotoxy(82, 6 + i);
		printf("%c", ver);
	}
	// ESQUINAS
	gotoxy(34, 5);
	printf("%c", izq1);
	gotoxy(34, 25);
	printf("%c", izq2);
	gotoxy(82, 5);
	printf("%c", der1);
	gotoxy(82, 25);
	printf("%c", der2);
}
void estadistica()
{
	char op;
	do
	{
		system("CLS");
		dibujo_cuadro();
		gotoxy(50, 10);
		cout << "E S T A D I S T I C A";
		gotoxy(47, 12);
		cout << "1_Media Aritmetica";
		gotoxy(47, 14);
		cout << "2_Mediana";
		gotoxy(47, 16);
		cout << "3_Moda";
		gotoxy(47, 18);
		cout << "m_Menu";
		gotoxy(47, 20);
		cout << "Elija una opcion:_";
		cin >> op;

		switch (op)
		{
		case '1':
			promedio();
			break;
		case '2':
			gotoxy(65, 14);
			cout << "OPCION 2";
			getch();
			break;
		case '3':
			gotoxy(65, 16);
			cout << "OPCION 3";
			getch();
			break;
		}

	} while (op != 'm');
}
void promedio()
{
	int notas[20], n;
	cuantas_notas(n);
	ingreso_notas(notas, n);
	encontrar_promedio(notas, n);
	getch();
}
void cuantas_notas(int &num)
{
	float real;
	do
	{
		system("CLS");
		gotoxy(10, 5);
		cout << "CUANTAS NOTAS EN ENTERO DESEA INGRESAR (1..20):_";
		cin >> real;
		num = real;
	} while (num != real || (num < 1 || num > 20));
}
void ingreso_notas(int notas2[20], int num)
{
	float real;
	int i;
	for (i = 0; i < num; i++)
	{
		do
		{
			gotoxy(10, 8 + i);
			cout << "NOTA ENTERA__[0..100]__" << (i + 1) << ":_       ";
			gotoxy(10, 8 + i);
			cout << "NOTA ENTERA__[0..100]__" << (i + 1) << ":_";
			cin >> real;
			notas2[i] = real;
		} while (notas2[i] != real || (notas2[i] < 0 || notas2[i] > 100));
	}
}
void encontrar_promedio(int notas2[20], int num)
{
	int suma, i, promedio;
	suma = 0;
	for (i = 0; i < num; i++)
	{
		suma = suma + notas2[i];
	}
	promedio = suma / num;
	gotoxy(65, 10);
	cout << "EL PROMEDIO ES:_" << promedio << " puntos";
}

void palindromo()
{
	int i, tam;
	unsigned char palabra[20];

	for (i = 0; i < 20; i++)
		palabra[i] = '\0';

	ingreso_palabra(palabra, tam);
	verificar_pal(palabra, tam);
}

void ingreso_palabra(unsigned char nombre[20], int &cont)
{
	unsigned char tecla;
	system("CLS");
	gotoxy(10, 10);
	cout << "INGRESE UNA PALABRA SIN ESPACIOS:_";
	cont = 0;
	do
	{
		gotoxy(50 + 3 * cont, 10);
		cout << "";
		tecla = getch();
		if (tecla != 13 && tecla != 32)
		{
			gotoxy(50 + 3 * cont, 10);
			cout << tecla;
			nombre[cont] = tecla;
			cont++;
		}
	} while (tecla != 13 && cont < 20);
}

void verificar_pal(unsigned char nombre[20], int cont)
{
	int i, tam, conte;
	tam = cont / 2;
	conte = 0;
	for (i = 0; i < tam; i++)
	{
		if (nombre[i] == nombre[cont - 1 - i])
		{
			conte++;
		}
		else if (nombre[i] >= 65 && nombre[i] <= 90)
		{
			if ((nombre[i] + 32) == nombre[cont - 1 - i])
				conte++;
		}
		else if (nombre[cont - 1 - i] >= 65 && nombre[cont - 1 - i] <= 90)
		{
			if ((nombre[i]) == nombre[cont - 1 - i] + 32)
				conte++;
		}
		else if (nombre[i] == 165)
		{
			if ((nombre[i] - 1) == nombre[cont - 1 - i])
				conte++;
		}
		else if (nombre[cont - 1 - i] == 165)
		{
			if ((nombre[i]) == nombre[cont - 1 - i] - 1)
				conte++;
		}
	}
	if (conte == tam)
	{
		gotoxy(50, 12);
		cout << "LA PALABRA " << nombre << " ES UN PALINDROMO";
	}
	else
	{
		gotoxy(50, 12);
		cout << "LA PALABRA " << nombre << " NO ES UN PALINDROMO";
	}
	getch();
}