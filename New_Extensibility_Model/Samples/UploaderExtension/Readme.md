The Extension Publisher enables developers to upload extensions to the Visual Studio Marketplace, without leaving the Visual Studio application.


**Features**

- Uploads extensions from Visual Studio.
- Creates a "Properties" folder where the developer can find the publishManifest.json, which contains the information required to upload an extension.
- Creates the extension's Readme.md.
- Allows to upload multiple versions of the extension on Visual Studio Marketplace.
- It saves time by loading data up to the UI from previously published extensions that have a publishManifest.json, and a Readme.md file.


**How to use the Extension Publisher**

1. Create a Publisher profile at the [Visual Studio Marketplace](https://marketplace.visualstudio.com/)and a [Personal Access Token](https://learn.microsoft.com/en-us/azure/devops/extend/publish/command-line?view=azure-devops) from Azure DevOps. 

2. Within Visual Studio, navigate to the Extensions menu, choose 'Manage Extensions,' enter 'Extension Publisher' in the search bar, and proceed to click on 'Install. See the following example to get a better idea:


![Extension.gif](Extension.gif)