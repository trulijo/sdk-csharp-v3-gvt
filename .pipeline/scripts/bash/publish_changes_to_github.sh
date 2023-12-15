#!/usr/bin/env bash
set -e

source_repo_url=$1
source_branch=$2
target_repo_url=$3
target_branch=$4
commit_title_message="$5"

echo "[DEBUG] PR_SOURCE_BRANCH=$PR_SOURCE_BRANCH"
echo "[DEBUG] target_branch=$target_branch"

mkdir publish_workspace
pushd publish_workspace

git clone $source_repo_url source_repo
git clone $target_repo_url target_repo

mkdir .target_locker
pushd target_repo
git branch --copy "$target_branch"
git switch "$target_branch"
# preserve the files should not be changed
mv .git .gitignore .editorconfig ../.target_locker
# delete all to make sure code deletion on source_repo side is applied
shopt -s dotglob
rm -fr *
popd

mkdir .source_locker
pushd source_repo
git switch "$source_branch"
# exclude file should be not published
mv .git .gitignore .editorconfig ../.source_locker
popd

# copy code from source repo
cp -a source_repo/. target_repo
# restore preserved files
mv .target_locker/* target_repo

pushd target_repo
git add --all

if git status --short | wc -l | xargs -I ? test ? -eq 0
then
    echo "[WARN] No effective change! Stop publish change to Github!"
    exit 1
fi

commit_title=$(jq 'fromjson | .[-1].title' <<<"$commit_title_message")

git config user.name "$GITLAB_USER_LOGIN"
git config user.email "$GITLAB_USER_EMAIL"
git commit --message "$commit_title" --message "$commit_title_message"

git push --set-upstream origin "$target_branch"
popd
