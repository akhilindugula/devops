You must have Git installed locally on your computer. Download the package from the link - https://git-scm.com/downloads and install it

We will use this local repo in the upcoming Get Started with GitHub demo

Commands/Resources:

    Set your git config:

        User name: git config --global user.name "your name"
        Email: git config --global user.email "your@email.com"

    Create a new folder on your desktop. Initialize a git repository in a new folder: 

        git init

    Download the app to the folder: https://github.com/SairamSunkaranam/devops/raw/refs/heads/main/emartweb.zip

    Unzip the file in the same folder and remove the downloaded .zip file from it. 

    Check the status of the repo: 
    
        git status

    Stage all files: 
            
            git add --all

    Commit to your repo: 
            
            git commit -m "this is my commit message"

    Download git credential manager:

        Windows:

            By default this is packaged as part of GIT CLI installation. YOu don't need additional steps for this. 

        Mac:

            Download and install the package - https://github.com/git-ecosystem/git-credential-manager/releases/download/v2.6.1/gcm-osx-arm64-2.6.1.pkg
    
    Now we will create a link between local repository and remote repository:

        git remote add origin YOUR-GIT 
        #please replace the YOUR-GIT with your repo link

        git push -u origin main

        #If you have installed the Git credential manager, it will popup an window to enter your user name and password of Git Account. 

    


