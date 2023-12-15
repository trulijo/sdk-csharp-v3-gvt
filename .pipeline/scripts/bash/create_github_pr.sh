#!/usr/bin/env bash
set -e

github_owner=$1
github_repo=$2
pr_source_branch=$3
pr_target_branch=$4
pr_title="$5"
additional_message="$6"

echo "[DEBUG] pr_title=$pr_title" >&2

pr_body="
Merge branch '$pr_source_branch' into '$pr_target_branch'
$pr_title
$additional_message
"
echo "[DEBUG] pr_body=$pr_body" >&2

post_json_data=$(
    jq --null-input \
       --arg pr_title "$pr_title" \
       --arg pr_body "$pr_body" \
       --arg pr_source_branch "$pr_source_branch" \
       --arg pr_target_branch "$pr_target_branch" \
       '{title:$pr_title, body: $pr_body, head: $pr_source_branch, base: $pr_target_branch}' |
        tee /dev/stderr
)

# create pull request
resp=$(
    # https://docs.github.com/en/rest/pulls/reviews?apiVersion=2022-11-28#create-a-review-for-a-pull-request
    # gitlab runner has an issue with http2 with Github API
    curl --location --no-progress-meter \
         --http1.1 \
         --request POST \
         --header "Accept: application/vnd.github+json" \
         --header "Authorization: Bearer $GITHUB_ACCESS_TOKEN" \
         --header "X-GitHub-Api-Version: 2022-11-28" \
         --url "https://api.github.com/repos/$github_owner/$github_repo/pulls" \
         --data "$post_json_data" |
        tee /dev/stderr
)

# show pull request url created
jq --raw-output '.url' <<<"$resp" |
    xargs echo "[INFO] The pull request url:" >&2
