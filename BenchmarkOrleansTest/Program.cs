// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkOrleansTest;

var summary = BenchmarkRunner.Run<OrleansBenchmark>();

//var ob = new OrleansBenchmark();

//ob.GlobalSetup();

//await ob.Benchmark();

//Console.WriteLine("benchmark complete");

//ob.GlobalCleanup();

//Console.WriteLine("done");

