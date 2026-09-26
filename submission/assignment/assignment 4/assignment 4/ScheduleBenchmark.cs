using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using BenchmarkDotNet.Configs;

namespace assignment_4
{
    [MemoryDiagnoser]
    public class ScheduleBenchmark
    {
        private string[] names = { "C# Basics", "Arrays", "Functions", "Date and Time", "Exception Handling" };
        private DateTime[] dates = {
        new DateTime(2026, 9, 10, 18, 0, 0),
        new DateTime(2026, 9, 13, 18, 0, 0),
        new DateTime(2026, 9, 17, 18, 0, 0),
        new DateTime(2026, 9, 20, 18, 0, 0),
        new DateTime(2026, 9, 24, 18, 0, 0)
    };
        private int[] durations = { 180, 240, 180, 240, 180 };

        [Params(100, 1000, 10000,100000)]
        public int Iterations { get; set; }

        [Benchmark]
        public string StringConcatenation()
        {
            string result = "";

            for (int i = 0; i < Iterations; i++)
            {
                int index = i % names.Length;
                result += $"{names[index]} - {dates[index]:dd/MM/yyyy hh:mm tt} - {durations[index]} minutes" + Environment.NewLine;
            }

            return result;
        }

        [Benchmark]
        public string StringBuilderConcatenation()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Iterations; i++)
            {
                int index = i % names.Length;
                sb.AppendLine($"{names[index]} - {dates[index]:dd/MM/yyyy hh:mm tt} - {durations[index]} minutes");
            }

            return sb.ToString();
        }
    }
}
