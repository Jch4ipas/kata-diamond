using System.Threading.Tasks.Dataflow;

Console.Write("Quelle est la taille de ton losange ? ");
var sizestring = Console.ReadLine();
int sizeint;
sizeint = Convert.ToInt32(sizestring);
int line = 1;
int gap = 1;
int espace;
espace = sizeint - 1;
int fin = 0;
int chang = 1;

if (fin == 2)
{
    //fin programme
}
if (line == 1){
    for (int i = 0; i < espace; i++){
        Console.Write(" ");
    }
    espace--;
    Console.Write("A");
    line++;
    fin++;
    Console.Write("\n");
}
while (chang == 1){
    while (line != sizeint + 1){
        for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
        espace--;
        Console.Write("B");
        for (int i = 0; i < gap; i++){
            Console.Write(" ");
        }
        Console.Write("B");
        gap = gap + 2;
        line++;
        Console.Write("\n");
    }
        chang = 2;
}
gap -= 4;
line -= 2;
espace = 1;

while (chang == 2){
    while (line != 1){
        for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
        espace++;
        Console.Write("B");
        for (int i = 0; i < gap; i++){
            Console.Write(" ");
        }
        Console.Write("B");
        gap -= 2;
        line--;
        Console.Write("\n");
    }
    chang = 3;
}
for (int i = 0; i < espace; i++){
        Console.Write(" ");
}
espace--;
Console.Write("A");
line++;
fin++;
Console.Write("\n");

