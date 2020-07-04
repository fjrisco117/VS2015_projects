#include<iostream>
using namespace std;
void passByValue(int x);
void passByReference(int *x);

int main() {

	int betty = 13; //pass by value
	int sandy = 13; //pass by reference

	passByValue(betty);
	passByReference(&sandy);

	cout << "betty is now " << betty << endl;
	cout << "sandy is now " << sandy << endl;

	system("pause");
	return 0;
}

void passByValue(int x) { //when passing by value, you are passing a copy
	x = 99;
}

void passByReference(int *x) { //when passing by reference, you are 
	                           //passing a variable's address
	*x = 66;  //dereferencing *&sandy 
}