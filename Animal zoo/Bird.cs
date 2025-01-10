namespace Animalzoo;

abstract class Bird : Animal{
public bool canFly;
public void fly(int meter){
  Console.WriteLine(meter);
}
}
 

class Penguin :Bird{
 public override void greeting()
    {Console.WriteLine($"Hi there. My name is {name} and my age is {age} years old");
       
    }
     public Penguin(string Penguinname,int Penguinage){
  name = Penguinname;
  age = Penguinage;
  canFly = false;

}
}
 
class Parrot : Bird{
   public override void greeting()
    {Console.WriteLine($"Hi there. My name is {name} and my age is {age} years old");
       
    }
public void Speak(string Parrotspeak){
 Console.WriteLine(Parrotspeak);
  
}
     public Parrot(string Parrotname,int Parrotage){
  name = Parrotname;
  age = Parrotage;
  canFly = true;
}
}