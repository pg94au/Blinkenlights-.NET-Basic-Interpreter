# Blinkenlights-.NET-Basic-Interpreter
A simple BASIC interpreter built in C# for .NET Core using Antlr4

Based on https://github.com/pg94au/Blinkenlights-Basic-Interpreter

You can build and run this with the already generated antlr source in the Blinkenlights.Basic.Gen project.  If you wish to re-generate this source from the Basic.g4 input, you can manually perform the following steps:

```
cd Blinkenlights.Basic.Gen
java -jar ../antlr-4.12.0-complete.jar -Dlanguage=CSharp ../antlr/Basic.g4 -visitor -package Blinkenlights.Basic.Gen
```

To get the antlr jar file:

```
wget https://www.antlr.org/download/antlr-4.12.0-complete.jar
```
