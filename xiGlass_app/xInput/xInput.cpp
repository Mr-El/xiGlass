

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#include <Xinput.h>
#include "gamepad.cpp"

using std::cout;
using std::endl;

int main()
{
	Gamepad gamepad;

	bool wasConnected = true;

	while (true)
	{
		Sleep(100);

		if (!gamepad.Refresh())
		{
			if (wasConnected)
			{
				wasConnected = false;

				cout << "Please connect an Xbox 360 controller." << endl;
			}
		}
		else
		{
			if (!wasConnected)
			{
				wasConnected = true;

				cout << "Controller connected on port " << gamepad.GetPort() << endl;
			}

			cout << "Left thumb stick: (" << gamepad.leftStickX << ", " << gamepad.leftStickY << ")   Right thumb stick : (" << gamepad.rightStickX << ", " << gamepad.rightStickY << ")" << endl;

			cout << "Left analog trigger: " << gamepad.leftTrigger << "   Right analog trigger: " << gamepad.rightTrigger << endl;

			if (gamepad.IsPressed(XINPUT_GAMEPAD_A)) cout << "(A) button pressed" << endl;
		}
	}
}