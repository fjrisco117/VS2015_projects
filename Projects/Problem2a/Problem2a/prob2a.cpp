#include <stdio.h>
#include <math.h>
#ifdef _WIN32
#define WINPAUSE system("pause")
#endif

int main()
{
	//int r;

	int a = 51;
	//We are using a Mersenne prime
	//P=(2^K)-1 = (2^17)-1
	int p = pow(2, 17) - 1;

	int tmp = a;
	for (int i = 1; i < p - 2; i++) {
		tmp = tmp * a;
		tmp = tmp - (tmp / p)*p; //modulus equivalent

		}
	
	printf("%d", tmp);
	printf("\n");
	system("pause");
}
