
Step 1 - LOCAL step:
Open Local CMD or Terminal and go to Desktop folder in it. Run below command to create a new folder for tests:

  dotnet new xunit -o webUITest -f net6.0 

The above command will create a new folder in your desktop. Open the folder in any IDE that you use. (Ex: Visual Studio)

In this folder, you will find UnitTests.cs file. Rename it to CartTests.cs

In the new file, make sure you copy/paste the below content:

  using OpenQA.Selenium;
  using OpenQA.Selenium.Edge;

  namespace webstoreUITests
  {
      public class CartTest : IDisposable
      {
          private readonly IWebDriver driver;
          private readonly string url;
          public CartTest()
          {
              url = Environment.GetEnvironmentVariable("testUrl") ?? "";
              driver = new EdgeDriver();
          }
          public void Dispose()
          {
              driver.Quit();
          }
          [Fact]
          public void CartPage_ShouldDisplayCorrectProductAndPrice()
          {
              driver.Navigate().GoToUrl(url);
              var productElement = driver.FindElement(By.TagName("p"));
              var priceElement = driver.FindElement(By.XPath("//p[2]"));
              Assert.Equal("Here's your shopping cart: Koala", productElement.Text);
              Assert.Equal("Price: $29", priceElement.Text);
          }
      }
  }

Once the above steps are completed, run the below commands to add the package locally:

  dotnet add package Selenium.WebDriver

  Linux: 
 
  export testUrl="https://web1-webstore-app-afa7hygcf4cva8gy.centralus-01.azurewebsites.net/Cart"

  In windows:

  set testUrl="https://web1-webstore-app-afa7hygcf4cva8gy.centralus-01.azurewebsites.net/Cart"

Run the final command:

  dotnet test

Both the tests should be passed.

Create a new repository in the Azure DevOps project and push the new folder webUITest content into it. 

To add gitignore file:

  dotnet new gitignore 

Once new gitignore file add, COmmit and push the changes again to the new repo. 


Step 2 - YAML Pipeline (Mandatory):

Import this is git repo into your Azure DevOps as new repository - https://github.com/SairamSunkaranam/webstore

Create Pipeline and try it. 


  
  


