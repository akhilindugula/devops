
Step 1 - LOCAL step : (Optional)
Open Local CMD or Terminal and go to Desktop folder in it. Run below command to create a new folder for tests:

  dotnet new xunit -o StoreCoreTests -f net6.0 

The above command will create a new folder in your desktop. Open the folder in any IDE that you use. (Ex: Visual Studio)

In this folder, you will find UnitTests.cs file. Rename it to ShippingCalculatorTests.cs

In the new file, make sure you copy/paste the below content:

  using StoreCore
  
  namespace StoreCoreTests
  {
      public class ShippingCalculatorTests
      {
          [Fact]
          public void CalcuatorShippingCost_ReturnsCorrectCost()
          {
              var shippingCalculator = new ShippingCalculator();
              var weight = 10m;
              var expectedCost = 50m;
              var actualCost = shippingCalculator.CalculateShippingCost(weight);
              Assert.Equal(expectedCost, actualCost);
          }
          [Fact]
          public void CalcuatorShippingCost_ThrowsExceptionForNegativeWeight()
          {
              var shippingCalculator = new ShippingCalculator();
              var weight = -5m;
              Assert.Throws<ArgumentException>(() => shippingCalculator.CalculateShippingCost(weight));
          }
        }
    }

Once the code has been placed, please add nuget.config to download the StoreCore from Azure Artifacts. 
Create a new file named nuget.config and navigate to Azure DevOps artifacts, go to StoreCore Artifact and clikc on Conect to Feed.
Copy the xml content and paste it in the file. 

Once the above steps are completed, run the below commands to add the package locally:

  dotnet add package StoreCore --interactive

Have a look at StoreCoreTests.csproj about the dependencies that we use. 

Run the final command:

  dotnet test

Both the tests should be passed.

Create a new repository in the Azure DevOps project and push the new folder StoreCoreTests content into it. 

To add gitignore file:

  dotnet new gitignore 

Once new gitignore file add, COmmit and push the changes again to the new repo. 


Step 2 - YAML Pipeline (Mandatory):

Import this is git repo into your Azure DevOps as new repository - https://github.com/SairamSunkaranam/webstore

Create Pipeline and try it. 


  
  



