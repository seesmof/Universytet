#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <synchapi.h>
int main(int argc, char **argv)
{
  int sleep_time;
  int input;
  int failure;
  if (argc != 3)
  {
    printf("Usage: simple <sleep-time> <integer>\n");
    failure = 1;
  }
  else
  {
    sleep_time = atoi(argv[1]);
    input = atoi(argv[2]);
    printf("Thinking really hard for %d seconds...\n", sleep_time);
    Sleep(sleep_time);
    printf("We calculated: %d\n", input * 2);
    failure = 0;
  }
  return failure;
}