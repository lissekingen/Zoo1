namespace Animalzoo;
abstract class Bug :Animal{
public bool haswings;
 
}
 
 
class Ant :Bug{
    public override void greeting()
    {Console.WriteLine($"Hi there. My name is {name} and my age is {age} years old");
       
    }
   public Ant(string Antname,int Antage){
  name = Antname;
  age = Antage;
  haswings=false;
  
}
}