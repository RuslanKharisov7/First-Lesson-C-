int N = new Random().Next(-10, 20);
int M = -N;
while (M<N)
{
  Console.WriteLine(M);
  M = M + 1;
}