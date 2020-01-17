#include <string>
#include <time.h>
#include <iostream>

using namespace std;
int main()
{
	int n; //numero correspondente à quantidade 
	int length; //tamanho da pw
	cout << "Quantas Passwords quer Gerar? ";
	cin >> n; //leitura da quantidade
	cout << "Tamanho da Password? ";
	cin >> length; //leitura do tamanha
	cout << "Passwords Geradas:" << endl;
	srand(time(NULL));
	for(int i=0;i<n;i++) 
	{
		//codigo responsabel pela geração da pw
		string start_randchar_pw = "ABCDEFGHIJKLMNPQRSTUVWXYZabcdefghijklmnpqrstuvwxyz123456789!@#$%^&*";
		string nums = "123456789";
		string specials = "!@#$%^&*";
		string max = "ABCDEFGHIJKLMNPQRSTUVWXYZ";
		string min = "abcdefghijklmnpqrstuvwxyz";
		string form_pw = nums + specials + max + min;
		string password = "";
		password += start_randchar_pw[rand() % start_randchar_pw.length()];
		for (int i = 1; i < length; ++i)
		{
			password += form_pw[rand() % form_pw.length()];
		}
		cout << password << endl;
	}
	return 0;
}