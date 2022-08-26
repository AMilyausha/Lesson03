Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
int num=1;
for (int i=0;i<n;i++)
   {
    a[i]= num*num*num;
   num++; 
    Console.WriteLine(a[i]);
   } 
  