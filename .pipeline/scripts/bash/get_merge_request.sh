#!/usr/bin/env bash
set -e

curl --no-progress-meter \
     --request GET \
     --header "PRIVATE-TOKEN: $GITLAB_ACCESS_TOKEN" \
     --header "Content-Type: application/json" \
     --url "https://gitlab.com/api/v4/projects/$project_id/merge_requests?state=merged"
