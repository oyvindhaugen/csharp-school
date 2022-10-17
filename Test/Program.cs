class Organism {
    public int Eyes;
    public int Legs;
    public virtual void sound() {
        Console.WriteLine("It makes a sound");
    }
    public Organism() {}

    public void test(string test1, int test2) {
        Console.WriteLine($"Hei {test1} og {test2}");
    }
}
