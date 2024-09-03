using static System.Console;
using static System.Convert;
using static System.Math;


int n,messages=0;
int[] arr1 = new int[1001];

n = ToInt32(ReadLine());
string str = ReadLine();
string[] arr2 = str.Split(" ");


for(int i = 0; i < n; i++)
{
    arr1[i] = ToInt32(arr2[i]);
}
for (int  j= n-1;  j>=0; j--)
{
    if (arr1[j] == 1)
    {
        messages++;
    }
    else
    {
        if (messages > 0)
        {
            if (j != 0)
            {
                if (arr1[j - 1] == 1)
                {
                    messages ++;
                }
            }
       
        }
    }
}

WriteLine(messages);