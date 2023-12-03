#pragma once
#define DllExport __declspec(dllexport)

#ifndef ADD
#define ADD

extern "C" DllExport int Add(int a, int b);

#endif // !ADD

