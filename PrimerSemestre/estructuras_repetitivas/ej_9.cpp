#include<iostream>

using namespace std;
void vertical(int);
void horizontal(int);

void letra(int);
void repeter(int);

char le;

int main()
{
	cout << "Ingrese un simbolo o lentra: \n"; 
	cin>>le; 
	cout<<endl;  

    vertical(45);
    cout << endl;
    
    vertical(4); horizontal(9); vertical(13); horizontal(9); vertical(6);
    cout << endl;
    
    vertical(3); horizontal(13); vertical(9); horizontal(13); vertical(3);
    cout << endl;
    
    vertical(2); horizontal(16), vertical(5); horizontal(16); vertical(2);
    cout << endl;

    vertical(1); horizontal(18), vertical(3); horizontal(18); vertical(1);
    cout << endl;

    vertical(0); horizontal(20), vertical(1); horizontal(20); vertical(0);
    cout << endl;

    horizontal(44); vertical(0);cout << endl; horizontal(44); vertical(0); cout << endl;

//comienzo de las palabras
//primer cadena
//linea 1 de 5
    horizontal(3); letra(4); horizontal(1); letra(3); horizontal(3); letra(0); horizontal(5); letra(0); horizontal(0); letra(0); horizontal(0); letra(0); horizontal(3); letra(2); horizontal(6); vertical(0);
    cout<< endl;
//linea 2 de 5
    horizontal(5), letra(0), horizontal(3), letra(0), horizontal(5), letra(0), horizontal(0), letra(0), horizontal(3), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(2), letra(0), horizontal(5), vertical(0);
    cout<< endl;

//linea 3 de 5
    horizontal(5), letra(0), horizontal(3), letra(3), horizontal(1), letra(0), horizontal(2), letra(0), horizontal(2), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(2), letra(0), horizontal(5), vertical(0);
    cout << endl;
// linea 4 de 5
    vertical(0), horizontal(4), letra(0), horizontal(3), letra(0), horizontal(3), letra(0), horizontal(0), letra(2), horizontal(0), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(2), letra(0), horizontal(5), vertical(0);
    cout<< endl;
//linea 5 de 5
    vertical(1), horizontal(3), letra(0), horizontal(3), letra(3), horizontal(0), letra(0), horizontal(4), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(2), letra(2), horizontal(5), vertical(1);
    cout << endl;

// epaciador
    vertical(2), horizontal(39), vertical (2);
    cout<< endl;
// segunda cadena
// linea 1 de 5
    vertical(3), horizontal(4), letra(0), horizontal(3), letra(4), horizontal(0), letra(3), horizontal(1), letra(1), horizontal(3), letra(0), horizontal(0), letra(0), horizontal(4), letra(0), horizontal(0), vertical(3);
    cout<<endl;
// linea 2 de 5
    vertical(4), horizontal(2), letra(0), horizontal(0), letra(0), horizontal(2), letra(0), horizontal(2), letra(0), horizontal(0), letra(0), horizontal(4), letra(0), horizontal(0), letra(0), horizontal(2), letra(0), horizontal(1), letra(0), horizontal(2), letra(0), horizontal(0), vertical(4);
    cout<<endl;
// linea 3 de 5
    vertical(5), horizontal(0), letra(0), horizontal(2), letra(0), horizontal(1), letra(0), horizontal(0), letra(2), horizontal(0), letra(3), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(2), letra(0), horizontal(0), letra(0), horizontal(0),vertical(5);
    cout<<endl;
// linea 4 de 5

    vertical(5), letra(0), horizontal(0), letra(2), horizontal(0), letra(0), horizontal(0), letra(0), horizontal(1), letra(0), horizontal(1), letra(0), horizontal(4), letra(0), horizontal(2), letra(0), horizontal(0), letra(0), horizontal(3), letra(0), horizontal(0),vertical(6),
    cout<<endl;
//linea 5 de 5

    vertical(4), letra(0), horizontal(6), letra(1), horizontal(2), letra(0), horizontal(0), letra(3), horizontal(1), letra(0), horizontal(3), letra(1), horizontal(2), letra(0), horizontal(0), vertical(7);
    cout<<endl;
//cierre del dibujo
    repeter(14);

    return 0;
}

void repeter(int val)
{
    for (int i = 0; i<= val; i++)
    {
        if (i == 20)
            break;
        vertical(6+i), horizontal(28-i-i), vertical(9+i);
        cout<<endl;
    }
    return;
}

void letra(int val)
{
    //char l = '-';
    for (int e = 0; e<= val; e++)
    {cout << le;}
}

void vertical(int val)
{
    char l = '|';
    for (int cant =0; cant <= val; cant ++) 
        {cout << l;}
    return;
}

void horizontal(int val)
{
    char g = '=';
    for (int e = 0; e <= val; e++)
    {
        cout << g;
    }
    return;
}