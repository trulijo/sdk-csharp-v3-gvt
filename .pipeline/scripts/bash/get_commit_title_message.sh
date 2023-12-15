#!/usr/bin/env bash
set -e

project_id=$1
commit_sha=$2

commit_0=$(
    curl --no-progress-meter \
         --request GET \
         --header "PRIVATE-TOKEN: $GITLAB_ACCESS_TOKEN" \
         --header "Content-Type: application/json" \
         --url "https://gitlab.com/api/v4/projects/$project_id/repository/commits/$commit_sha"
)
echo "[DEBUG] commit_0=$commit_0" >&2

project_path=$(
    .pipeline/scripts/bash/get_project_info.sh "$project_id" |
        jq --raw-output '.path_with_namespace'
)

merge_request_iid=$(
    jq --raw-output '.message' <<<"$commit_0" | {
        grep "See merge request $project_path\![0-9]\+$" || true; } | {
        grep -o '[0-9]\+$' || true; }
)
echo "[DEBUG] merge_request_iid=$merge_request_iid" >&2

if test -n "$merge_request_iid"
then
    ## get merge request title as github commit title
    #curl --no-progress-meter \
    #     --request GET \
    #     --header "PRIVATE-TOKEN: $GITLAB_ACCESS_TOKEN" \
    #     --header "Content-Type: application/json" \
    #     --url "https://gitlab.com/api/v4/projects/$project_id/merge_requests/$merge_request_iid" |
    #    jq --raw-output '.title'

    # get the title and message of the commit(s) in the merge request
    curl --no-progress-meter \
         --request GET \
         --header "PRIVATE-TOKEN: $GITLAB_ACCESS_TOKEN" \
         --header "Content-Type: application/json" \
         --url "https://gitlab.com/api/v4/projects/$project_id/merge_requests/$merge_request_iid/commits" |
        jq 'length as $size | [ to_entries[] | { commit_no: ($size - .key), original_sha: .value.id, title: .value.title, message: .value.message } ] | tostring' |
        tee /dev/stderr
else
    # get the title of the push commit
    jq '[ { commit_no: 1, original_sha: .value.id, title: .title, message: .message } ] | tostring' <<<"$commit_0" |
        tee /dev/stderr
fi
