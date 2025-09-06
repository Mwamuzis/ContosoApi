#!/bin/bash

set -e  # Exit on error

# Function to print a line
print_line() {
  echo "----------------------------------------"
}

# Check if current directory is already a Git repo
if [ ! -d ".git" ]; then
  echo "🟡 Git not initialized. Initializing..."
  git init
else
  echo "✅ Git repository already initialized."
fi

# Check if a GitHub remote exists
if ! git remote get-url origin &>/dev/null; then
  echo "🟡 No GitHub remote found. Creating public repository via GitHub CLI..."
  gh repo create --public --source=. --remote=origin --push
else
  echo "✅ GitHub remote 'origin' already configured."
fi

print_line

# Get and show current branch
current_branch=$(git rev-parse --abbrev-ref HEAD)
echo "📍 Current branch: $current_branch"

print_line

# Prompt for commit message
read -p "📝 Enter commit message: " commit_msg

if [ -z "$commit_msg" ]; then
  echo "❌ Commit message cannot be empty. Aborting."
  exit 1
fi

# Stage changes
echo "➕ Staging changes..."
git add .

# Commit changes
echo "📦 Committing changes..."
git commit -m "$commit_msg"

# Push to current branch
echo "🚀 Pushing to branch '$current_branch'..."
git push origin "$current_branch"

print_line
echo "✅ Done! Changes pushed successfully."



#wa

# Get the URL of the 'origin' remote
repo_url=$(git config --get remote.origin.url)

# Convert SSH to HTTPS if needed
repo_url=${repo_url/git@github.com:/https:\/\/github.com\/}
repo_url=${repo_url/.git/}

# Open in default browser (macOS)
open "$repo_url"

# OR (Linux)
xdg-open "$repo_url"

