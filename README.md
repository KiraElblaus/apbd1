Task 5
This merge was not a fast-forward merge because the main branch received a new, independent commit after the feature-max branch was created. Because the histories of the two branches diverged, Git could not simply move the main pointer forward. Instead, it had to perform a true merge (a 3-way merge) and create a dedicated 'merge commit' to combine the separate changes.

Task 7
1.
Fast-forward: Git performs a fast-forward merge when the target branch has not had any new commits since the feature branch diverged from it. Here Git simply moves the branch pointer forward to the latest commit

Merge Commit: A merge commit is created when both the target branch and the feature branch have new, diverging commits (they are different). Git creates a brand new commit (with two parents) that ties those two histories together

2.
Merge: Preserves the exact history of a project as it happened. It takes all the changes from one branch and merges them into another via a new merge commit. It is a safe way to connect different branches into one

Rebase: Rewrites project history by taking the commits from the feature branch and reapplying them one by one on top of the target branch. This creates a much cleaner history, but it creates entirely new commit hashes, so it is dangerous to rebase branches that are already shared with a team

3.
After trying to merge the branch feature-conflict into the master branch, a specific tab was displayed. I needed to agree to either of the change (choose the one from the two changes). I agreed to the feature-conflict change, so it was accepted and successfully merged into the master branch