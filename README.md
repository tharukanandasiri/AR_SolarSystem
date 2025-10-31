# AR_SolarSystem

An educational Augmented Reality (AR) application for Android, built with Unity 6 and Vuforia. Point your device's camera at a marker image to display an interactive 3D solar system. Features a UI button to toggle planetary orbits, with each planet moving at a unique, realistic relative speed. This project uses the Universal Render Pipeline (URP).

## Git LFS (Large File Storage)

This repository uses Git LFS to store large binary assets (FBX models, native libraries, package archives, and some Library artifacts). Before cloning or contributing, please install Git LFS and enable it for your Git client.

Install and enable Git LFS (Windows / PowerShell):

```powershell
choco install git-lfs    # or download from https://git-lfs.github.com
git lfs install
```

Clone the repository (recommended) after installing Git LFS so large files are pulled correctly:

```powershell
git clone https://github.com/tharukanandasiri/AR_SolarSystem.git
```

If you already have the repo cloned, run `git lfs install` and then `git lfs pull` to fetch LFS objects for your current checkout.

---

## Important: recovering local branches after history rewrite

Note: The repository history was rewritten to migrate large files into Git LFS and the rewritten history was force-pushed to `origin/main`. If you cloned this repo before that change, your local branch history will diverge from the remote. You do NOT need to reclone in every case — follow the safe recovery steps below depending on whether you have local (unpushed) work.

1. If you have no local changes or unpushed commits on `main` (easy):

```powershell
git fetch origin
git checkout main
git reset --hard origin/main
git lfs pull
```

2. If you have local commits on `main` that you want to preserve (recommended: create a backup branch first):

```powershell
# make a backup branch pointing to your current work
git branch local-main-backup

# fetch the rewritten remote history
git fetch origin

# reset your local main to the new remote main
git checkout main
git reset --hard origin/main
git lfs pull

# rebase your local work onto the updated main
git checkout local-main-backup
git rebase origin/main

# if the rebase succeeds, push your branch (do not force-push main)
git push -u origin local-main-backup

# optionally, create a new branch name for the rebased work:
git checkout -b my-feature-from-rebased-work
```

3. If you prefer to preserve your local commit objects without rebasing (safer if unsure):

```powershell
# create a branch that points to your existing commit history
git branch preserve-local-work

# reset main to the remote (rewritten) history
git fetch origin
git checkout main
git reset --hard origin/main
git lfs pull

# your local work is safe on the 'preserve-local-work' branch
git checkout preserve-local-work
# examine, cherry-pick or rebase individual commits onto origin/main as needed
```

If you run into conflicts while rebasing, resolve them as usual (`git add <files>` then `git rebase --continue`). If you're unsure, keep the backup branch and ask for help — I can prepare tailored steps for your exact local state.

---
