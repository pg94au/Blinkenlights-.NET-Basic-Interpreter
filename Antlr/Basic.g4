grammar Basic;

program : (line NEWLINE | NEWLINE)* ;

line : lineNum statement ;

// ProgramVisitor
lineNum : INT ;
statement : endStatement
          | forStatement
          | gosubStatement
          | gotoStatement
          | ifStatement
          | inputStatement
          | letStatement
          | nextStatement
          | printStatement
          | returnStatement
          ;
endStatement : 'END' ;
forStatement : 'FOR' VARNAME '=' INT 'TO' INT ;
gosubStatement : 'GOSUB' INT ;
gotoStatement : 'GOTO' INT ;
ifStatement : 'IF' equation 'THEN' INT ;
inputStatement : 'INPUT' VARNAME ;
letStatement : 'LET' VARNAME '=' expression ;
nextStatement : 'NEXT' VARNAME ;
printStatement : 'PRINT' arg (argSeparator arg)* ;
returnStatement : 'RETURN' ;

// PrintArgumentVisitor
arg : QUOTED_STRING # printQuotedString
    | expression # printExpression
    | VARNAME # printVariable
    ;
argSeparator : (','|';') ;

// ExpressionVisitor
expression : INT # value
           | VARNAME # variable
           | expression '*' expression # multiplication
           | expression '/' expression # division
           | expression '+' expression # addition
           | expression '-' expression # subtraction
           | '(' expression ')' # parentheses
           ;

// EquationVisitor
equation : expression '==' expression # equals
         | expression '!=' expression # doesNotEqual
         | expression '>' expression # greaterThan
         | expression '<' expression # lessThan
         | expression '>=' expression # greaterThanOrEqual
         | expression '<=' expression # lessThanOrEqual
         ;

VARNAME : [a-zA-Z][a-zA-Z0-9_]* ;
QUOTED_STRING : '"' ('\\"'|.)*? '"' ;
STRING : [a-zA-Z]+ ;
INT : '-'?[0-9]+ ;
WS : [ \t]+ -> skip;
NEWLINE : '\r'? '\n' ;
