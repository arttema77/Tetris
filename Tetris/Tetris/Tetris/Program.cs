﻿Console.SetWindowSize(40, 30);
Console.SetBufferSize(40, 30);

int x1 = 7;
int y1 = 3;
char c1 = '*';

Drow(x1, y1, c1);

static void Drow(int x, int y, char c)
{
    Console.SetCursorPosition(x, y);
    Console.Write(c);
}