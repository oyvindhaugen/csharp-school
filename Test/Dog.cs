class Dog : Organism {
    public string name;
    public Dog() {
        name = "";
    }
    public Dog(string dogName, int dogLegs, int dogEyes) {
        name = dogName;
        this.Legs = dogLegs;
        this.Eyes = dogEyes; 
    }
    public override void sound()
    {
        Console.WriteLine("Ruff");
    }
}