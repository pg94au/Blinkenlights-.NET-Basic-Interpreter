using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Blinkenlights.Basic.App.Statements;

namespace Blinkenlights.Basic.App
{
    public class Interpreter
    {
        public TextReader InputReader { get; }
        public TextWriter OutputWriter { get; }
        public TextWriter ErrorWriter { get; }

        private SortedDictionary<int, IStatement> _statements;
        private Stack<int> _stack = new Stack<int>();
        private int _currentLineNumber;
        private Stack<ForState> _forStack = new Stack<ForState>();
        private Dictionary<string, int> _variables = new Dictionary<string, int>();
        private bool _running = false;

        public Interpreter(string program) : this(program, Console.In, Console.Out, Console.Error)
        {
        }

        public Interpreter(string program, TextReader inputReader, TextWriter outputWriter, TextWriter errorWriter)
            : this(ParseStatementsFromProgramText(program, outputWriter, errorWriter), inputReader, outputWriter, errorWriter)
        {
        }

        public Interpreter(SortedDictionary<int, IStatement> statements, TextReader inputReader, TextWriter outputWriter,
            TextWriter errorWriter)
        {
            _statements = statements;
            _currentLineNumber = statements.First().Key;
            InputReader = inputReader;
            OutputWriter = outputWriter;
            ErrorWriter = errorWriter;
        }

        private static SortedDictionary<int, IStatement> ParseStatementsFromProgramText(string program, TextWriter outputwriter, TextWriter errorWriter)
        {
            var programStream = new MemoryStream(Encoding.UTF8.GetBytes(program));
            var statementParser = new StatementParser();
            var statements = statementParser.Parse(programStream, outputwriter, errorWriter);

            return statements;
        }

        public void ExecuteProgram()
        {
            _running = true;

            while (_running && !Finished)
            {
                if (_statements.TryGetValue(_currentLineNumber, out var statement))
                {
                    statement.Execute(this);
                }
            }
        }

        public void Stop()
        {
            ErrorWriter.WriteLine($"! Stopped at line {_currentLineNumber}");
            _running = false;
        }

        public void End()
        {
            _currentLineNumber = Int32.MaxValue;
        }

        public bool Finished => _currentLineNumber == int.MaxValue;

        public void AdvanceLine()
        {
            var currentIndex = _statements.Keys.ToList().BinarySearch(_currentLineNumber);

            _currentLineNumber = _statements.Keys.ElementAtOrDefault(currentIndex + 1) != 0
                ? _statements.Keys.ElementAtOrDefault(currentIndex + 1)
                : int.MaxValue;
        }

        public void GotoLine(int targetLine)
        {
            if (_statements.ContainsKey(targetLine))
            {
                _currentLineNumber = targetLine;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void PopLineNumber()
        {
            if (!_stack.TryPop(out _currentLineNumber))
            {
                throw new InvalidOperationException();
            }
        }

        public void PushLineNumber()
        {
            _stack.Push(_currentLineNumber);
        }

        public ForState CreateForState(string variableName, int limit)
        {
            return new ForState(variableName, limit, _currentLineNumber);
        }

        public void PushForLoop(ForState forState)
        {
            _forStack.Push(forState);
        }

        public ForState PopForLoop()
        {
            return _forStack.Pop();
        }

        public int ReadVariable(string variableName)
        {
            return _variables[variableName];
        }

        public void WriteVariable(string variableName, int value)
        {
            _variables[variableName] = value;
        }
    }
}
