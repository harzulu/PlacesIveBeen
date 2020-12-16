# Places I've Been

#### This application will allow a user to create an online travel diary, 12.16.2020

#### By Ben McFarland & Kaila Sprague McRae

## Description

This application will allow a user to create an online travel diary.

## Technologies used

* Microsoft Visual Studio Code
* Git/GitHub
* C# v 7.3
* .NET Core v 2.2
* REPL
* MSTest
* ASP.NET MVC

## Installation Requirements

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/harzulu/PlacesIveBeen], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/harzulu/PlacesIveBeen`.


#### Installing C#, .NET, dotnet script, & MySQL

###### This program requires C# and the .NET Framework to be installed on your machine:

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download this 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :---------------------------- |
| **Can create instance of 'Place' object** | Place place = new Place(); | typeof(place) == Place |
| **Return given city name** | "Portland" | "Portland" |
| **Return given durration (in days)** | `8` | `8` |
| **Return names of who you travelled with** | `{"person one", "person two", "person three"}` | `{"person one", "person two", "person three"} `|
| **Return given description of trip** | "We went to downtown and to the river" | "We went to downtown and to the river" |


### Tests

Describe: Place()
Test: Can create instance of 'Place' object
Expect: Assert.AreEqual(Place, typeof(Place()))

Describe: Place(string cityName)
Test: Return given city name
Expect: Assert.AreEqual('Portland', Place('Portland'))

Decribe: Place(int durration)
Test: Return given durration (in days)
Expect: Assert.AreEqual(8, Place(8))

Describe: Place(List<string> buddies)
Test: Return List of names iser travelled with
Expect: Assert.AreEqual({"person one","person two", "person three"}, Place({"person one","person two", "person three"}))

Describe: Place(string description)
Test: Return given descriptoin of trip
Expect: Assert.AreEqual("We went to downtown and to the river", Place("We went to downtown and to the river"))

## Bugs / Issues

No known bugs or issues

### License & Copyright

_MIT_ Copyright (c) 2020 *_Ben McFarland & Kaila Sprague McRae_*