using BenchmarkDotNet.Running;
using Learn;
using Learn.Abstractions;
using Learn.Asyncro;
using Learn.Closures;
using Learn.Delegates;
using Learn.DependencyInjection;
using Learn.OOPprinciples;

//var obj1 = AsyncAwait.DoSomethingAsync();

//var cd = new CustomDelegates();
//cd.InstanceDelegate();

//EventArgs.Handle();

//Composition_ex1.DoWork();
//PrintLogic pl = new PrintLogic();
//pl.Composition_ex2();

//main method is called within which the instance of the class check is defined to which reads
//the value stored in the read only field and prints as output on the screen
// MAIN method:

//Check obj = new Check();
//Console.WriteLine(obj.Name);
//Console.WriteLine("Kg: {0}", obj.Kg);

//Console.ReadLine();

// INHERITANCE
//Animal a = new Animal();
//a.DoWork_WithoutKeyworkVirtualAndOverride();
//a.DoWork_WithKeyworkVirtual();

// ABSTRACT CLASS
//Learn.Abstractions.Pig p = new Learn.Abstractions.Pig();
////p.DoWork();

//Animal_withInterfaces a = new Animal_withInterfaces();
////a.DoWork();

//Cat c = new Cat();
//c.AnimalSound();


// ASYNCRO
//AsyncroServiceVar1 var1 = new AsyncroServiceVar1();
//await var1.DoWork();

//await AsyncroServiceVar4.DoWork();
//AsyncroServiceWithErrorHandling aer = new AsyncroServiceWithErrorHandling();
//await aer.DoWork();

//AsyncroServiceVar2 var2 = new AsyncroServiceVar2();
//await var2.DoWork();

//AsyncroServiceVar3 var3 = new AsyncroServiceVar3();
//var3.DoWork();

//await AsyncAwait.DoSomethingAsync();
//AsyncAwait.DoSomethingAsync1();

//ExceptionHandling eh = new ExceptionHandling();
//eh.DoWork();

//Delegates.DoWork();

//Closures2.DoWork();

//ImplicitExplicitOperators.DoWork2();

//var summary = BenchmarkRunner.Run<Benchmarker>();
//var summary = BenchmarkRunner.Run(typeof(FasterEnum));

//LazyInitialization.DoWork();

//SizeOf.DoWork();

//Polimorphism.Execute();

//var o = new Officina();
//o.Macchina1400();
//o.Macchina1600();

//MetodeVirtuale.Execute();

//Increments.Execute();
//Console.WriteLine(DelegateLambdaAnonymous.LambdaFuncTest());
await AsyncTest.AsyncAwait1();