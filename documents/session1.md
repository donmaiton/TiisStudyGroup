# プロジェクトを構築しよう

アプリケーション事態はクロスプラットフォームで開発できますが、ドキュメント作成効率のためにWindows端末のみをターゲットとします。
MacやLinuxは公式情報を参考に構築してください。

## 必要環境

+ Windows10

## 利用ソフトウェア

+ dotnetcore 2.2.108
+ git 2.23.0.windows.1
+ Visual Studio Code 1.38.0
+ C# for Visual Studio Code

利用ソフトウェアはセッションをこなしていくうちに増えていきます。
初期導入として上記3つを導入します。

## プロジェクトセットアップ

+ プロジェクトの作成
  
  ``` bash
  git clone https://github.com/donmaiton/TiisStudyGroup.git
  cd TiisStudyGroup
  cd src
  cd study
  dotnet new mvc -o Study
  code -r Study
  ```

+ 動作確認
  VSCodeで`src/study/Study/Program.cs`を開いて`Ctrl+F5`
