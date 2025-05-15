
#Create a repository in your git hub account
#Make sure you shouldn't add any readme file or initialize it. 

command to run in your terminal/cmd:

    git clone --bare https://github.com/nginx/nginx.git

    #This will just download the database of the Git repository. It will not download actual files of it. 

    git push --mirror <your git repo url>