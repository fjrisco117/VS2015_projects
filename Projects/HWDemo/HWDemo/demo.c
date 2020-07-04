//Francisco J Risco
//z15165741
//HW#2

#include <time.h>
#include <stdio.h>
#include <math.h>
#ifdef _WIN32
#define WINPAUSE system("pause")
#endif

typedef unsigned long long bigint192[12]; //for operands
typedef unsigned long long bigint384[24]; //for multiplication result
void bigint192_karatsuba_mul(bigint384 r, const bigint192 a, const bigint192 b)//complete this function
{
	int i, j;

	clock_t start, end;
	long long cycles;
	cycles = 0;

		long long ma[6] = {0};
		long long mb[6] = {0};
		long long z2[12] = {0};
		long long z1[12] = {0};
		long long z0[12] = {0};
		//initialize arrays to “0” here

		//low multiplication z0

		for (i = 0; i<2; i++) {
			start = clock();

		for (i = 0; i < 6; i++) {
			for (j = 0; j < 6; j++) {
				z0[i + j] += a[i] * b[j];
				//compute z0 = a[0-5]*b[0-5] using product scanning method			
			};
		};

		//high multiplication z2

		for (i = 0; i < 6; i++) {
			for (j = 0; j < 6; j++) {
				z2[i + j] += a[i + 6] * b[j + 6];
				//compute z2 = a[6-11] * b[6-11] using product scanning method			
			};
		};

		//compute (a1 + a2) and (b1 + b2)
		for (i = 0; i<6; i++) {
			ma[i] = a[i] + a[i + 6];
			mb[i] = b[i] + b[i + 6];
		};


		//middle multiplication z1
		for (i = 0; i < 6; i++) {
			for (j = 0; j < 6; j++) {
				z1[i + j] += (ma[i] * mb[j]);
				//compute z1 using product scanning method: z1 = (ma[0-5] * mb[0-5])
			};
		};

		//perform subtraction z1 = z1 - z0 - z2
		for (i = 0; i<12; i++) {
			z1[i] = z1[i] - z0[i] - z2[i];
		};

		//implement final addition based on Figure 1 and put the result in r
		//r[0-5]=z0[0-5]	
		for (i = 0; i < 6; i++) {
			r[i] = z0[i];
		};
		//r[6-11]=z0[6-11]+z1[0-5]
		for (i = 0; i < 6; i++) {
			r[i + 6] = z0[i + 6] + z1[i];
		};
		//r[12-17]=z1[6-11]+z2[0-5]
		for (i = 0; i < 6; i++) {
			r[i + 12] = z1[i + 6] + z2[i];
		};
		//r[18-23]=z2[6-11]
		for (i = 0; i < 6; i++) {
			r[i + 18] = z2[i + 6];
		};
		end = clock();
		cycles += (end - start);
		};
	printf("cycles = %0.f cycles\n", (double)(cycles) * 1200000000 / (CLOCKS_PER_SEC * 5));
}

void bigint384_reduce(bigint192 pr, const bigint384 r)
{
	int i; //counter

		   //reduction modulo Pseudo-Mersenne prime
		   //p=(2^191)-51
		   //The field elements are represented in radix-2^16
		   //So, we split the multiplication result into two parts based on this radix.
		   //We need to decompose based on 2^191
		   //The best result is 2^192, 192=12x16. Therefore;
		   //(2^191)-51 = (2^192)-102, (2^192)=102

		   //We need to multiply the upper half or r[] with 102 and add it to the lower half r[]

	for (i = 0; i<12; i++) {
		pr[i] = pr[i] + r[12 + i] * 102;
	};

	for (i = 0; i<11; i++) {
		pr[i + 1] += pr[i] >> 16;
		pr[i] &= 0xFFFF;
	};

	pr[0] += (pr[11] >> 16) * 102;
	pr[11] &= 0xFFFF;

	for (i = 0; i<11; i++) {
		pr[i + 1] += pr[i] >> 16;
		pr[i] &= 0xFFFF;
	};

}

void bigint192_print(const bigint192 a)
{
	int i;
	printf("(");
	for (i = 0; i<11; i++)
		printf("%llu * 2^%d + ", a[i], 16 * i);
	printf("%llu * 2^%d)", a[i], 16 * i);
}

void bigint384_print(const bigint384 a)
{
	int i;
	printf("(");
	for (i = 0; i<23; i++) printf("%llu * 2^%d + ", a[i], 16 * i);
	printf("%llu * 2^%d)", a[i], 16 * i);
}

int main(void)

{
	bigint192 pr;
	bigint384 r;
	bigint192 a = { 0x5139,0x8a58,0x9b81,0xf544,0x4874,0x0d09,0xc78f,0xe0a5,0xa509,0xaec5,0x2129,0xaea9 };
	bigint192 b = { 0x0e96,0x9def,0x0b15,0x863d,0xfaf1,0x0bea,0x556d,0xd851,0x1033,0xbe1b,0x08fe,0xa9ae };
	bigint192_karatsuba_mul(r, a, b);
	bigint192_print(a);
	printf("*");
	bigint192_print(b);
	printf("=");
	bigint384_print(r);
	bigint384_reduce(pr, r);
	printf("\n Pseudo_mod:");
	bigint192_print(pr);
	printf("\n");
	return 0;
}
