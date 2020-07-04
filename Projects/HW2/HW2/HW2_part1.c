//Francisco J Risco
//z15165741
//HW#2
#include <stdio.h>
#include <math.h>
#include <string.h>
#ifdef _WIN32
#define WINPAUSE system("pause")
#endif

typedef unsigned long long bigint192[12]; //for operands
typedef unsigned long long bigint384[24]; //for multiplication result
void bigint192_mul(bigint384 r, const bigint192 a, const bigint192 b)//implement this
{

	//bigint192 a = { 0x5139,0x8a58,0x9b81,0xf544,0x4874,0x0d09,0xc78f,0xe0a5,0xa509,0xaec5,0x2129,0xaea9 };
	//bigint192 b = { 0x0e96,0x9def,0x0b15,0x863d,0xfaf1,0x0bea,0x556d,0xd851,0x1033,0xbe1b,0x08fe,0xa9ae };
	//bigint384 r = { 0 };
	int k = 0;
	for (int i = 0; i < 12; i++) {
		for (int j = 0; j < 12; j++) {
			k = i + j;
			r[i + j] += a[i] * b[j];
			printf("%x",r[i + j]);
			printf("\n");
		};
	};
	printf("\n");
}


//void bigint384_reduce(bigint192 r, const bigint384 a);//implement this
void bigint384_reduce_barrett(bigint192 t, const bigint384 x)//compelete this
{
	bigint192 C = { 0x1716,0xdb17,0xb72a,0x5324,0x97c3,0x8ba6,0x6f28,0x4f79,0xed39,0x4a82,0xc7f8,0xe788 };
	bigint192 p = { 0xffed,0xffff,0xffff,0xffff,0xffff,0xffff,0xffff,0xffff,0xffff,0xffff,0xffff,0x7fff };
}

void bigint192_print(const bigint192 a)
{
	int i;
	printf("(");
	for (i = 0; i<11; i++)
		printf(" * 2^%d + ", a[i], 16 * i);
	printf("%llu * 2^%d)", a[i], 16 * i);
}
void bigint384_print(const bigint384 a)
{
	int i;
	printf("(");
	for (i = 0; i<23; i++) 
	printf("%llu * 2^%d + ", a[i], 16 * i);
	printf("%llu * 2^%d)", a[i], 16 * i);
}
int main(void)
{
	bigint192 pr, br;
	bigint384 r = { 0 };//initializing array
	bigint192 a = { 0x5139,0x8a58,0x9b81,0xf544,0x4874,0x0d09,0xc78f,0xe0a5,0xa509,0xaec5,0x2129,0xaea9 };
	bigint192 b = { 0x0e96,0x9def,0x0b15,0x863d,0xfaf1,0x0bea,0x556d,0xd851,0x1033,0xbe1b,0x08fe,0xa9ae };
	bigint192_mul(r, a, b);
	//bigint192_print(a);
	printf("*");
	//bigint192_print(b);
	printf("=");
	bigint384_print(r);
	//bigint384_reduce(pr, r);
	//printf("\n Pseudo_mod : ");
	//bigint192_print(pr);
	//bigint384_reduce_barrett(br, r);
	//printf("\n Barett_mod : ");
	//bigint192_print(br);
	printf("\n");

	system("pause");

	return 0;
}