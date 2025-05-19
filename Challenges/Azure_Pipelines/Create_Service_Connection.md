
Note: In a parallel broswer tab, please login into https://portal.azure.com with the same email id that you have configured Azure DevOps. 

Step 1: (Azure DevOps)
  
  Go to your Azure DevOps orgnization - https://aex.dev.azure.com
  Navigate to your project -> click on Project Setting (left bottom) -> click service connections under Pipelines

  Click on "New Service Connection" 

  ![image](https://github.com/user-attachments/assets/e948efee-0692-459d-bdb2-d5ce7a1fb413)

  Choose "Azure Resource Manager" and Click Next

  <img width="504" alt="image" src="https://github.com/user-attachments/assets/cd1468bc-fd38-4fa6-9c2c-98d47560ab64" />

Step 2: (Azure Portal)

  Before you enter the details in the next window, please go to your Azure Portal and search for "Tenant Properties" in the search bar. 

  Please copy the tenant id from the properties:
  
  ![image](https://github.com/user-attachments/assets/ca880a77-919e-429d-b6ab-15f8f6eb117a)

Step 3: (Azure DevOps)

  Comback to Azure DevOps and Fill the details as showed in below and click Next. 

  Note: Make sure you paste the tenant id that you copied earlier

  ![image](https://github.com/user-attachments/assets/97274502-2d3e-486d-94c0-0645550fbb34)

  Once you click next, you will be presented with some details. Don't referesh your screen and keep the broswer tab as it is until we complete the next step. 

Step 4: (Azure Portal)

  Please navigate to the Azure Portal to complete this step. 

  Search for "App Registrations" in the search bar. Once you are in the app registration page, click on "New Registration"

  ![image](https://github.com/user-attachments/assets/bde13cbb-7609-46be-aa4e-d0ac19fe96b5)

  Give a name to the application and choose the option "Accounts in this organizational directory only (Default Directory only - Single tenant)". 
  
  Click on "Register" 

  <img width="959" alt="image" src="https://github.com/user-attachments/assets/978c8db8-47e4-4eef-992b-b33b25ddd4e6" />

  In the next screen, select "Certificates & Secrets" -> Federated Credentails -> Click on "Add Credential" 

  <img width="1386" alt="image" src="https://github.com/user-attachments/assets/fcbfcdca-f18b-4318-a276-d190d1be3af2" />

  Please select the "Other issuer" in the type of the secret.

  <img width="970" alt="image" src="https://github.com/user-attachments/assets/389f71b5-5b15-4c01-8ecd-f0af98db3a2c" />

  Here you need to fill the "Issuer" and "Value". These values are already created and kept intact in Step 3. 

  Please navigte back to the Azure DevOps. Copy paste the details as showned below in your secret:

  <img width="970" alt="image" src="https://github.com/user-attachments/assets/fa804ae3-d242-44da-baac-ca229c98217a" />

  Give a meaning name to the secret and Click on "Add". 

Step 5: (Azure Portal)

  Note: Please be in the Azure portal site
  
  We have Registerd the app and created the Secret. Now, we need to provoide the permissions to app, so that it can talk to our subscription. 
  Follow below steps to achieve this:

  Search for 
    1. "Subscription" in the search bar 
    2. Click on the Subscription that you can see 
    3. Click "Access Control" under subscription
    4. Click on "+Add" symbol in the screen and choose "Add Role assignment"

  <img width="1385" alt="image" src="https://github.com/user-attachments/assets/e71df674-fd73-40a6-8f62-42b66c396f00" />

  In the next screen, Under Roles, Choose "Previliged roles" and select contributor. Click Next.

  <img width="1380" alt="image" src="https://github.com/user-attachments/assets/0d260141-b421-42c3-83f4-188bbb038b8c" />

  In the next screen, Click on "Select Members" and search for your app in the box and select the app and click on "Select".
    
  <img width="1430" alt="image" src="https://github.com/user-attachments/assets/24ecbcf0-f5d3-4215-8339-e8939d4425c5" />

  Click "Review + Assign" two times and this step will be completed. 


Step 6: (Azure DevOps)

  This is the last step in the process. Navigate back to Azure DevOps and you must be on the page, where we left in Step 3.

  To provide the Subscription ID, 
  please navigate to Azure portal -> Search for subscriptions -> Click on the subscriptions -> Copy the subscription id in the details.

  Once you copied, paste that in the "Subscription id" in DevOps portal.

  For the Subscription name,
  please navigate to Azure portal -> Search for subscriptions -> Click on the subscriptions ->  Copy the subscription name

  Once you copied, paste that in the "Subscription name" in DevOps portal.

  For the application application id,

  please navigate to Azure portal -> Search for "App Registration" -> Click on the "All Applications" ->  Copy the Application id of your application as shown below:

  <img width="1225" alt="image" src="https://github.com/user-attachments/assets/52c0287d-9570-4c0a-accf-753c8ff85124" />

  Once you copied, paste that in the "Application (Clinet) ID" in Devops portal. 

  Finally, you should check on "Grant Access Permissions to all pipelines" and Click on "Verify and Save".


If you have done all steps correctly, you should have a new service connection in your connection list. 
  
  



  





