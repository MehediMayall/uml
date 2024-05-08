using DependencyProblem;

// Using CombustionEngine Class
CombustionEngine combustionEngine= new CombustionEngine();

Car ferrari = new Car(combustionEngine);
ferrari.Start();

/* Trying to use ElectricEngine but can't 
 It will fail to convert ElectrictEngine class to CombustionEngine
 Car class is dependent to CombustionEngine, and it will take only that type of object.
 So it's a major problem when we try to extend functionalities. We have to make changes in multiple classes.
*/


ElectricEngine electricEngine= new ElectricEngine();
Car tesla = new Car(electricEngine);
tesla.Start();

