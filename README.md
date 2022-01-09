# Clean code

## Code smells

### Poor names

#### Mysterious names

- `SqlDataReader dr1;`
- `int od;`
- `void Button_1_Click();`
- `class Page1 {}`

- Now, let's see how we can improve this code:
- 
- `SqlDataReader dataReader;`
- `int overdueDays;`
- `void CheckAvailability_Click();`
- `class ViewCustomerPage {}`

#### Meaningless names

- `void BeginCheckFuncionality_StoreClientSideCheckboxIDsArray();`

- Let's say five lines of code or less than 10 lines. That method is doing only one thing and it's easy to come up with a meaningful name.

#### Names with encodings

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

#### Ambiguous names

- What does this method do here? Is it telling me if multiple items are selected or is it to select multiple items?
  - `bool MultiSelect() {}`

- Here is another ambiguous name, what does inside a name ID mean?
  - `int? incidentNameId`

    - If it's incident the name, then why is the data type nullable integer, so it's more like an incident
    - ID than what is name doing there.
    - If it's incident ID, why is it nullable integer?
    - How can we have an incident without an ID?
    - So this is a very poor name on so many levels.

#### Noisy names.

- Look at these identifiers, the customer or a list of approved customers.
  - `Customer theCustomer;`
  - `List<Customer> listOfApprovedCustomers;`

- Now, let's see how we can improve this code:
  - `Customer customer;`
  - `List<Customer> approvedCustomers;`

#### Names

- Not too short, not too long
- Meaningful
- Reveal intention
- Chosen from problem domain


### Poor names conventions

#### Iconsistent naming conventions

- Over my years of experience, I have seen numerous examples of developers coming from other backgrounds and they adopt a different naming convention.

- Here are some examples.
  - `Customer GetCustomer(int _id);`
  - `Customer saveCustomer(Customer customer);`
  - `private int customerId;`

#### .NET naming conventions

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

### Poor method signatures

#### Poor method signatures

- `Orange GetCustomer(int airplane);`
  - So basically, what I mean by that is it's like you have a method called GetCustomer, but the parameter it guess it's an airplane which is actually not an airplane object. It's an integer. And what that method returns is not a customer. It's an orange.

- Another example:
  - `void Parse(int command);`
    - This method is called pass. It gets a command of type integer and returns void, what is wrong with this method typically pass means getting a string and converting that to a different object.
    - For example, you might have a pass method that gets a string representation of a daytime and then it returns a daytime object.
    - So the problem with this method is that it's parameter should be of type string and its return type should be an integer, not void.

FOLDER REFACTORING HERE!!!!

# Refactoring