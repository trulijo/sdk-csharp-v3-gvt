#!/bin/bash
set -e

latest_nuget_version=$(
  curl "https://www.nuget.org/api/v2/Search()?&searchTerm=%27${NUGET_PACKAGE_ID}%27&includePrerelease=false&semVerLevel=2.0.0" |
      grep -o "<id>[^<>]\+Id='$NUGET_PACKAGE_ID'[^<>]\+</id>" |
      grep -o "Version='[0-9.]\+'" |
      grep -o "[0-9.]\+"
)

echo "$latest_nuget_version"