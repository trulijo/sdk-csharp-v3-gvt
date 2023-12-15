#!/usr/bin/env bash
set -e

project_id=$1

curl --no-progress-meter \
     --request GET \
     --header "PRIVATE-TOKEN: $GITLAB_ACCESS_TOKEN" \
     --header "Content-Type: application/json" \
     --url "https://gitlab.com/api/v4/projects/$project_id" |
    jq
