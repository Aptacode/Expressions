# Expressions

Whilst originally designed to be used to represent and determine connection weights in [StateNet](https://github.com/Aptacode/StateNet), Expressions is a C# library used for writing and evaluating [expressions](https://en.wikipedia.org/wiki/Expression_(computer_science)) in a given context.

## Overview

Expressions can be used to write simple expressions:

```csharp
var Expression = new ConstantInteger<TContext>(1) // an expression representing the int value 1
```

As well as more complex nested expressions:

```csharp
var Expression = new And<TContext>( //An expression following the usual boolean logic of the 'and' operator
                     new GreaterThan<int, TContext>( //An expression for the comparison operator >, this will evaluate to true as 4 > 1
                        new ConstantInteger<TContext>(4), new ConstantInteger<TContext>(1)),
                     new EqualTo<int, TContext>(new ConstantInteger<TContext>(1), new ConstantInteger<TContext>(1))); //An expression for the equality operator.
```
To evaluate these expressions into the correct context, the Expressions library utilises the Interpreter design pattern; Every expression type has an `.Interpret(context)` method. When called on a given context, any non-terminal expressions will recursively call `.Interpret(context)` (passing through the same context) on the expressions within them until a terminal expression is reached. Terminal expressions can then be evaluated to their respective values and value types in the given context. These in turn are passed on to the containing non-terminal expressions until the expression is completely evaluated.

## Usage and Examples

### Constant Expressions

Constant expressions of any type can be created using the generic `ConstantExpression`:

```csharp
var ConstantExpression = new ConstantExpression<TType, TContext>(TType value);
```

Here are a few examples of the various type specific constant expressions:

```csharp
var ConstFloatEx =  new ConstantFloat<TContext>(3.14); // An expression representing the float value 3.14
var ConstColorEx = new ConstantColor<TContext>(System.Drawing.Color.Red); // An expression representing the color red
var ConstGuidEx = new ConstantGuid <TContext>(Guid.NewGuid()); // An expression representing a constant guid
```

### Arithmetic Operators

Arithmetic operations acting expressions can be done on any type with the `GenericArithmeticOperators`:

```csharp
var AddExpression = new Add<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing addition on the expressions a & b: a + b
var SubtractExpression = new Subtract<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing subtraction on the expressions a & b: a - b
var MultiplyExpression = new Multiply<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing multipl on the expressions a & b: a * b
```

Again there are also type specific variations of these operators:

```csharp
var AddFloatExpression = new AddFloat<TContext>(new ConstantFloat<TContext>(2.72), new ConstantFloat<TContext>(1.41)); //An expression representing addition of two floats: 2.72 + 1.41
var SubtractDecimalExpression = new SubtractDecimal<TContext>(new ConstantDecimal<TContext>(2.6), new ConstantDecimal<TContext>(1.9)); //An expression respresenting subtraction of the right float from the left:  2.6 - 1.3
var MultiplyDouble Expression = new MultiplyDouble<TContext>(new ConstantDouble<TContext>(1.2), new ConstantDouble<TContext>(3.4)); //An expression representing the multiplication of two doubles: 1.2 * 3.4
```

There is also the special case of string concatenation that can be considered as the addition operator acting on string expressions:

```csharp
var ConcatStringExpression = new ConcatString<TContext>(new ConstantString<TContext>(foo), new ConstantString<TContext>(bar)) //An expression representing the concatenation (addition) of two string expressions: 'foo' + 'bar'
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
