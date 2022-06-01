#include <iostream>

using namespace std;

int main()
{
    //az aposztrofok közé írd be a keresett karakteredet és megmondja az ascii számát
	char character = 'x';
	int integer = character;
	cout << character << " " << static_cast<int>(character);
	cout << " " << integer << " " << static_cast<char>(integer);
}