# A BrainF Interpreter Written in C#

## Setup

1. To use this project, first clone this repo onto your local machine:
```sh
git clone https://github.com/classPythonAddike/BFInterpreter.git
```
2. If you are on a 64-bit Windows computer, you just got lucky! I've already compiled this program, and it can be found in the [Debug Folder](https://github.com/classPythonAddike/BFInterpreter/tree/master/bin/Debug)!
3. If you are not on Windows, or not on a 64-bit machine, you have two options - Use the online repl.it, or build the project yourself.
4. If you want to use the online repl.it, fork [This Repl.it](https://repl.it/@PythonAddictCla/BFInterpreter#ReadMe.md).
5. Once you fork the repl.it, build the project with `csc Program.cs -out:bin/Debug/BFInterpreter.exe`.
6. Then move into the debug folder: `cd bin/Debug`. You can run one of the samples in the BrainFSamples folder, or write your BrainF code!
7. If you don't want to use the Repl.it, you can build it on your local machine. This can be done from the terminal, or with an IDE like Mono, Visual Studio Code, Rider, or Visual Studio or ~~Notepad++~~ (assuming you have a C# Compiler)

7. Run your BrainF code with `> BFInterpreter.exe file.bf` where `file.bf` is the file you want to run! However, if you are using repl.it, you'll need to run `mono BFInterpreter.exe sample.bf`!
8. There are a few samples in the [BrainFSamples Folder](https://github.com/classPythonAddike/BFInterpreter/tree/master/bin/Debug/BrainFSamples). These are taken from various sources off the internet!

## Update:
There are now two ways to write comments in BrainF:
1. Just writing any character other than BrainF command. The Interpreter will ignore such a character and move on.
2. However, if your comments include a BrainF command, you can place it in between two forward slashes. Example:
```bf
+++--+->>++-.
/This is a weird comment. . . ./
<<.
```

~~A big thank you to @classPythonAddike for making this repo possible!~~
