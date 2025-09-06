#!/bin/bash

# Prompt for commit message
read -p "Enter commit message: " commit_msg

# Add all changes
git add .

# Commit with the message
git commit -m "$commit_msg"

# Push to the current branch
git push
