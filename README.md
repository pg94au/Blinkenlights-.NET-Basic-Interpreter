# Blinkenlights-.NET-Basic-Interpreter
A simple BASIC interpreter built in C# for .NET Core using Antlr4

Based on https://github.com/pg94au/Blinkenlights-Basic-Interpreter


To generate C# code for antlr source:

```
cd Blinkenlights.Basic.Gen
java -jar ../antlr-4.12.0-complete.jar -Dlanguage=CSharp ../antlr/Basic.g4 -visitor -package Blinkenlights.Basic.Gen
```

To get the antlr jar file:

```
wget https://www.antlr.org/download/antlr-4.12.0-complete.jar
```
