#include<iostream>
#include<string>
using namespace std;
/*Chef Class is an example of super class*/
class Chef {
	public:
		void makeChicken() {
			cout << "The chef makes yummy chicken" << endl;
		}
		void makeSalad() {
			cout << "The chef makes salad" << endl;
		}
		void makeSpecialDish() {
			cout << "The chef makes bbq ribs" << endl;
		}
};

/*ItalianChef class is an example of sub class*/
class ItalianChef  : public Chef{
	public:
	    void makePasta() {
			cout << "The chef makes pasta" << endl;
		}

		/*Overwriting function*/
		void makeSpecialDish() {
			cout << "The chef makes chicken parm" << endl;
		}

};


int main() {

	Chef chef;
	chef.makeSpecialDish();

	ItalianChef italianChef;
	italianChef.makeSpecialDish();
	system("pause");
	return 0;
}