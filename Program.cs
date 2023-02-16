// Write a program in C# Sharp to print the first n natural ctrber using recursion.
namespace Program;

class FirstNaturalTask{

static int FirstNatural(int strval ,int ctr){

if (ctr<1)
{
    return strval;
}

ctr--;
Console.Write (" {0} ",strval);
return FirstNatural (strval+1, ctr);

}

public static void Main (string[] args){

    FirstNatural(1,150);
}

}