
git clone <webstore-url>

#pre-req
#download .NET to your machine using the link - https://dotnet.microsoft.com/en-us/download/dotnet/6.0

dotnet new classlib -n StoreCore -f net6.0

cd StoreCore

#Open StoreCore folder in IDE Ex: VisualStuido

Rename the Class1.cs to ShippingCalculator.cs and overwrite the existing code with the code in ShippingCalculator.cs file given in this folder

#Open Webstore folder in IDE

Then overwrite ausemartweb.csproj and Pages/Cart.cshtml with the files given here. 

#Open the terminal of the Webstore folder in IDE or in CMD or local terminal or git bash to run the below commands:

dotnet restore

dotnet build

dotnet run 

#If everything went fine, you will be provided with a link to visit the website. Copy & paste the link in the broswer. Ignore and proceed in case of any warning. 

#Now we are going to upload the StoreCore as new repository to the Azure DevOps. To do that, follow below things:

#Create a new repository in Azure DevOps and name it StoreCore
#Open the local terminal where you have the StoreCore and run below commands

git init

git add remote <your remote repo branch>

#Now, add a new file with name .gitignore file with the content given in the .gitignore file in this folder

#Now, you can commit and push it to the new repo. 



