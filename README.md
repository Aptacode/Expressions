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
var ConstantFloatEx =  new ConstantFloat<TContext>(3.14); // An expression representing the float value 3.14
var ConstantColorEx = new ConstantColor<TContext>(System.Drawing.Color.Red); // An expression representing the color red
var ConstantGuidEx = new ConstantGuid <TContext>(Guid.NewGuid()); // An expression representing a constant guid
```

There are also generic `ConstantListExpressions` that can be used to represent expressions of lists of any generic type:

```csharp
var ConstantListExpression = new ConstantList<TType, TContext>(TType[] list); //An expression representing a list of some generic type
```

### Arithmetic Operators

Arithmetic operations can act on expressions of any type with the `GenericArithmeticOperators`:

```csharp
var AddExpression = new Add<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing addition on the expressions a & b: a + b
var SubtractExpression = new Subtract<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing subtraction on the expressions a & b: a - b
var MultiplyExpression = new Multiply<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing multipl on the expressions a & b: a * b
```

Again there are also type specific variations of these operators:

```csharp
var AddFloatExpression = new AddFloat<TContext>(new ConstantFloat<TContext>(2.72), new ConstantFloat<TContext>(1.41)); //An expression representing addition of two floats: 2.72 + 1.41
var SubtractDecimalExpression = new SubtractDecimal<TContext>(new ConstantDecimal<TContext>(2.6), new ConstantDecimal<TContext>(1.9)); //An expression respresenting subtraction of the right float from the left:  2.6 - 1.3
var MultiplyDoubleExpression = new MultiplyDouble<TContext>(new ConstantDouble<TContext>(1.2), new ConstantDouble<TContext>(3.4)); //An expression representing the multiplication of two doubles: 1.2 * 3.4
```

There is also the special case of string concatenation that can be considered as the addition operator acting on string expressions:

```csharp
var ConcatStringExpression = new ConcatString<TContext>(new ConstantString<TContext>(foo), new ConstantString<TContext>(bar)) //An expression representing the concatenation (addition) of two string expressions: 'foo' + 'bar'
```

### Boolean Logical Operators

Boolean logic operations that operate boolean expressions in the usual manner:

```csharp
var OrExpression = new Or<TContext>(new ConstantBool<TContext>(true), new ConstantBool<TContext>(false)); //An expression representing the boolean expression 'true OR false'
var NotExpression = new Not<TContext>(new ConstantBool<TContext>(true)); //An expression representing the boolean expression 'NOT true'
var AndExpression = new And<TContext>(new ConstantBool<TContext>(true), new ConstantBool<TContext>(false)); //An expression representing the boolean expression 'true AND false'
var XOrExpression = new XOr<TContext>(new ConstantBool<TContext>(true), new ConstantBool<TContext>(false)); //An expression representing the boolean expression 'true XOR false'
```

There are also the `All` and `Any` operations that are equivalent to the boolean logic operations NAND and NOR, respectively:

```csharp
var AnyExpression = new Any<TContext>(new ConstantBool<TContext>(true), new ConstantBool<TContext>(true), new ConstantBool<TContext>(false); //An expression respresenting the boolean expression 'true OR true OR false'
var AllExpression = new All<TContext>(new ConstantBool<TContext>(true), new ConstantBool<TContext>(true), new ConstantBool<TContext>(false); //An expression respresenting the boolean expression 'true AND true AND false'
```

### Boolean Relational Operators

Expressions with boolean relational operators can be made on any given type, though care must be taken to ensure the [operators are defined on the type](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators#operator-overloadability):

```csharp
var GreaterThanExpression = new GreaterThan<TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); // An expression representing the comparison 'a > b'
var LessThanExpression = new LessThan<TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression representing the comparison a < b
var GreaterThanOrEqualToExpression = new GreaterThanOrEqualTo<TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); // An expression representing the comparison a >= b
var LessThanOrEqualToExpression = new LessThanOrEqualTo<TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); // An expression representing the comparison a <= b
```

### Boolean Equality Operators

Similarly, expressions with boolean relational operators can be made on any given type:

```csharp
var EqualToExpression = new EqualTo<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression represent the comparison 'a == b'
var NotEqualToExpression = new NotEqualTo<TType, TContext>(IExpression<TType, TContext> a, IExpression<TType, TContext> b); //An expression represent the comparison 'a != b'
```

### List Operators

Expressions of lists have some of the usual list operations defined on them:

```csharp
var ConcatListExpression = new ConcatList<TType, TContext>(IListExpression<TType, TContext> list1, IListExpression<TType, TContext> list2); //An expression representing the concatenation of two list expressions 'list1 + list2'
var FirstExpression = new First<TType, TContext>(IListExpression<TType, TContext> list); //An expression representing the first item in the list
var LastExpression = new Last<TType, TContext>(IListExpression<TType, TContext> list); //An expression representing the last item in the list
var TakeFirstExpression = new TakeFirst<TType, TContext>(IListExpression<TType, TContext> list, IExpression<int, TContext> n); //An expression representing the first n items in the list
var TakeLastExpression = new TakeLast<TType, TContext>(IListExpression<TType, TContext> list, IExpression<int, TContext> m); //An expression representing the last m items in the list
var CountExpression = new Count<TType, TContext>(IListExpression<TType, TContext> list); //An integer expression representing the number of items in the list
```



## ExpressionFactory and Fluent API

Building complex expressions manually can be a bit messy syntactically and so there is also an `ExpressionFactory` class.

```csharp
public readonly ExpressionFactory<TContext> _ex = new ExpressionFactory<TContext>();
var one = _ex.Int(1); //Creates a new ConstantInteger expression with value 1
var true = new _ex.Bool(ture); //Creates a new ConstantBool expression with value true
var SevenIsGreaterThanFive = new _ex.GreaterThan<int>(_ex.Int(7), _ex.Int(5)); //This is much tidier than the basic implementation
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
