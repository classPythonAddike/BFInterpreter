# A BrainF Interpreter Written in C#

## Setup

1. To use this project, first clone this repo onto your local machine:
```sh
git clone https://github.com/classPythonAddike/BFInterpreter.git
```
2. If you are on a 64-bit Windows computer, you just got lucky! I've already compiled this program, and it can be found in the [Debug Folder](https://github.com/classPythonAddike/BFInterpreter/tree/master/bin/Debug)!
3. However, if you are not on Windows, or not on a 32-bit computer, you'll need to build this project again. You can do this from the terminal, or with an IDE like Mono, Visual Studio Code, Rider, or Visual Studio ~~or Notepad++~~
4. Run your BrainF code with `> BFInterpreter.exe file.bf` where `file.bf` is the file you want to run!
5. There are a few samples in the [BrainFSamples Folder](https://github.com/classPythonAddike/BFInterpreter/tree/master/bin/Debug/BrainFSamples). These are taken from various sources off the internet!

## Update:
There are now two ways to write comments in BrainF:
1. Just writing any character other than BrainF command. The Interpreter will ignore such a character and move on.
2. However, if your comments include a BrainF command, you can place it in between two forward slashes. Example:
```bf
+++--+->>++-.
/This is a weird comment. . . ./
<<.
```Ṭ

~~A big thank you to @classPythonAddike for making this repo possible!~~
