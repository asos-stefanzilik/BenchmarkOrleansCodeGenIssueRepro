// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkOrleansTest;

var summary = BenchmarkRunner.Run<OrleansBenchmark>();
