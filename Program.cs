int x = 1;
int[] array = new int[10];
Console.Write("do you want to define numbers?(y/n) ");
while (x!=0)
{
    string answer = Console.ReadLine();
    if (answer == "y" ||  answer =="Y")
    {
        Console.Clear();
        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.Write("enter number {0} => ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("enter number!");
                i--;
            }
        }
        Console.WriteLine("your numbers =>");
        for (int i = 0;i < 10; i++)
        {
            if(i == 9)
            {
                Console.Write(array[i]);
                break;
            }
            Console.Write(array[i]+",");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        x = 0;
        binary_tree(array);
    }
    else if(answer == "N" || answer == "n")
    {
        Console.Clear();
       array = new int[10] { 23, 13, 45, 6, 75, 3, 9, 890, 34, 37 };
        Console.WriteLine("numbers => ");
        for(int i = 0; i<10; i++)
        {
            if (i == 9)
            {
                Console.Write(array[i]);
                break;
            }
            Console.Write(array[i] + ",");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        x = 0;
        binary_tree(array);
    }
    else
    {
        Console.WriteLine("enter correct answer!");
    }
}
int[,] binary_tree(int[] random)
{
    int[,] tree = new int[10, 3];
    tree[0, 1] = random[0];
    for (int i = 0; i < 10;i++)
    {
        for(int j = 0; j < 3;j++)
        {
            // parent
            tree[i, 1] = random[i];
            //condition for children
            if (i == 8)
            {
                if (random[i + 1] > random[i])
                {
                    tree[i, 2] = random[i + 1];
                }
            }
            else if (i == 9)
            {
                tree[i, 1] = random[i];
            }
           else if (random[i + 1] > random[i])
            {
                tree[i, 2] = random[i + 1];

                if (random[i + 2] < random[i])
                {
                    tree[i, 0] = random[i + 2];
                }
            }
            else if (random[i + 1] < random[i])
            {
                tree[i, 0] = random[i + 1];

                if (random[i + 2] > random[i])
                {
                    tree[i, 2] = random[i + 2];
                }
            }
            else
                continue;
        }
    }
    for(int i = 0;i <10;i++) 
    {
        for (int j = 0;j < 3;j++) 
        {
            Console.Write(tree[i,j]+"\t");
        }
        Console.WriteLine();
    }
    return tree;
}