# bookmanagement-aspdotnet-study-answer  

bookmanagement-aspdotnet-studyの解答用プロジェクトです。  

## プロジェクトの開始方法

プロジェクトをVisual Studio Code（以降、VS Code）で開きます。

### libmanによるライブラリインストール

js/cssなどのWebフレームワークは、libmanを利用して管理しています。
以下のコマンドを実行することで、必要なライブラリをインターネットからインストールします。

```shell
libman restore
```

#### libmanが未インストールの場合

libmanがない場合には、以下のコマンドを実行することで利用可能になります。  
（devcontainer利用の場合には不要）

```shell
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

Linuxの場合、以下のコマンドを実行してパスを通すことを忘れずに。

```shell
export PATH="$PATH:/home/<ユーザー名>/.dotnet/tools"
```

### MySQLの設定

#### MySQLの準備（未インストールの場合）

MySQLがインストールされていない場合にはインストールします。

devcontainerを使用している場合には、自動でMySQLが起動しています。

#### 設定の変更

「appsettings.json」ファイル内にある接続文字列を、それぞれの実行者の環境に合わせ変更してください。  

### dotnetコマンドによる起動

```shell
dotnet run
```

## アクセス方法

次のURLにアクセスするとログイン画面からスタートできます。  

https://localhost:5001/

アカウントは、次のURLにアクセスすることで確認できます。  
※初回起動時にはユーザーはいませんので、この機能を利用して作成してください。

https://localhost:5001/User
