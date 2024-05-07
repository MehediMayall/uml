using DependencySolutions;

// Using CombustionEngine Class
CombustionEngine combustionEngine= new CombustionEngine();

Car ferrari = new Car(combustionEngine);
ferrari.Start();

// Using ElectrictEngine Class
ElectricEngine electricEngine= new ElectricEngine();
Car tesla = new Car(electricEngine);
tesla.Start();

