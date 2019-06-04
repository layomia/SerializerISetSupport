using System.Text.Json;
using System.Collections.Generic;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;

namespace SerializerISetSupport
{
    [JsonExporterAttribute.Full]
    [MemoryDiagnoser]
    public class ReadGenericCollection
    {
        private static readonly ISet<string> _iset = new HashSet<string>();
        private static string _jsonString;

        [Params(2, 50, 100)]
        public int ElementCount;

        [GlobalSetup]
        public void Setup()
        {
            for (int i = 0; i < ElementCount; i++)
            {
                _iset.Add($"hello{i}");
            }

            _jsonString = System.Text.Json.Serialization.JsonSerializer.ToString(_iset);
        }

        [Benchmark]
        public ISet<string> DeserializeISet()
        {
            return System.Text.Json.Serialization.JsonSerializer.Parse<ISet<string>>(_jsonString);
        }

        [Benchmark]
        public string SerializeISet_ToBytes()
        {
            return System.Text.Json.Serialization.JsonSerializer.ToString(_iset);
        }
    }

    [JsonExporterAttribute.Full]
    [MemoryDiagnoser]
    public class JsonDotNet_ReadGenericCollection
    {
    private static readonly ISet<string> _iset = new HashSet<string>();
    private static string _jsonString;

    [Params(2, 50, 100)]
    public int ElementCount;

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 0; i < ElementCount; i++)
        {
            _iset.Add($"hello{i}");
        }

        _jsonString = System.Text.Json.Serialization.JsonSerializer.ToString(_iset);
    }

    [Benchmark]
    public ISet<string> DeserializeISet()
    {
        return JsonConvert.DeserializeObject<ISet<string>>(_jsonString);
    }

    [Benchmark]
    public string SerializeISet_ToBytes()
    {
        return JsonConvert.SerializeObject(_iset);
    }
}

    public class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
