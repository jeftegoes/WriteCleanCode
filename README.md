# Clean code for C# <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Code smells](#1-code-smells)
  - [1.1. Poor names](#11-poor-names)
    - [1.1.1. Mysterious names](#111-mysterious-names)
    - [1.1.2. Meaningless names](#112-meaningless-names)
    - [1.1.3. Names with encodings](#113-names-with-encodings)
    - [1.1.4. Ambiguous names](#114-ambiguous-names)
    - [1.1.5. Noisy names.](#115-noisy-names)
    - [1.1.6. Names](#116-names)
  - [1.2. Poor names conventions](#12-poor-names-conventions)
    - [1.2.1. Iconsistent naming conventions](#121-iconsistent-naming-conventions)
    - [1.2.2. .NET naming conventions](#122-net-naming-conventions)
  - [1.3. Poor method signatures](#13-poor-method-signatures)
  - [1.4. Long parameter list](#14-long-parameter-list)
  - [1.5. Output parameters](#15-output-parameters)
  - [1.6. Variable declarations on the top](#16-variable-declarations-on-the-top)
    - [1.7. Variables](#17-variables)
  - [1.8. Magic numbers](#18-magic-numbers)
    - [1.8.1. Avoid magic number](#181-avoid-magic-number)
  - [1.9. Nested conditionals](#19-nested-conditionals)
    - [1.9.1. Use ternary operator](#191-use-ternary-operator)
    - [1.9.2. Ternary operator abuse](#192-ternary-operator-abuse)
    - [1.9.3. Simplify true/false](#193-simplify-truefalse)
    - [1.9.4. Combine](#194-combine)
    - [1.9.5. Early exit](#195-early-exit)
    - [1.9.6. Early exit + combine](#196-early-exit--combine)
    - [1.9.7. Swap orders](#197-swap-orders)
    - [1.9.8. Everything in moderation](#198-everything-in-moderation)
  - [1.10. Switch statements](#110-switch-statements)
  - [1.11. Long methods](#111-long-methods)
  - [1.12. Cohesion principle](#112-cohesion-principle)
    - [1.12.1. Single responsibility principle (SRP)](#1121-single-responsibility-principle-srp)
    - [1.12.2. Duplicated code](#1122-duplicated-code)
  - [1.13. Comments](#113-comments)
    - [1.13.1. Stating the obvious](#1131-stating-the-obvious)
    - [1.13.2. Version history](#1132-version-history)
    - [1.13.3. Clarify the code](#1133-clarify-the-code)
    - [1.13.4. Dead code](#1134-dead-code)
  - [1.14. Best practices](#114-best-practices)
- [2. Refactoring](#2-refactoring)
- [3. Resume](#3-resume)

# 1. Code smells

## 1.1. Poor names

### 1.1.1. Mysterious names

- `SqlDataReader dr1;`
- `int od;`
- `void Button_1_Click();`
- `class Page1 {}`

- Now, let's see how we can improve this code:
- `SqlDataReader dataReader;`
- `int overdueDays;`
- `void CheckAvailability_Click();`
- `class ViewCustomerPage {}`

### 1.1.2. Meaningless names

- `void BeginCheckFuncionality_StoreClientSideCheckboxIDsArray();`

- Let's say five lines of code or less than 10 lines. That method is doing only one thing and it's easy to come up with a meaningful name.

### 1.1.3. Names with encodings

- I've seen names with encodings, the encoding using this example is Hungarian notation, and that was

  - `int iMaxRequests`

- Very popular amongst C++ programmers back in the 80s and 90s. And he came up with this idea to prefix variable names with our data type. But these days, Hungarian notation is not applicable anymore. We have really good ideas in Visual Studio, if you want to see the data type of a variable, you can just hover your mouse over it and you will see there is no need to pollute your identifiers with that data type.

- So in this example, we can just call these:

  - `int maxRequests`

- Here is another example of Hungarian notation, What does m_objCollection mean?

  - `var m_objCollection = new StringCollection();`

- I have to look and see what is stored in that collection.

- This object collection is actually assigned to a `StringCollection`, so it's not really an object collection as in a collection of objects. It's a collection of strings. What is inside that string collection? If this string collection is used to store the list of countries, we can just call it `countryNames` instead of `m_objCollection`, see, this name is shorter and more meaningful, more and revealing.
  - `var countryNames = new StringCollection();`

### 1.1.4. Ambiguous names

- What does this method do here? Is it telling me if multiple items are selected or is it to select multiple items?

  - `bool MultiSelect() {}`

- Here is another ambiguous name, what does inside a name ID mean?

  - `int? incidentNameId`

    - If it's incident the name, then why is the data type nullable integer, so it's more like an incident
    - ID than what is name doing there.
    - If it's incident ID, why is it nullable integer?
    - How can we have an incident without an ID?
    - So this is a very poor name on so many levels.

### 1.1.5. Noisy names.

- Look at these identifiers, the customer or a list of approved customers.

  - `Customer theCustomer;`
  - `List<Customer> listOfApprovedCustomers;`

- Now, let's see how we can improve this code:
  - `Customer customer;`
  - `List<Customer> approvedCustomers;`

### 1.1.6. Names

- Not too short, not too long
- Meaningful
- Reveal intention
- Chosen from problem domain

## 1.2. Poor names conventions

### 1.2.1. Iconsistent naming conventions

- Over my years of experience, I have seen numerous examples of developers coming from other backgrounds and they adopt a different naming convention.

- Here are some examples.
  - `Customer GetCustomer(int _id);`
  - `Customer saveCustomer(Customer customer);`
  - `private int customerId;`

### 1.2.2. .NET naming conventions

- In .NET, we have two naming conventions, `PascalCase` and `camelCase`

  - `PascalCase`: First letter of every word is uppercase.
  - `camelCase`: The first letter of the first word is lowercase, but the first letter of every word after that is uppercase.

- Example using .NET name convention:

  ```
    public class Customer
    {
        private int _id;

        public string Name { get; set; }

        public Charge(int amount)
        {
            var tax = 0;
        }
    }
  ```

- So as you see the name of a class `public class Customer`, its properties `public string Name` and methods `public Charge` used `PascalCase`.
- For private fields `private int _id`, parameters `int amount` and local variables `var tax = 0`, use `camelCase`.
- Except that with private fields or readonly, we need to prefix them with an underlying `private int _id`.

## 1.3. Poor method signatures

- `Orange GetCustomer(int airplane);`

  - So basically, what I mean by that is it's like you have a method called GetCustomer, but the parameter it guess it's an airplane which is actually not an airplane object. It's an integer. And what that method returns is not a customer. It's an orange.

- Another example:
  - `void Parse(int command);`
    - This method is called pass. It gets a command of type integer and returns void, what is wrong with this method typically pass means getting a string and converting that to a different object.
    - For example, you might have a pass method that gets a string representation of a datetime and then it returns a daytime object.
    - So the problem with this method is that it's parameter should be of type string and its return type should be an integer, not void.

[Poor method signatures example](PoorMethodSignatures/)

## 1.4. Long parameter list

- Another common cold smell is a method with long parameter lists, the more parameters we have for a method, the harder it gets to understand that method and its intention.

  - `CheckNotifications(null, 1, true, false, DateTime.Now)`
  - Now, what do these arguments represent?
    - What is now, what is one?
    - What is true?
    - What is false?
  - We cannot tell without having a look at the implementation of that method.

- I know that a method like that, every time you want to call it, we have to pass so many arguments, so not only that method is hard to understand, but it's also hard to use.

[Long parameter list example](LongParameterList/)

- Resume:
  - More than three parameters, most of the time is a code smell, and you need to get rid of unnecessary parameters or encapsulate the logically related ones into a class.

## 1.5. Output parameters

- `int count = 0`
- `var customers = GetCustomers(pageIndex, out count)`

[Output parameters example](OutputParameters/)

Resume:

- `out` Avoid them
- Return an object from a method instead

## 1.6. Variable declarations on the top

- When you declare a variable on top of a method, it's like you're talking about a story and then you go somewhere else where those variables are not used until later, so the context switches
- So someone reading that code will have to consume more brainpower to remember the connection between those variables declared at the top and where they are used.

[Varibles example](VariableDeclarationsOnTheTop/)

### 1.7. Variables

- Declare them close to their usage.

## 1.8. Magic numbers

### 1.8.1. Avoid magic number

[Magic numbers example](MagicNumbers/)

- Use constants or enums

## 1.9. Nested conditionals

- Nested conditionals, that's one of the code smells that I often see amongst junior and sometimes intermediate developers. So basically what I mean by that is a piece of code that looks like this. You have a bunch of if else, if else, and a switch in the middle and perhaps a loop.

- So the problem with this nested conditionals is they make programs hard to read, are to change, hard to understand and hard to test.

  ```
    if (a)
    {
        if (b)
        {
            if (c)
            {
                statement
            }
            else
            {

            }
        }
    }
  ```

### 1.9.1. Use ternary operator

- Imagine you have a pattern like this in your code, so `a` is a boolean expression, and if it's true, you're going to set the value of `someValue`, otherwise we're going to set to `anotherValue`:

```
  if (a)
      c = someValue;
  else
      c = anotherValue;
```

- The ternary operator has three parts, the first part, the second part and the third part, note that these parts are separated by Questionmark and a column:

`c = (a) ? someValue : anotherValue;`

- See a real world example:

  ```
    if (customer.TotalOrders > 50)
        discount = 0.1f;
    else
        discount = 0.01f;
  ```

- We can rewrite this expression using ternary operator like this.
  - `discount = (customer.TotalOrders > 50) ? 0.1f : 0.01f;`

### 1.9.2. Ternary operator abuse

`c = a ? b : d ? e : f;`

- Do not apply more than once.

### 1.9.3. Simplify true/false

- Here is another great technique which does not have a name, I just call it simplify, true or false.

  ```
    if (a)
        b = true;
    else
        b = false;
  ```

- We can simplify this expression to something like this:

`b = a;`

- See a real world example:

  ```
    if (customer.TotalOrders > 50)
        isGoldCustomer = true;
    else
        isGoldCustomer = false;
  ```

- We can rewrite this expression to something like this:

`isGoldCustomer = customer.TotalOrders > 50;`

### 1.9.4. Combine

- Imagine you have two nested conditional statements like the one you see here, so if he's true and we come here, if this is true, then some statement is going to be executed:

  ```
  if (a)
  {
      if (b)
      {
          // Statement...
      }
  }
  ```

- We can use the logical and operator to rewrite these conditional statements like this:

  ```
  if (a && b)
  {
      // Statement...
  }
  ```

### 1.9.5. Early exit

    ```
      if (a)
      {
          if (b)
          {
              // Statement...
          }
      }
    ```

- There is also another way to rewrite this expression and get rid of the nested levels, we can use the `guard statements`:

  ```
    if (!a)
        return;

    if (!b)
        return;

    // Statement...
  ```

### 1.9.6. Early exit + combine

- So if A is false or B is false, return immediately, otherwise we execute this statement here.

  ```
    if (!a || !b)
      return;

    statement
  ```

### 1.9.7. Swap orders

```
  if (a)
  {
    if (b)
    {
      isValid = true
    }
  }

  if (c)
  {
    if (b)
    {
      isValid = true
    }
  }
```

- We reduced for brief statements to only one and guess what, we can totally get rid of that.

  ```
    if (b)
    {
      if (a || c)
      {
        isValid = true
      }
    }
  ```

- Combine again

  ```
    if (b && (a || c))
    {
      isValid = true;
    }
  ```

- Combine again
  `isValid = (b && (a || c));`


[Nested conditionals example](NestedConditionals/)

### 1.9.8. Everything in moderation

if (a && (b || c) && !d || e && (f && !g || h))
STINKS!

## 1.10. Switch statements

- Replace them with polymorphic dispatch
- Use push member down refactoring

[Switch statements example](SwitchStatements/)

## 1.11. Long methods

- Problems with long methods
  - Hard to understand
  - Hard to change
  - Hard to re-use
- More than 10 lines of code
- We want methods that specialise in **one** thing
  - When you have a method that is more than five lines or let's say 10 lines, it's most likely doing to many things.

## 1.12. Cohesion principle

- Things that are related, should be together.
- Things that are not related, should not be together.

### 1.12.1. Single responsibility principle (SRP)

- A class / method should do only one thing, and do it very well.

### 1.12.2. Duplicated code

- Duplication, that's another code smell that we should avoid at all times.
- Plus duplicated code makes your code noisy and hard to understand.
- There is a principle called **DRY** which stands for **Don't Repeat Yourself** (The Pragmatic Programmer).

[Duplicated code example](DuplicatedCode/)

## 1.13. Comments

### 1.13.1. Stating the obvious

- This comment is telling me returns the list of customers, so what is the value of this comment?

  ```
    // Returns the list of customers
    public List<Customer> GetCustomers()
    {
    }
  ```

  ```
    // Create a new connection to the database
    var connection = new SqlConnection();
  ```

  ```
    // If the number of overdue days is less than 5, notify.
    // the customer. Otherwise, issue a fine.

    if (overdueDays < 5>)
      NotifyCustomer();
    else
      IssueFine();
  ```

- The code should be so clean and so self explanatory that it does not need any comments.

### 1.13.2. Version history

- Again, this is completely useless these days.
- We use version control systems. If someone is interested to see who made what change when they can always look at the log or history of the repository.

  ```
    // Prior to v1.3
    if (isActive)
    {

    }
  ```

  ```
  // 1 Jan 2000 - John: ...
  // 4 Jun 2003 - Bob: ...
  // 21 Dec 2005 - Ana: ...
  ...
  ...
  ...
  ...
  ...
  ...
  ...
  public class WorkScheduler
  ```

### 1.13.3. Clarify the code

- Well, couldn't we just name that variable pay frequency?
  - This way we wouldn't need that comment.

`var pf = 10; // Pay frequency`

### 1.13.4. Dead code

- And here's another category of comments that, quote, why would you even comment out some code, just delete it if you don't need it, just delete it.
- We can always pull it back from your source code repository.
  ```
    // public class WorkScheduler
    // {
    // }
  ```

## 1.14. Best practices

- Don't write comments, re-write your code
- Dont't explain "whats" (the obvious)
- Explain "whys" and "hows"

[Comments example](Comments/)

# 2. Refactoring

# 3. Resume

- Private fields always in the constructor...
