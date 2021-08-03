## Version Control System
- We use VCSs to collaborate as a team of programmars, track changes, do code review and much more...
- This can be of 2 types
	- Distributed VCS
		- Github, BitBucket, Gitlab etc...
	- Centralized VCS
		- TFS, VSTS, SVN
# Git
## Basic Git and commands
- `cd 'path'` -> change directory
- `cd ..` -> moves a level up
	- use arrow keys to see history of previously use commands
	- history -> gives a track of all commands you have used in the current session
- `cd ./ tab key` -> gives the auto-completion of the file/directory
- `ls` -> list all the files and directories
- `mkdir 'directory name'` -> make directory
- `touch 'file name.extension'` -> creates a file
- `git clone 'url'` -> adds the local workspace in your machine
- `git add` -> adds the file you target to add to git
- `git add -A` -> adds all the file
- `git commit -m 'message'` -> Stage changes and commit to git as a new node
- `git push` -> push changes to git server
- `git status` -> see the new tracks/ changes made in local workspace
- `git pull` -> retrieve changes from the git server (updates your workspace with latest code)
- `pwd` -> print where directory

### Demo	
- `cd C:/Training`   - to navigate to a directory
- `cd Neosoft/`
- `git clone https://github.com/Tech-Training-2021/Neosoft-dotnet` - to make a local copy of the repo
- `cd training-code/`
- `mkdir 01` - create a folder/directory
- `cd 01/`
- `touch Notes.md` - create a file
- `notepad Notes.md` - open the file with notepad
	- add some content
- `git status` - to check changes if any
- `git add` . - stage the changes in all the file(s)
- `git commit -m 'add notes for git basics'` - create a tracking node
- `git push` - add changes to git origin/server
- `git pull` - to get changes from the server
- `git branch` - tells you how many branches you have and which branch are you current;y pointing to.
- `git checkout -b feature-pushpinder` - creates a new branch `feature-pushpinder` and switch it as a working branch.
- git add -> commit -> git push
- make a Pull Request for code review
-'git vcs' -VCS are sometimes known as SCM (Source Code Management) tools or RCS (Revision Control System). One of the most popular VCS tools in use today is called Git.


