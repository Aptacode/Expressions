# Expressions

Whilst originally designed to be used to represent and determine connection weights in [StateNet](https://github.com/Aptacode/StateNet), Expressions is a C# library used for writing and evaluating [expressions](https://en.wikipedia.org/wiki/Expression_(computer_science)) in a given context.

## Overview

Expressions can be used to write simple expressions:

```csharp
var Expression = new ConstantInteger<TContext>(1) //An expression representing the int value 1
```

As well as more complex nested expressions:

```csharp
var Expression = new And<TContext>( //An expression following the usual boolean logic of the 'and' operator
                     new GreaterThan<int, TContext>( //An expression for the comparison operator >, this will evaluate to true as 4 > 1
                        new ConstantInteger<TContext>(4), new ConstantInteger<TContext>(1)),
                     new EqualTo<int, TContext>(new ConstantInteger<TContext>(1), new ConstantInteger<TContext>(1))); //An expression for the equality operator.
```
To evaluate these expressions into the correct context, the Expressions library utilises the Interpreter design pattern; Every expression type has an `.Interpret(context)` method. When called on a given context, any non-terminal expressions will recursively call `.Interpret(context)` (passing through the same context) on the expressions within them until a terminal expression is reached. Terminal expressions can then be evaluated to their respective values and value types in the given context. These in turn are passed on to the containing non-terminal expressions until the expression is completely evaluated.


## ExpressionFactory

Building complex expressions manually can be a bit messy syntactically and so there is also an `ExpressionFactory` class.

```csharp
public readonly ExpressionFactory<TContext> _ex = new ExpressionFactory<TContext>();
var one = _ex.Int(1); //Creates a new ConstantInteger expression with value 1
var true = new _ex.Bool(true); //Creates a new ConstantBool expression with value true
var SevenIsGreaterThanFive = new _ex.GreaterThan<int>(_ex.Int(7), _ex.Int(5)); //This is much tidier than the basic implementation
```

A more complicated example highlights the improvement in conciseness:

```csharp
public readonly ExpressionFactory<TContext> _expressions = new ExpressionFactory<TContext>();
var fibListExpression = _expressions.List(new int[] { 1, 1, 2, 3, 5, 8 });

for(int i = 0; i < 20; i++)
{
    fibListExpression = _expressions.List(_expressions.ConditionalList(_expressions.LessThan(_expressions.Last(fibListExpression), _expressions.Int(100)),
                                _expressions.Append(fibListExpression,
                                    _expressions.Add(_expressions.First(_expressions.TakeLast(fibListExpression, _expressions.Int(2))), 
                                    _expressions.Last(_expressions.TakeLast(fibListExpression, _expressions.Int(2))))),
                                fibListExpression).Interpret(_context)); //An expression that when intepreted will add the next number in the fibonacci sequence to the list as long as that number is less than 100 and return the list as an expression or will just return the list as an expression if the next number is greater than 100.
}


var fibLessThan100 = fibListExpression.Interpret(_context); //Interpreting the expression above will return a list of containing the numbers in the Fibonacci sequence less than 100.
```

## Fluent API

In the above example operators on our expressions such as `_expressions.Add()` are to the left of pair of expressions `(lhs, rhs)` that is acted on by an operator i.e

```csharp
var addEx = _expressions.Add(_expressions.Int(2), _expressions.Int(2);
```

Using the roman alphabet we are more used to reading from left to right and so the above expression can still be a little tricky to read, especially when the arguments are also complicated expressions. To improve this we also have a more fluent API for our operators. With this the above expression becomes:

```csharp
var addEx = _expressions.Int(2).Add(_expressions.Int(2));
```

## Usage and Examples

### Constant Expressions

Constant expressions of any type can be created using the generic `ConstantExpression`:

```csharp
var ConstantExpression = new ConstantExpression<TType, TContext>(TType a); //An expression 'a' of some generic type 
```
And also using the `ExpressionFactory`:

```csharp
public readonly ExpressionFactory<TContext> _expressions = new ExpressionFactory<TContext>();

var ConstantExpression = _expressions.Expression<TType>(TType a);
```

We can also create various type specific constant expressions:

```csharp
var ConstantFloatEx =  _expressions.Float(3.14f); // An expression representing the float value 3.14
var ConstantColorEx = _expressions.Color(System.Drawing.Color.Red); // An expression representing the color red
var ConstantGuidEx = _expressions.Guid(Guid.NewGuid()); // An expression representing a constant guid
```

We can also make constant lists that can be used to represent expressions of lists of any generic type:

```csharp
var ConstantListExpression = _expressions.List<TType>(TType[] list); //An expression representing a list of some generic type
```

### Arithmetic Operators

Arithmetic operations can act on expressions of any type with the `GenericArithmeticOperators`, though care must be exercised to ensure [the operators are implemented on the given type properly](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading):

```csharp
var AddExpression = new Add<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing addition on the expressions a & b: a + b
```

With the fluent API and `ExpressionFactory` we also have:

```csharp
public readonly ExpressionFactory<TContext> _expressions = new ExpressionFactory<TContext>();

var SubtractExpression = _ex.Expression<TType>(a).Subtract(_ex.Expression<TType>(b)); //An expression representing subtraction on the expressions a & b: a - b
var MultiplyExpression = _ex.Expression<TType>(a).Multiply(_ex.Expression<TType>(b));; //An expression representing multiplication on the expressions a & b: a * b
```

Above we can see that the type can be inferred by the operator but if we want to be more explicit again there are also type specific variations of these operators:

```csharp
var AddFloatExpression =  _expressions.Float(2.72f).AddFloat(_expressions.Float(1.41f)); //An expression representing addition of two floats: 2.72 + 1.41
var SubtractDecimalExpression = _expressions.Decimal(2.6m).SubtractDecimal(_expressions.Decimal(1.9m)); //An expression respresenting subtraction of the right float from the left:  2.6 - 1.3
var MultiplyDoubleExpression =_expressions.Double(1.2).MultiplyDouble(_expressions.Double(3.4)); //An expression representing the multiplication of two doubles: 1.2 * 3.4
```

There is also the special case of string concatenation that can be considered as the addition operator acting on string expressions:

```csharp
var ConcatStringExpression = _expressions.String(foo).ConcatString(_expressions.String(bar)); //An expression representing the concatenation (addition) of two string expressions: 'foo' + 'bar'
```

### Boolean Relational Operators and Equality Operators

Similarly to the arithmetic operators, expressions with boolean relational operators can be made on any given type, though - again - care must be taken to ensure the [operators are properly implemented on the type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators#operator-overloadability):

```csharp
var GreaterThanExpression = new GreaterThan<TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); // An expression representing the comparison 'a > b'
```

Using the the fluent API and `ExpressionFactory`:

```csharp
public readonly ExpressionFactory<TContext> _expressions = new ExpressionFactory<TContext>();


var LessThanExpression = _expressions.Expression<TType>(a).LessThan(_expressions.Expression<TType>(b); //An expression representing the comparison a < b
var GreaterThanOrEqualToExpression = _expressions.Expression<TType>(a).GreaterThan(_expressions.Expression<TType>(b); // An expression representing the comparison a >= b
var LessThanOrEqualToExpression = _expressions.Expression<TType>(a).LessThanOrEqualTo(_expressions.Expression<TType>(b); // An expression representing the comparison a <= b
```

Similarly, expressions with boolean equality operators can be made on any given type:

```csharp
var EqualToExpression = _expressions.Expression<TType>(a).EqualTo(_expressions.Expression<TType>(b); //An expression represent the comparison 'a == b'
var NotEqualToExpression = _expressions.Expression<TType>(a).NotEqualTo(_expressions.Expression<TType>(b); //An expression represent the comparison 'a != b'
```

### Boolean Logical Operators

For boolean expressions we have the usual boolean logical operators. Using the fluent API and `ExpressionFactory`:

```csharp
public readonly ExpressionFactory<TContext> _expressions = new ExpressionFactory<TContext>();

var OrExpression = _expressions.Bool(true).Or(_expressions.Bool(false)); //An expression representing the boolean expression 'true OR false'
var NotExpression = _expressions.Bool(true).Not(); //An expression representing the boolean expression 'NOT true'
var AndExpression = _expressions.Bool(true).And(_expressions.Bool(false)); //An expression representing the boolean expression 'true AND false'
var XOrExpression = _expressions.Bool(true).XOr(_expressions.Bool(false)); //An expression representing the boolean expression 'true XOR false'
```

There are also the `All` and `Any` operations that are equivalent to the boolean logic operations NAND and NOR, respectively:

```csharp
var AllExpression = _expressions.Bool(true).All(_expressions.Bool(true), _expressions.Bool(false)); //An expression respresenting the boolean expression 'true AND true AND false'
var AnyExpression = _expressions.Bool(true).Any(_expressions.Bool(true), _expressions.Bool(false)); //An expression respresenting the boolean expression 'true OR true OR false'
```


### List Operators

For list expressions we also have some of the usual list operations. Using the fluent API and `ExpressionFactory`:

```csharp
public readonly ExpressionFactory<TContext> _expressions = new ExpressionFactory<TContext>();

var list1 = new TType[] { a, b };
var list2 = new TType[] { c, d };
var ConcatListExpression = _expressions.List(list1).ConcatList(list2); //A list expression representing the concatenation of two list expressions 'list1 + list2'
var FirstExpression = _expressions.List(list1).First(); //An expression representing the first item in the list
var LastExpression = _expressions.List(list1).Last(); //An expression representing the last item in the list
var TakeFirstExpression = _expressions.List(list1).TakeFirst(_expressions.Int(n)); //A list expression of the first n items in 'list1'
var TakeLastExpression = _expressions.List(list1).TakeLast(_expressions.Int(m)); //A list expression of the last m items in 'list1'
var CountExpression = _expressions.List(list1).Count(); //An integer expression representing the number of items in the list
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
