#include <stdio.h>
#include <math.h>
#ifdef _WIN32
#define WINPAUSE system("pause")
#endif

int main()
{

	unsigned int a = 1073741806;
	//We are using a Pseudo-Mersenne prime
	//P=(2^K)-C = (2^26)-5
	int p = pow(2,26) - 5;
	//Our k = 26
	//Therefore, we take the LEAST SIGNIFICANT 26 BITS

	int al = a & 0x3FFFFFF;

	//This number reprsents what comes after our LSB
	int ah = a >>  26;
	//C congruent to (2^26)mod(2^26-5), therefore our C is 5
	//We multiply it times the higher bits ah * 5
	int hb = ah * 5;
	int mod = (al + hb)-p;

	//printf("%d", al);
	//printf("\n");
	//printf("%d", al2);
	printf("\n");
	printf("%d", mod);
	printf("\n");
	system("pause");

	return 0;
}
