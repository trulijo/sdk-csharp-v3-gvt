#!/bin/bash
    
project_directory=$1
project_file=$2
version=$3 

set -e

publish_dir=$(pwd)/publish
upload_artifacts_script="./.pipeline/scripts/bash/upload_to_artifactory.sh"
csproj=${project_directory}/${project_file}

echo "[DEBUG] csproj = ${csproj}"

mkdir -p ${publish_dir}
chmod 755 ${upload_artifacts_script}

# dotnet build
dotnet nuget add source ${ARTIFACTORY_NUGET_URL} --username ${ARTIFACTORY_USER} --password ${ARTIFACTORY_PASSWORD} --store-password-in-clear-text
echo "[DEBUG] dotnet publish ${csproj} --configuration Release --output ${publish_dir} --framework net6.0 -p:Version=${version} -p:PublishReadyToRun=true --runtime win-x64 --self-contained"
dotnet publish ${csproj} --configuration Release --output ${publish_dir} --framework net6.0 -p:Version=${version} -p:PublishReadyToRun=true --runtime win-x64 --self-contained
echo "[DEBUG] dotnet publish ${csproj} --configuration Release --output ${publish_dir} --framework net6.0 -p:Version=${version} -p:PublishReadyToRun=true --runtime win-x64 --self-contained"    

# upload to Jfrog
${upload_artifacts_script} \
    --package-assembly-dir ${publish_dir} \
    --package-name ${project_directory} \
    --package-version ${version} \
    --artifactory-user ${ARTIFACTORY_USER} \
    --artifactory-pass ${ARTIFACTORY_PASSWORD} \
    --artifactory-home-url ${ARTIFACTORY_URL} 
