# bookmanagement-aspdotnet-study
SolxyzAcademyに掲載されているASP.NET Core講座の課題。
このベースプロジェクトをもとに書籍管理アプリの作成を行います。  

## libmanによるライブラリインストール

js/cssなどのWebフレームワークは、libmanを利用して管理しています。
以下のコマンドを実行することで、必要なライブラリをインターネットからインストールします。

```shell
libman restore
```

libmanがない場合には、以下のコマンドを実行することで利用可能になります。
（devcontainer利用の場合には不要）

```shell
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

Linuxの場合、以下のコマンドを実行してパスを通すことを忘れずに。

```shell
export PATH="$PATH:/home/vscode/.dotnet/tools"
```

## dotnetコマンドによる起動

```shell
dotnet run
```
