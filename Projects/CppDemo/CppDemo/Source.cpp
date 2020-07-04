#include <iostream>
#include <cmath>
#include <string>

using namespace std;

void sayHi(string name, int age);

double cube(double num);

int power(int baseNum, int powNum);

int main() {
	/*User input review
	int age = 0;
	string name;

	cout << "Enter name: ";
	//cin >> name;
	getline(cin, name);
	cout << "Name entered is " << name <<endl; */

	/*Array review
	int luckyNums[20] = {4, 8, 15, 16, 23, 42};
	luckyNums[0] = 19;
	luckyNums[10] = 100;
	cout << luckyNums[10] << endl;  */

	/*Functions
	string name2;
	int age;
	cout << "Enter name: ";
	getline(cin, name2);
	cout << "Enter age: ";
	cin >> age;
	sayHi(name2, age);*/

	/*Return Function demo
	double num;
	cin >> num;
	double answer = cube(num);
	cout << num <<" cubed is " << answer << endl;*/

	/*Exponent Function
	int baseNum, powNum;
	cout << "Enter base number: ";
	cin >> baseNum;
	cout << "Enter Power Number: ";
	cin >> powNum;
	cout << baseNum << " to the " << powNum << " is " << power(baseNum, powNum)<<endl;*/

	/*2D Array & nested loops
	int numberGrid[3][2] = {
		{1,2},
		{3,4},
		{5,6}
	};

	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 2; j++) {
			cout << numberGrid[i][j];
		}
		cout << endl;
	};*/

	
	/*Pointers*/
	int age = 19;
	double gpa = 2.7;
	string name = "Mike";
	int *pAge = &age; //pointer variable
	cout << &age << endl; //will display memory address
	cout << pAge << endl; //will display memory address
	cout << *pAge << endl; //will display the value stored at that memory address via direferencing

	system("pause");
	return 0;
}

void sayHi(string name, int age) {
	cout << "Hello " << name << endl;
	cout << "Your age is " << age << endl;
}

double cube(double num) {
	return num * num * num;
}

int power(int baseNum, int powNum) {
	int result = 1;
	for (int i = 0; i < powNum; i++) {
		result = result * baseNum;
	}
	return result;
}