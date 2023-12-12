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

- JSON <variable_name> = new JSON(); (this should also work -> JSON <variable_name> = new();)
- example: JSON json = new();

### Using GetJSON method

- json.GetJSON(data.json)

Which file will get picked ??
Simple, it will go as followed

c:\\<path_to_solution_folder>\\data.json

So if you do something like:
json.GetJSON(folder_name/data.json)

It will go like this

c:\\<path_to_solution_folder>\\folder_name/data.json

Easy, right? :D

> [!WARNING]  
> NOT COMPLETE YET!!
