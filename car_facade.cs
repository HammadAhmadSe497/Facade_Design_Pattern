class CarFacade{
    private CarEngine engine;
    private CarBody body;
    private CarAccessor accessories;
    public CarFacade(){
        engine = new CarEngine();
        body = new CarBody();
        accessories = new CarAccessor();
    }
    public void createCar(string engineSize,string bodySpec, string accessoriesSpec){

engine.Engine = engineSize;
body.Body = bodySpec;
accessories.Accessories = accessoriesSpec;

    }
    public void display(){
        Console.WriteLine("---------Car is ready with following specifications--------:");
        Console.WriteLine("Engine:\t "+engine.Engine);
        Console.WriteLine("Body: \t"+body.Body);
        Console.WriteLine("Accessories: \t "+accessories.Accessories);
        Console.WriteLine();

    }
}