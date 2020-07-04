#include<iostream>
#include<string>
using namespace std;

class BuckyClass {
	public:					//access specifier

		BuckyClass(string z) {
			setName(z);
			//cout << " This will get printed automatically" << endl;
		}
		void setName(string x) {
			name = x;
		}
		string getName() {
			return name;
		}
		/*
		void coolSaying() {
			cout << "preaching to the choir" << endl;
		}*/
	private:
		string name;
		
};


int main() {

	BuckyClass bo("Lucky Bucky Roberts");
	cout << bo.getName() << endl;

	BuckyClass bo2("Sally McSalad");
	cout << bo2.getName();
	/*
	BuckyClass  buckysObject;	
	buckysObject.setName("Sir Bucky Wallace ");
	cout << buckysObject.getName() << endl;
	//buckysObject.coolSaying();*/
	cout << endl;
	system("pause");
	return 0;
}