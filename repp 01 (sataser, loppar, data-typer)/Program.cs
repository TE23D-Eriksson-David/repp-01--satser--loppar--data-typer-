using SC = System.Console;

SC.WriteLine("Repetition av: If-satser, Loppar och data typer.");

if (6 >= 3) {
SC.WriteLine("Hello world!");
}

 
SC.WriteLine("Requesting username:");
string Username = SC.ReadLine();
SC.WriteLine("Requesting pasword:");
string Pasword = SC.ReadLine();

if (Username == "noname" && Pasword == "nopass"){
SC.WriteLine("Welcome!");
} else {
    SC.WriteLine("Wrong username or pasword");
}

for (int i = 0; i < 32; i++)
{
    SC.WriteLine("Hello, World");
}

int Iteration=1;
string Newpasword ="";

while (Newpasword != "Right"){
SC.WriteLine("Wrigt the correct password to continu.");
Newpasword = SC.ReadLine();
SC.WriteLine($"Iteration {Iteration}");
Iteration++;
}

string strNumber="";
int intNumber;
for (int i = 0; i < 5; i++)
{
    strNumber = SC.ReadLine();
    int.TryParse(strNumber, out intNumber);
    if (intNumber > 5){
        SC.WriteLine("högre än 5!");
    }
}

bool runing = false;
while (runing == false) {
try
{
    strNumber = SC.ReadLine();
runing = int.TryParse(strNumber, out intNumber);
}
catch (System.Exception)
{
    SC.WriteLine("The expresion only accepts integers");
}
}

// Har gjort det sista steget i Diagnåsen.

SC.ReadLine();