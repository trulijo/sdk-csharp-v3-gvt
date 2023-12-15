#!/bin/bash

set -e

appVersion=$1
artifactFileName=$2

setVersion=${appVersion}
rootDir=$(pwd)

if [[ ${setVersion} != "" ]]
then
  echo "[INFO] VERSION variable set manually, Build jobs bypassed..."
else
  echo "[INFO] VERSION required, starting Build jobs..."
  currentBranch=${CI_COMMIT_BRANCH}
  revision=${CI_PIPELINE_IID}
  if [[ -n $(echo "${currentBranch}" | grep "release_") ]]
  then
    echo "On release branch"
    releaseDate=$(echo "${currentBranch}" | cut -d "_" -f2)
    major=${releaseDate:0:4}
    minor=${releaseDate:4:2}
    patch=${releaseDate:6:4}
    version="${major}.${minor}.${patch}.${revision}"
    setVersion="${version//.0/.}" # strip leading zeros from dates
  else
    echo "On non-release branch. Will add semantic versioning suffix to build number."
    prefix="$(date +'%Y.%-m.%-d')"
    buildMetaData=$(echo "${currentBranch}" | sed "s/[^0-9a-zA-Z-]/-/g")
    setVersion="${prefix}.${revision}-feature-${buildMetaData}"
  fi 
fi

echo "*************************************************************************"
echo "BUILD_VERSION = ${setVersion}"
if [[ ${appVersion} == "" ]]
then
    echo "COMMIT        = ${CI_COMMIT_SHORT_SHA}"
fi
echo "APPLICATIONS_TO_DEPLOY = ${APPLICATIONS_TO_DEPLOY}"
echo "ENVIRONMENTS_TO_DEPLOY = ${ENVIRONMENTS_TO_DEPLOY}"
echo "CONTINENTS_TO_DEPLOY = ${CONTINENTS_TO_DEPLOY}"
echo "*************************************************************************"

# create the artifact file
echo "BUILD_VERSION=${setVersion}" > ${artifactFileName}
