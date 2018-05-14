# The Grading Scripts

### Making grading for CSE 30 easier since 2018


#### Introduction

These scripts were born out of a necessity to automate part of the tedious task
that is grading programming assignments for Rick Ord's CSE 30. Each one makes a
small section of the process a bit easier. Feel free to clone this repository
and perform a `git pull` every once in a while to keep up to date with the most
recent changes made to each script/any new scripts added

#### Setup/Usage

To use these scripts, clone this directory into your home directory. That's
actually it.

To use them, either add the path to your home directory into your PATH
environment variable, or just use ./"name of the script" with the directory you
want.

#### Descriptions

The first script `chco` (**ch**eck **co**mpilation), is used to check for
compilation errors/warnings. It goes through the grading directory, making sure
that each user has an empty compilation error file and if a particular file has
values, it will print out that file to you.

The second script `chcr` (**ch**eck **c**o**r**rectness), is used to check the
correctness of each student. It loops through, checking each student for failed
test cases/other important output and will print it out to you. It will also
prompt you to print the detailed results if you want them, but this can be
silenced by using the `-s` command line option. (`-s` for *speedrun mode*).

Lastly, the final script `fs`, will find a particular student that you give it.
It can take both IDs and names, and is useful if you want to contact a student
to reach out to them if they struggled. Not necessary at all though. Keep in
mind that this script ***cannot be run on the pi-clusters***.

Hopefully this trio of scripts makes the grading process for CSE 30 a bit easier
:) Happy grading!

#### Pull Requests

This directory will be maintained (and added to), but pull requests are
(probably) not gonna get considered. Sorry!
