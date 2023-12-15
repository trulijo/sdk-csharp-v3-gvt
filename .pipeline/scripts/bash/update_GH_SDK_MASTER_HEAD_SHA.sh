#!/bin/bash
set -e

GITLAB_API_URL_PROJECTS="https://gitlab.com/api/v4/projects"
GITLAB_VARIABLE_NOT_FOUND="{\"message\":\"404 Variable Not Found\"}"

get_project_cicd_variable() {
    # function arguments
    local project_id="$1"
    local variable_name="$2"
    #
    resp=$(
        curl --no-progress-meter \
             --request GET \
             --header "PRIVATE-TOKEN: $ACCESS_TOKEN" \
             --header "Content-Type: application/json" \
             --url "$GITLAB_API_URL_PROJECTS/$project_id/variables/$variable_name"
    )
    if [ "$resp" == "{\"message\":\"404 Variable Not Found\"}" ]
    then
        echo "$resp"
    else
        jq -r ".value" <<<"$resp"
    fi
}

update_project_cicd_variable() {
    # function arguments
    local project_id="$1"
    local variable_name="$2"
    local variable_value="$3"
    #
    local project_api_url="$GITLAB_API_URL_PROJECTS/$project_id"

    # https://docs.gitlab.com/ee/api/projects.html#edit-project
    curl --no-progress-meter \
         --request PUT \
         --write-out "\n%{http_code}\n" \
         --header "PRIVATE-TOKEN: $ACCESS_TOKEN" \
         --url "$project_api_url/variables/$variable_name" \
         --form "value=$variable_value" \
         --form "protected=false" \
         --form "masked=false" \
         --form "raw=true"
} >&2

export ACCESS_TOKEN="$PUBLIC_SDK_PROJECT_MAINTAINER_API_TOKEN"

project_id="$CI_PROJECT_ID"
variable_name="GH_SDK_MASTER_HEAD_SHA"
variable_value="$1"

update_project_cicd_variable "$project_id" "$variable_name" "$variable_value" >&2
