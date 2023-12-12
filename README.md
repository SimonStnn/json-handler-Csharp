# JSON handler C\#

This is my json handler for C#.

## How to get the json handler

1. download the zip
1. unpack it
1. place the JSON.cs file in your solution
1. in the file you want to use the JSON handler type as top-level statement (so the statement at the top of your page) "using JSON = jsonHandler.JSON;"
1. done

## How to use the json handler

### Creating a JSON instance

This is how you make a JSON instance.

```csharp
JSON json = new();
```

### Using GetJSON method

To get the JSON from a `.json` file you can use the `.GetJSON` method.

```csharp
json.GetJSON("./path-to-json.json")
```

Easy, right? :D

> [!WARNING]  
> NOT COMPLETE YET!!
