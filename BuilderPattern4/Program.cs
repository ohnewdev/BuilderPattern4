using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 이야기 G
// 빌더 패턴
// ref : https://www.youtube.com/watch?v=aAu2wqJsUxg
namespace BuilderPattern4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Computer computer = new Computer("256g ssd", "i7", "8g");
            Computer computer = ComputerBuilder.start()
                                               .setCpu("i7")
                                               .setRam("8g")
                                               .setStorage("255g")
                                               .build();
            Console.WriteLine(computer.ToString());
            Console.ReadKey();

        }
    }


    public class Computer
    {

        private string _CPU;
        private string _RAM;
        private string _STORAGE;

        public Computer(string CPU, string RAM, string STORAGE)
        {
            _CPU = CPU;
            _RAM = RAM;
            _STORAGE = STORAGE;
        }

        public string CPU { get => _CPU; set => _CPU = value; }
        public string RAM { get => _RAM; set => _RAM = value; }
        public string STORAGE { get => _STORAGE; set => _STORAGE = value; }

        public override string ToString()
        {
            return _CPU + "," + _RAM + "," + _STORAGE;
        }



    }



    public class ComputerBuilder
    {
        private Computer computer;
        private ComputerBuilder()
        {
            computer = new Computer("defalult", "defalult", "defalult");
        }

        public static ComputerBuilder start()
        {
            return new ComputerBuilder();
        }

        public ComputerBuilder setCpu(string cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder setRam(string ram)
        {
            computer.RAM = ram;
            return this;
        }
        public ComputerBuilder setStorage(string storage)
        {
            computer.STORAGE = storage;
            return this;
        }

        public Computer build()
        {
            return this.computer;
        }
    }
}
