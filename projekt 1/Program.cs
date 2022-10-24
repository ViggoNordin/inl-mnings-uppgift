
{
 

Random rd = new Random();
int randnum = rd.Next(1,101);
int tal; 
int lägsta = 1;
int högsta = 100;
tal=  lägsta + högsta+1;
int antalgis= 0;

 while(tal!= randnum)
{
    Console.WriteLine("Gissa talet mellan 1 och 100");
    tal = Int32.Parse(Console.ReadLine());
if(randnum<tal)
    Console.WriteLine("Lägre");
 
else if(randnum>tal)
     Console.WriteLine("Högre");
 
 antalgis++;
}

  Console.WriteLine("Du hade rätt");
  Console.WriteLine("Antalgissningar"+antalgis);

}