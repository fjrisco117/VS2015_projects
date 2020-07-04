#include <iostream>
#include <string>
using namespace std;

int main() {
	int fish = 5;
	cout << &fish << endl; //'&' is the memory address operator

	int *fishPointer;
	fishPointer = &fish;

	cout << fishPointer << endl; 

	system("pause");
	return 0;
}