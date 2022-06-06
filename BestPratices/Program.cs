// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BestPratices;
using BestPratices.BenchmarkExample;
using BestPratices.ErrorLogs;

#region Yeld Example

//var resultOld = YeldExample.GetValuesGreaterThan100Old(new List<int> { 1, 2, 3, 4, 77, 10, 88, 458, 500, 700, 1000 });
//var resultNew = YeldExample.GetValuesGreaterThan100New(new List<int> { 1, 2, 3, 4, 77, 10, 88, 458, 500, 700, 1000 }); 

#endregion

#region ObsoleteDemo

//var resultOld = ObsoleteDemo.GetValuesGreaterThan100Old(new List<int> { 1, 2, 3, 4, 77, 10, 88, 458, 500, 700, 1000 });
//var resultNew = ObsoleteDemo.GetValuesGreaterThan100New(new List<int> { 1, 2, 3, 4, 77, 10, 88, 458, 500, 700, 1000 });

#endregion

#region LinqExample

//Developers should understand that in every result set approach, the query gets executed over and over.
//In order to prevent a repetition of the execution, change the LINQ result to List after execution.

//var linQDemo = new List<int> { 1, 2, 3, 4, 77, 10, 88, 458, 500, 700, 1000 };

//Console.WriteLine(linQDemo.Count());
//Console.WriteLine(linQDemo.Average());

//var result = linQDemo.Where(i => i > 100).ToList();
//Console.WriteLine(result.Count());
//Console.WriteLine(result.Average());

#endregion

#region [Caller*] attributes and CallerArgumentExpression

//ErrorLog.RecordError("Checking from Program");

//Person p = new Person("Shanjeeva", 29, new Uri("https://github.com/shanjee/"));
//Console.WriteLine($"My age is {p.Age}");

//try
//{
//    p = new Person("Shanjeeva", 29, null);
//}

//catch (ArgumentException ae)
//{
    
//    ErrorLog.RecordError(ae.Message);
//    Console.WriteLine($"Error Occured, {ae.Message} - parameter name {ae.ParamName}");  // uncomment and see the log
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//// argument throw null
//p.SayGreeting("Good Mornning");

//p.SayGreeting(null);


#endregion

#region BenchMark

//var benchmarkResult = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
var benchmarkResultOfLinq = BenchmarkRunner.Run<LinqDemo>();

#endregion

