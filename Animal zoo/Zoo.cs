namespace Animalzoo;
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