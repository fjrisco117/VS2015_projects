#include <stdio.h>
typedef unsigned long long bigint192[12];
typedef unsigned long long bigint384[24];
typedef unsigned long long bigintmm;
bigint192 p = { 0xFFED,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0xFFFF,0x7FFF };

void bigint192_print(const bigint192 a) {
	int i;
	printf("(");
	for (i = 0; i<11; i++)
		printf("%llu * 2^%d + ", a[i], 16 * i);
	printf("%llu * 2^%d)", a[i], 16 * i);
}
void bigint384_print(const bigint384 a) {
	int i;
	printf("(");
	for (i = 0; i<23; i++)
		printf("%llu * 2^%d + ", a[i], 16 * i);
	printf("%llu * 2^%d)", a[i], 16 * i);
}
int main(void)
{
	bigintmm a=2;
	bigintmm t = a;
	a = a * 1;
	a = (a*a);
	a = (a*a)*t;
	a = a*a;/*
	a = (a*a)*t;
	a = (a*a)*t;
	a = (a*a)*t;
	a = (a*a);
	a = (a*a);*/

	printf(a);



	

	return 0;
}