

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git init
Reinitialized existing Git repository in C:/Users/Administrator/UnityProject/Test/.git/

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git status Test
On branch main
Your branch is ahead of 'origin/master' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git add -- all
fatal: pathspec 'all' did not match any files

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git add --all

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git commit -m "Update 011701"
On branch main
Your branch is ahead of 'origin/master' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git push origin main
To github.com:kongyuanchao/Path-Planning-Learning.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'github.com:kongyuanchao/Path-Planning-Learning.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git push origin master
error: src refspec master does not match any
error: failed to push some refs to 'github.com:kongyuanchao/Path-Planning-Learning.git'

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git branch -M main

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git push origin main
To github.com:kongyuanchao/Path-Planning-Learning.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'github.com:kongyuanchao/Path-Planning-Learning.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git branch -M main

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git remote add origin git@github.com:kongyuanchao/Path-Planning-Learning.git
error: remote origin already exists.

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git push -u origin master
error: src refspec master does not match any
error: failed to push some refs to 'github.com:kongyuanchao/Path-Planning-Learning.git'

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git reset --hard origin/master
HEAD is now at c3ec659 init Project

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git add Readme.txt

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git status
On branch main
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   Readme.txt


Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git commit -m "Update 001"
[main b229943] Update 001
 1 file changed, 54 insertions(+)

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git branch -M master

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git push -u origin master
Enumerating objects: 7, done.
Counting objects: 100% (7/7), done.
Delta compression using up to 16 threads
Compressing objects: 100% (6/6), done.
Writing objects: 100% (7/7), 1.26 KiB | 1.26 MiB/s, done.
Total 7 (delta 1), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100% (1/1), done.
remote:
remote: Create a pull request for 'master' on GitHub by visiting:
remote:      https://github.com/kongyuanchao/Path-Planning-Learning/pull/new/master
remote:
To github.com:kongyuanchao/Path-Planning-Learning.git
 * [new branch]      master -> master
branch 'master' set up to track 'origin/master'.

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git checkout master
Already on 'master'
Your branch is up to date with 'origin/master'.

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git branch main master -f

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (master)
$ git checkout main
Switched to branch 'main'

Administrator@DESKTOP-R0D2CMD MINGW64 ~/UnityProject/Test (main)
$ git push origin main -f
Total 0 (delta 0), reused 0 (delta 0), pack-reused 0
To github.com:kongyuanchao/Path-Planning-Learning.git
 + 8e01c53...b229943 main -> main (forced update)
