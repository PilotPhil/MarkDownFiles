```
1.初始化
git init

2.查看同步的远程库列表
git remote -v

3.连接远程库
git remote add 远程库名 远程库地址

4.拉去最新代码到本地
git pull 远程库名 分支名

5.推送本地新代码
git push 远程库名 分支名

6.查看所有分支
git branch --all

7.上传
git add .
git commit -m "xxx"
git push 远程库名 分支名

8.创建分支并切换到分支上
git checkout -b 分支名

9.查看当前分支
git branch

10.切换回master
git checkout master

11.分支合并到master
git merge 分支名
```

## 使用git pull或者git push每次都需要输入用户名和密码很不人性化，耽误时间，解决方法：

```git
git config --global credential.helper store

git pull /git push (这里需要输入用户名和密码，以后就不用啦)
```

