#include <iostream>

using namespace std;

int main()
{
    //az aposztrofok közé írd be a keresett karakteredet és megmondja az ascii számát
	char character = 'a';
	int integer = character;
	cout << "A keresett karakarter: \t[--- " << character << " ---]\nASCII kódja a ---> \t[--- "
	<< static_cast<int>(character)<< " ---]";
}
/*
A keresett karakarter: 	[--- a ---]
ASCII kódja a ---> 	[--- 97 ---]
*/
