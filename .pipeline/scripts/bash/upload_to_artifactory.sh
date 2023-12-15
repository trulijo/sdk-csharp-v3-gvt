#!/usr/bin/env bash

set -e

arg_names=(
    "package-assembly-dir"
    "package-name"
    "package-version"
    "artifactory-user"
    "artifactory-pass"
    "artifactory-home-url"
)
ARGS=$(
    getopt --options '' \
        --long 'package-assembly-dir:' \
        --long 'package-name:' \
        --long 'package-version:' \
        --long 'artifactory-user:' \
        --long 'artifactory-pass:' \
        --long 'artifactory-home-url:' \
        -- "$@"
) || exit 128
eval "set -- $ARGS"

declare -A args
while true; do
    case $1 in
        (--package-assembly-dir)
            args["package-assembly-dir"]=$2; shift 2;;
        (--package-name)
            args["package-name"]=$2; shift 2;;
        (--package-version)
            args["package-version"]=$2; shift 2;;
        (--artifactory-user)
            args["artifactory-user"]=$2; shift 2;;
        (--artifactory-pass)
            args["artifactory-pass"]=$2; shift 2;;
        (--artifactory-home-url)
            args["artifactory-home-url"]=$2; shift 2;;
        (--)
            shift; break;;
        (*)
            echo "[ERROR] unknown command line option [$1]" >&2
            exit 128;;
    esac
done
remaining=("$@")
for arg_name in "${arg_names[@]}"
do
    if [ -z "${args[$arg_name]}" ]
    then
        echo "[ERROR] argument $arg_name is not provided." >&2
        exit 128
    fi
done

package_repo=generic-gg-tech-release-local
package_name_w_version=${args["package-name"]}.${args["package-version"]}

cd "${args[package-assembly-dir]}"
zip -r "$package_name_w_version.zip" ./*

checksum_sha1=$(shasum -a 1 "$package_name_w_version.zip" | cut -f1 -d' ')
checksum_md5=$(md5sum "$package_name_w_version.zip" | cut -f1 -d' ')
checksum_sha256=$(shasum -a 256 "$package_name_w_version.zip" | cut -f1 -d' ')

curl --header "X-Checksum-Sha1:${checksum_sha1}" --header "X-Checksum-MD5:${checksum_md5}" --header "X-Checksum-Sha256:${checksum_sha256}" --user "${args[artifactory-user]}:${args[artifactory-pass]}" --upload-file "./$package_name_w_version.zip" "${args[artifactory-home-url]}/${package_repo}/${args[package-name]}/"
