namespace Animalzoo;
abstract class Mamal :Animal{
public bool isNocturnal;
public bool isAsleep;
}
 
class Cat :Mamal{
 
   public override void greeting()
    {Console.WriteLine($"Hi there. My name is {name} and my age is {age} years old");
       
    }
public Cat(string catname,int catage){
  name = catname;
  age = catage;
  isNocturnal = true;
}
}