# json-handler-C-
this is my json handler for c# if there are any errors or problems tell me

## how to get the json handler

1. download the zip
2. unpack it
3. place the JSON.cs file in your solution
4. in the file you want to use the JSON handler type as top-level statement (so the statement at the top of your page) "using JSON = jsonHandler.JSON;"
5. done

## how to use the json handler

### creating a JSON instance
- JSON <variable_name> = new JSON(); (this should also work -> JSON <variable_name> = new();)
- example: JSON json = new();

### using GetJSON method
- json.GetJSON(data.json)

which file will get picked ??
simple it will go as followed

c:\\<path_to_solution_folder>\\data.json

so if you do something like:
json.GetJSON(folder_name/data.json)

it will go like this 

c:\\<path_to_solution_folder>\\folder_name/data.json


easy, right? :D

NOT COMPLETE YET!!
