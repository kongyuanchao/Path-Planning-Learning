https://blog.csdn.net/Yaoyao2024/article/details/132123525

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git status
On branch master

No commits yet

nothing to commit (create/copy files and use "git add" to track)

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git init
Reinitialized existing Git repository in C:/Users/Administrator/UnityProject/Test/.git/

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git add .

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git status
On branch master

No commits yet

Changes to be committed:
  (use "git rm --cached <file>..." to unstage)
        new file:   Readme.txt
        new file:   config


Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git commit -m "init Project"
[master (root-commit) c3ec659] init Project
 2 files changed, 9 insertions(+)
 create mode 100644 Readme.txt
 create mode 100644 config

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git remote add origin git@github.com:kongyuanchao/Path-Planning-Learning.git

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git push -u origin master
Enumerating objects: 4, done.
Counting objects: 100% (4/4), done.
Delta compression using up to 16 threads
Compressing objects: 100% (3/3), done.
Writing objects: 100% (4/4), 390 bytes | 390.00 KiB/s, done.
Total 4 (delta 0), reused 0 (delta 0), pack-reused 0
remote:
remote: Create a pull request for 'master' on GitHub by visiting:
remote:      https://github.com/kongyuanchao/Path-Planning-Learning/pull/new/master
remote:
To github.com:kongyuanchao/Path-Planning-Learning.git
 * [new branch]      master -> master
branch 'master' set up to track 'origin/master'.
