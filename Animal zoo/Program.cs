 
class Zoo{
public List<Animal> animals;
 
public Zoo(){
animals = new List<Animal>();
}
 
public void greetAnimals(){
foreach (Animal x in animals){
  x.greeting();
}
}
public void addAnimal(Animal y){
animals.Add(y);
}
public void removeAnimal(int z){
  animals.RemoveAt(z);
}
public Animal firstAnimal(){
  Console.WriteLine(animals[0]);
  return animals[0];
}
 
}
 
abstract class Animal{
public string name;
public int age;
public abstract void greeting();
}
 
abstract class Bug :Animal{
public bool haswings;
 
}
 
 
class Ant :Bug{
    public override void greeting()
    {Console.WriteLine($"Hej där. Jag heter {name} och är {age} år gammal");
       
    }
   public Ant(string Antname,int Antage){
  name = Antname;
  age = Antage;
  haswings=false;
  
}
}
 
abstract class Mamal :Animal{
public bool isNocturnal;
public bool isAsleep;
}
 
class Cat :Mamal{
 
   public override void greeting()
    {Console.WriteLine($"Hej där. Jag heter {name} och är {age} år gammal");
       
    }
public Cat(string kattnamn,int kattålder){
  name = kattnamn;
  age = kattålder;
  isNocturnal = true;
}
}
 
abstract class Bird : Animal{
public bool canFly;
public void fly(int meter){
  Console.WriteLine(meter);
}
}
 

class Penguin :Bird{
 public override void greeting()
    {Console.WriteLine($"Hej där. Jag heter {name} och är {age} år gammal");
       
    }
     public Penguin(string Penguinnamn,int Penguinålder){
  name = Penguinnamn;
  age = Penguinålder;
  canFly = false;

}
}
 
class Parrot : Bird{
   public override void greeting()
    {Console.WriteLine($"Hej där. Jag heter {name} och är {age} år gammal");
       
    }
public void Speak(string Parrotspeak){
 Console.WriteLine(Parrotspeak);
  
}
     public Parrot(string Parrotnamn,int Parrotålder){
  name = Parrotnamn;
  age = Parrotålder;
  canFly = true;
}

}
class Program{
 
   static void main(){
Zoo Zoo1 = new Zoo();
    bool klar = false;
    while (klar){
    Console.Clear();
    Console.WriteLine("tryck q för att exit \n tryck a för att add \n Tryck r för att remove \n tryck f för att first");
    string väljdjur;
  switch(Console.ReadKey().KeyChar){
    case 'q':
    Console.WriteLine("Tack för besöket på mitt zoo");
    klar = true;
    break;
    case 'a':
    Console.WriteLine("Vilket djur vill du välja?(Cat, Parrot, Penguin, Ant)");
väljdjur = Console.ReadLine();
switch(väljdjur){
  case "cat":
  string animalname = Console.ReadLine();
  int animalage = Convert.ToInt32(Console.ReadLine());
  Cat nykatt = new Cat(animalname,animalage);
   Zoo1.addAnimal(nykatt);
   break;
  
  case "parrot":
  animalname = Console.ReadLine();
  animalage = Convert.ToInt32(Console.ReadLine());
  Parrot newParrot = new Parrot(animalname,animalage);
   Zoo1.addAnimal(newParrot);
   break;
    
  case "Penguin":
  animalname = Console.ReadLine();
  animalage = Convert.ToInt32(Console.ReadLine());
  Penguin newPenguin = new Penguin(animalname,animalage);
   Zoo1.addAnimal(newPenguin);
   
   break;
}
   
    break;
    case 'r':
    Console.WriteLine("skriv in det index du vill ta bort");
     int remove1 = Convert.ToInt32(Console.ReadLine());
     if(0<=remove1 && remove1 < Zoo1.animals.Count()){
     Zoo1.removeAnimal(remove1);
     }else{
      Console.WriteLine($"index {remove1} fanns inte");
     }
    break;
    case 'f':
     Zoo1.firstAnimal();
    break;
  }
 
  }
}
 
}
 
 
 