﻿using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        HelloWorld Hello = new HelloWorld();
        Console.WriteLine(Hello.SayHi());
    }
  }
  class HelloWorld
  {
    public string SayHi(){
        string hi = "SayHi";
        return hi;
    }
  }
}