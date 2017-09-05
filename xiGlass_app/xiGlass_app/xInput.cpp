#include <xinput.h>
#include Xinput9_1_0.lib

XINPUT_STATE state;
ZeroMemory(&state, sizeof(XINPUT_STATE));

if (XInputGetState(0, &state) == ERROR_SUCCESS) {

}