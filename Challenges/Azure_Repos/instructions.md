
#Note. If you are facing any issues, while doing this challenge, please watch the video one more time. 

🔐 1. SSH Keys

go to home folder:

    In linux (terminal):

        cd ~
    
    In windows (command promt):

        cd C:/users/<user-name>

Generate SSH key: 
    
    ssh-keygen -t rsa

Add public key to Azure DevOps:

    Go to User Settings > SSH Public Keys

    In Linux -> Paste your ~/.ssh/id_rsa.pub key
    In windiws -> Paste your C:/users/<your-user-name>/.ssh/id_rsa.pub key

Clone using SSH URL:

    git clone git@ssh.dev.azure.com:v3/{organization}/{project}/{repo}

              
🔑 2. Personal Access Token (PAT)

Generate PAT:

    Go to User Settings > Personal Access Tokens
    Create a token with appropriate scopes
    
    Clone or push using HTTPS:

        git clone https://dev.azure.com/{organization}/{project}/_git/{repo}

    Authenticate:

        Use username: anything (e.g., AzureUser)
        Use password: your PAT token

💳 Git Credential Manager

Install Git Credential Manager (GCM) if not already included with Git.

Clone repository using HTTPS:

    git clone https://dev.azure.com/{organization}/{project}/_git/{repo}

Login prompt appears:
    
    Use Microsoft account or Azure AD

GCM securely stores credentials for future use