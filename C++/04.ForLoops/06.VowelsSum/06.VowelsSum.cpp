#include <iostream>
using namespace std;

int main()
{
    string word;

    cin >> word;

	int sum = 0;

	for (size_t i = 0; i < word.length(); i++)
	{
		if (word[i] == 'a')
		{
			sum++;
		}
		else if (word[i] == 'e')
		{
			sum += 2;
		}
		else if (word[i] == 'i')
		{
			sum += 3;
		}
		else if (word[i] == 'o')
		{
			sum += 4;
		}
		else if (word[i] == 'u')
		{
			sum += 5;
		}
	}

	cout << sum;
}
