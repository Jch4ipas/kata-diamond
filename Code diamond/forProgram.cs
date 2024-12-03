Console.Write("Quelle est la taille de ton losange ? ");
var sizestring = Console.ReadLine();
if (string.IsNullOrEmpty(sizestring) || sizestring.Length > 1 || !char.IsLetter(sizestring[0]))
{
    Console.WriteLine("Veuillez entrer une seule lettre !");
    return;
}
char maxChar = char.ToUpper(sizestring[0]); // Convertir en majuscule pour uniformiser
int sizeint = maxChar - 'A' + 1; // Calculer la taille en fonction de la position de la lettre
int line = 1;
int gap = 1;
int espace;
espace = sizeint - 1;
int chang = 1;

for (int i = 0; i < espace; i++){
    Console.Write(" ");
}
espace--;
Console.Write("A");
line++;
Console.Write("\n");
for (;chang == 1;){
    for (; line != sizeint + 1; line++){
        for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
        espace--;
        char currentChar = (char)('A' + line - 1); // Lettre courante
        Console.Write(currentChar);
        for (int i = 0; i < gap; i++){
            Console.Write(" ");
        }
        Console.Write(currentChar);
        gap = gap + 2;
        Console.Write("\n");
    }
        chang = 2;
}
gap -= 4;
line -= 2;
espace = 1;

for (;chang == 2;){
    for (; line != 1; line--){
        for (int i = 0; i < espace; i++){
            Console.Write(" ");
        }
        espace++;
        char currentChar = (char)('A' + line - 1); // Lettre courante
        Console.Write(currentChar);

        for (int i = 0; i < gap; i++){
            Console.Write(" ");
        }
        Console.Write(currentChar);

        gap -= 2;
        Console.Write("\n");
    }
    chang = 3;
}
for (int i = 0; i < espace; i++){
        Console.Write(" ");
}
Console.Write("A");
Console.Write("\n");

