#include <iostream>
using namespace std;

class Base {
public:
	 virtual void Print() {
		cout << "Inside Base" << endl;
	}
};

class Derived : public Base {
public:
	void Print() override {
		cout << "Inside Derived" << endl;
	}
};

class Derived2 : public Derived {
public:
	void Print() override {
		cout << "Inside Derived2" << endl;
	}
};

int main()
{
	Base b;
	Derived2 d;
	b.Print();
	d.Print();

	Base &be = d;
	Derived &de = d;
	be.Print();
	de.Print();

	Base* bp = new Derived2();
	Derived* dp = new Derived2();
	bp->Print();
	dp->Print();

	//auto* ap = new Derived();
	//ap->Print();

	system("pause");

	return 0;
}
