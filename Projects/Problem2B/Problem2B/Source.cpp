//Francisco J Risco
//z15165741
//HW#1
#include <stdio.h>
#include <math.h>
#ifdef _WIN32
#define WINPAUSE system("pause")
#endif

int main()
{

	clock_t start, end;
	double cpu_time;
	start = clock();

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

	end = clock();
	cpu_time = ((double)(end - start)) / CLOCKS_PER_SEC;

	fprintf("%f", cpu_time);

	return 0;
}