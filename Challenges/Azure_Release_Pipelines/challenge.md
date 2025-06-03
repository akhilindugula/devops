#Login into Azure portal -> portal.azure.com
# Click on Azure Shell as shown in below picture and choose bash on the promt
![image](https://github.com/user-attachments/assets/12c14a7c-7b36-4bf8-9f29-592f446354ac)

#Choose no storage required and select your subscription. Click on Apply

#Copy/paste the below details in the Azure Terminal

  location="centralindia" 
  rg="web1-rg"
  planName="web1-plan"
  appName="web1-webstore-app"

#Run below command to create resource group:

  az group create --name web1-rg --location $location

#To register the web resource provider:

  az provider register --namespace Microsoft.Web

#Create a app-service plan in cental us using console

#Create App service using app service plan:

  az webapp create --name $appName --resource-group $rg --plan $planName --runtime "DOTNETCORE:8.0"


