namespace Animalzoo;
abstract class Animal{
public string name;
public int age;
public abstract void greeting();
}
class Program{
 
   static void Main(){
    Console.ReadKey();
Zoo Zoo1 = new Zoo();
    bool klar = false;
    while (!klar){
    Console.Clear();
    Console.WriteLine("Press q for exit \n Press a to add \n Press r to remove \n Press f to see the first");
    string chooseanimal;
  switch(Console.ReadKey().KeyChar){
    case 'q':
    Console.WriteLine("Thanks for your visit");
    klar = true;
    break;
    case 'a':
    Console.WriteLine("What animal do you want to meet first?(Cat, Parrot, Penguin, Ant)");
chooseanimal = Console.ReadLine();
switch(chooseanimal){
  case "cat":
  string animalname = Console.ReadLine();
  int animalage = Convert.ToInt32(Console.ReadLine());
  Cat newcat = new Cat(animalname,animalage);
   Zoo1.addAnimal(newcat);
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
    Console.WriteLine("Write the index you want to remove");
     int remove1 = Convert.ToInt32(Console.ReadLine());
     if(0<=remove1 && remove1 < Zoo1.animals.Count()){
     Zoo1.removeAnimal(remove1);
     }else{
      Console.WriteLine($"index {remove1} does not exist");
     }
    break;
    case 'f':
     Zoo1.firstAnimal();
    break;
  }
 
  }
}
 
}
 
 
 