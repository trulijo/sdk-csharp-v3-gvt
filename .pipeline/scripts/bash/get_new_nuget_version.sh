#!/bin/bash
set -e

latest_nuget_version="$1"

latest_nuget_patch_version=$(grep -o "[0-9]\+$" <<<"$latest_nuget_version")
new_nuget_version=$(grep -o "^[0-9.]\+\." <<<"${latest_nuget_version}")$((latest_nuget_patch_version + 1))

echo "$new_nuget_version"