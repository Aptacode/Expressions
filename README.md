# Expressions

As the name suggests, Expressions is a C# library used for writing and evaluating [expressions](https://en.wikipedia.org/wiki/Expression_(computer_science)).

## Overview

Expressions can be used to write simple expressions:

```csharp
var Expression = new ConstantInteger<TContext>(1) // an expression representing the int value 1
```

As well as more complex nested expressions:

```csharp
var Expression = new And<TContext>( //An expression following the usual boolean logic of the 'and' operator
                     new GreaterThan<TContext>( //An expression for the comparison operator >, this will evaluate to true as 4 > 1
                        new ConstantInteger<TContext>(4), new ConstantInteger<TContext>(1)),
                     new EqualTo<TContext>(new ConstantInteger<TContext>(1), new ConstantInteger<TContext>(1))); //An expression for the equality operator.
```
To evaluate these expressions into the correct context, the Expressions library utilises the Interpreter design pattern; Every expression type has an `.Interpret(context)` method. When called on a given context, any non-terminal expressions will recursively call `.Interpret(context)` (passing through the same context) on the expressions within them until a terminal expression is reached. Terminal expressions can then be evaluated to their respective values and value types in the given context. These in turn are passed on the containing non-terminal expressions until the expression is completely evaluated.

## Usage and Examples

Whilst originally designed to be used to represent and determine connection weights in [StateNet](https://github.com/Aptacode/StateNet), the Expressions library can be used as a general purpose library for writing expressions.

### Integer Expressions

Some examples of integer expression operations, these take integer expressions as arguments.

```csharp
var AddExpression = new Add<TContext>(new ConstantInteger<TContext>(1), new ConstantInteger<TContext>(1)); //An expression adding two integers: 1 + 1
var SubtractExpression = new Subtract<TContext>(new ConstantInteger<TContext>(2), new ConstantInteger<TContext>(1)); //An expression subtracting the right integer from the left:  2 -  1
var MultiplyExpression = new Multiply<TContext>(new ConstantInteger<TContext>(2), new ConstantInteger<TContext>(2)); //An expression multiplying two integers: 2 * 2
```

### Boolean Logical Expressions

Some examples of expressions for boolean logic operations, these take and return boolean expressions.

```csharp
var TrueExpression = new ConstantBool<TContext>(true); //An expression representing the bool value true
var OrExpression = new Or<TContext>(new ConstantBool<TContext>(true), new ConstantBool<TContext>(false)); //An expression for the boolean logical operator OR
var NotExpression = new Not<TContext>(new ConstantBool<TContext>(true)); //An expression for the boolean logical operator NOT
```

### Boolean Comparison Expressions

Some examples of expressions for boolean comparison operations, these take integer expressions and return boolean expressions.

```csharp
var LessThanExpression = new LessThan<TContext>(new ConstantInteger<TContext>(1), new ConstantInteger<TContext>(2)); //An expression representing the comparison 1 < 2
var GreaterThanOrEqualToExpression = new GreaterThanOrEqualTo<TContext>(new ConstantInteger<TContext>(1), new ConstantInteger<TContext>(2)) // An expression representing the comparison 1 >= 2
```

## ExpressionFactory and Fluent API

Building complex expressions manually can be a bit messy syntactically and so there is also an `ExpressionFactory` class.

```csharp
public readonly ExpressionFactory<TContext> _ex = new ExpressionFactory<TContext>();
var one = _ex.Int(1); //Creates a new ConstantInteger expression with value 1
var true = new _ex.Bool(ture); //Creates a new ConstantBool expression with value true
var SevenIsGreaterThanFive = new _ex.GreaterThan(_ex.Int(7), _ex.Int(5)); //This is much tidier than the basic implementation
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
