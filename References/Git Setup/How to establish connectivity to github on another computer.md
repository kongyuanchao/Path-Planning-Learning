Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git init
Initialized empty Git repository in C:/Users/Administrator/UnityProject/Test/.git/

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git status
On branch master

No commits yet

nothing to commit (create/copy files and use "git add" to track)

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ ssh-keygen -t rsa -C "kongyuanchao@hotmail.com"
Generating public/private rsa key pair.
Enter file in which to save the key (/c/Users/Administrator/.ssh/id_rsa):
Created directory '/c/Users/Administrator/.ssh'.
Enter passphrase (empty for no passphrase):
Enter same passphrase again:
Your identification has been saved in /c/Users/Administrator/.ssh/id_rsa
Your public key has been saved in /c/Users/Administrator/.ssh/id_rsa.pub
The key fingerprint is:
SHA256:8S7DgkiSLpfgaZmzyAevvKPjp7V7lHZ3tZEwnZFAVdY kongyuanchao@hotmail.com
The key's randomart image is:
+---[RSA 3072]----+
|          .o+o=o.|
|           o +. E|
|        .   o .  |
| .       o   +   |
|+ .   . S . . o  |
|o=+o = o o . .   |
|.O*.+ o = o      |
|Bo++.. . o       |
|=XBoo            |
+----[SHA256]-----+

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ cd..
bash: cd..: command not found

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ cd ..

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject (master)
$ cd ..

Administrator@DESKTOP-MUL01AJ MINGW64 ~
$ cd .ssh

Administrator@DESKTOP-MUL01AJ MINGW64 ~/.ssh
$ dir
id_rsa  id_rsa.pub

Administrator@DESKTOP-MUL01AJ MINGW64 ~/.ssh
$ list
bash: list: command not found

Administrator@DESKTOP-MUL01AJ MINGW64 ~/.ssh
$ ls
id_rsa  id_rsa.pub

Administrator@DESKTOP-MUL01AJ MINGW64 ~/.ssh
$ cd UnityProject/Test
bash: cd: UnityProject/Test: No such file or directory

Administrator@DESKTOP-MUL01AJ MINGW64 ~/.ssh
$ cd UnityProject
bash: cd: UnityProject: No such file or directory

Administrator@DESKTOP-MUL01AJ MINGW64 ~/.ssh
$ cd ..

Administrator@DESKTOP-MUL01AJ MINGW64 ~
$ cd UnityProject

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject (master)
$ cd Test

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git status
On branch master

No commits yet

nothing to commit (create/copy files and use "git add" to track)

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git remote add origin git@github.com:kongyuanchao/Path-Planning-Learning.git

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git pull origin main
ssh: connect to host github.com port 22: Connection timed out
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git clone https://github.com/kongyuanchao/Path-Planning-Learning.git
Cloning into 'Path-Planning-Learning'...
remote: Enumerating objects: 18, done.
remote: Counting objects: 100% (18/18), done.
remote: Compressing objects: 100% (16/16), done.
remote: Total 18 (delta 5), reused 8 (delta 1), pack-reused 0
Receiving objects: 100% (18/18), 6.99 KiB | 6.99 MiB/s, done.
Resolving deltas: 100% (5/5), done.

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ nslookup github.com
Non-authoritative answer:
Server:  UnKnown
Address:  192.168.0.1

Name:    github.com
Address:  20.205.243.166


Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git pull origin main
The authenticity of host '[ssh.github.com]:443 ([20.205.243.160]:443)' can't be established.
ED25519 key fingerprint is SHA256:+DiY3wvvV6TuJJhbpZisF/zLDA0zPMSvHdkr4UvCOqU.
This key is not known by any other names.
Are you sure you want to continue connecting (yes/no/[fingerprint])? yes
Warning: Permanently added '[ssh.github.com]:443' (ED25519) to the list of known hosts.
git@ssh.github.com: Permission denied (publickey).
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ ssh -T git@github.com
Hi kongyuanchao! You've successfully authenticated, but GitHub does not provide shell access.

Administrator@DESKTOP-MUL01AJ MINGW64 ~/UnityProject/Test (master)
$ git pull origin main
remote: Enumerating objects: 18, done.
remote: Counting objects: 100% (18/18), done.
remote: Compressing objects: 100% (16/16), done.
remote: Total 18 (delta 5), reused 8 (delta 1), pack-reused 0
Unpacking objects: 100% (18/18), 6.97 KiB | 246.00 KiB/s, done.
From github.com:kongyuanchao/Path-Planning-Learning
 * branch            main       -> FETCH_HEAD
 * [new branch]      main       -> origin/main
