int [] array = {1,22,43,22,55,46,34};

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
            Console.WriteLine(index);
            break;
    }
    index++; 
}