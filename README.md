# kata-skeleton
Test skeletons in a few language for rapid training through katas

Some git tricks for using this repo:

This repository is intended to allow you to quickly reset to a clean state. 
Just run `git reset --hard`
This will PERMANENTLY delete any changes you made, so only run it when you are sure you don't want your work anymore. Otherwise, just run `git stash` and later `git stash pop` to get it back.

If you want to create a saved version of your work, create a new branch with `git checkout -b NAME-OF-BRANCH` and commit there. Be sure to checkout master after your commit.

If you accidently commit to master, you can `git revert` to reverse your commit, `git reset --hard COMMIT-SHA-HASH` if you know the SHA hash, or just reclone the repo: https://github.com/hunter-tobywhughes/kata-skeleton

Recommended Exercism Order:
- Raindrops
- Grains
- Simple Linked List (don't just use built-in linked list. Think OOP.)

Repeat each exercise multiple times on multiple languages. These are supposed to be Katas, repeated until it becomes like second nature.