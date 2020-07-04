#include <iostream>
#include <string>

using namespace std;

class Movie {
	private:
		string title;
		string director;
		string rating;

	public:

		Movie(string aTitle, string aDirector, string aRating) {
			title = aTitle;
			director = aDirector;
			setRating(aRating);
		}

		void setRating(string aRating) {
				rating = aRating;
		}
	

};

int main() {

	Movie avengers("The Avengers", "Joss Whedon", "PG-13");

	//cout << avengers.rating << endl;

	system("pause");
	return 0;
}