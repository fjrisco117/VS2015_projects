#include "Sally.h"
#include<iostream>
using namespace std;

int main() {

	Sally sallyObject;
	Sally *sallyPointer = &sallyObject;

	sallyObject.printCrap();
	sallyPointer->printCrap();

	system("pause");
	return 0;
}