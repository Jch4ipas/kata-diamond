using System.Threading.Tasks.Dataflow;

Console.Write("Veuillez entrez une lettre ? ");
var sizestring = Console.ReadLine();
if (string.IsNullOrEmpty(sizestring) || sizestring.Length > 1 || !char.IsLetter(sizestring[0]))
{
    Console.WriteLine("Veuillez entrer une seule lettre !");
    return;
}

char character = char.Parse(sizestring); // pour savoir si lettre est majuscule ou minuscule avec la ligne de dessous
bool letterlower = char.IsLower(character);

char maxChar = char.ToUpper(sizestring[0]); // Convertir en majuscule pour uniformiser
int sizeint = maxChar - 'A'; // Calculer la taille en fonction de la position de la lettre
int line = 1;
int gap = 1;
int espace;
espace = sizeint;
int fin = 0;
int chang = 1;

if (maxChar == 'A')
{
    if (letterlower){
        Console.Write("a");
        Console.Write("\n");
        return;
    }
    else if (!letterlower) {
    Console.Write("A");
    Console.Write("\n");
    return;
    }
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
for (int n = 0; n < sizeint; n++){
        for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
        espace--;
    char currentChar = (char)('A' + line - 1);
        Console.Write(currentChar);
        for (int i = 0; i < gap; i++){
            Console.Write(" ");
        }
        Console.Write(currentChar);
        gap = gap + 2;
        line++;
        Console.Write("\n");
    }
        chang = 2;
gap -= 4;
line -= 2;
espace = 1;

for (int n = 0; n < sizeint - 1; n++){
        for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
        espace++;
    char currentChar = (char)('A' + line - 1);
        Console.Write(currentChar);

        for (int i = 0; i < gap; i++){
            Console.Write(" ");
        }
        Console.Write(currentChar);

        gap -= 2;
        line--;
        Console.Write("\n");
}
for (int i = 0; i < espace; i++){
        Console.Write(" ");
}
espace--;
Console.Write("A");
line++;
fin++;
Console.Write("\n");

